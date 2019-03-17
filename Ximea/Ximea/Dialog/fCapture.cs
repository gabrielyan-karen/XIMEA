using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;
using System.Threading;

namespace Camera.Dialog
{
    public partial class fCapture : Form
    {
        Settings settings = new Settings();

        private static int[] detected = new int[0];

        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;

        static ManagementEventWatcher w = null;

        public fCapture()
        {
            InitializeComponent();

            UsbNotification.RegisterUsbDeviceNotification(this.Handle);

            DeviceUpdateEvent();
        }

        private void DeviceUpdateEvent()
        {

            //USBHandler("__InstanceDeletionEvent", "CIM_USBDevice");
            //USBHandler("__InstanceCreationEvent", "CIM_USBDevice");

            Thread.Sleep(2000);

            using (Ximea ximea = new Ximea(IntPtr.Zero))
            {
                try
                {
                    detected = ximea.Devices;
                    settings.Detected = detected.Length;
                }
                catch (ApplicationException appExc)
                {
                    Error.WriteLog(appExc);
                }

                lblDetectedCameras.Text = $"Number of bands detected: {detected.Length}";
                lblDetectedCameras.Refresh();

                try
                {
                    LoadSettings();

                    rbAuto.Enabled = detected.Length > 0;
                    rbManual.Enabled = detected.Length > 0;
                    if (detected.Length > 0)
                        nAutoExposure.Enabled = !settings.AutoExposure;
                    else
                        nAutoExposure.Enabled = false;

                    if (settings.NumberOfBands > detected.Length)
                        cbNumberOfBands.SelectedIndex = detected.Length - 1;
                    else
                        cbNumberOfBands.SelectedIndex = settings.NumberOfBands - 1;

                    cbNumberOfBands.Enabled = detected.Length > 0;
                    cbImageDataType.Enabled = detected.Length > 0;
                    btnAdvancedSettings.Enabled = detected.Length > 0;
                    btnPhoto.Enabled = detected.Length > 0;
                    btnFilePath.Enabled = detected.Length > 0;
                    if (detected.Length == 0)
                        btnPhoto.BackColor = Color.Gray;
                    else
                        btnPhoto.BackColor = Color.FromArgb(98, 176, 90);

                    List<CamSettings> camSettings = GetSettings();
                }
                catch (ApplicationException appExc)
                {
                    Error.WriteLog(appExc);
                }
            }
        }

        private void LoadSettings()
        {
            NumberOfBands numberOfBands = new NumberOfBands(detected);

            rbAuto.Checked = settings.AutoExposure;
            rbManual.Checked = !settings.AutoExposure;
            nAutoExposure.Value = settings.AutoExposureValue;
            nAutoExposure.Enabled = !settings.AutoExposure;
            txtFilePath.Text = settings.ImageSaveLocation;

            cbImageDataType.DataSource = ImageData.DataSource;
            cbImageDataType.DisplayMember = "Key";
            cbImageDataType.ValueMember = "Value";

            cbNumberOfBands.DataSource = null;
            cbNumberOfBands.DisplayMember = "Key";
            cbNumberOfBands.ValueMember = "Value";
            cbNumberOfBands.DataSource = numberOfBands.DataSource;
            cbNumberOfBands.Refresh();

            cbNumberOfBands.SelectedIndex = cbNumberOfBands.Items.IndexOf(
                numberOfBands.Items.SingleOrDefault(o => o.Value == settings.NumberOfBands));

            cbImageDataType.SelectedIndex = cbImageDataType.Items.IndexOf(
                ImageData.Items.SingleOrDefault(o => o.Value == settings.ImageDataType));
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                txtFilePath.Text = folderBrowserDialog.SelectedPath;
                settings.ImageSaveLocation = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnAdvancedSettings_Click(object sender, EventArgs e)
        {
            try
            {
                fAdvancedSettings fAdvancedSettings = new fAdvancedSettings(settings, detected);
                fAdvancedSettings.ShowDialog();
                LoadSettings();
            }
            catch (ApplicationException appExc)
            {
                Error.WriteLog(appExc);
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            nAutoExposure.Enabled = (sender as RadioButton).Checked;
            settings.AutoExposure = !(sender as RadioButton).Checked;
        }

        private void nAutoExposure_ValueChanged(object sender, EventArgs e)
        {
            settings.AutoExposureValue = (int)nAutoExposure.Value;
        }

        private void cbImageDataType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KeyValuePair<string, int> value = (KeyValuePair<string, int>)(sender as ComboBox).SelectedItem;

            if (settings.FlatFieldCorrection)
            {

                var confirmResult = MessageBox.Show("The application will be restarted to apply the changes. Continue?",
                                     "Change Image Data Type",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    settings.ImageDataType = value.Value;
                    notifyIcon.Visible = false;
                    notifyIcon.Dispose();
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    cbImageDataType.SelectedIndex = cbImageDataType.Items.IndexOf(
                        ImageData.Items.SingleOrDefault(o => o.Value == settings.ImageDataType));
                }
            }
            else
            {
                settings.ImageDataType = value.Value;
            }
        }

        private void cbNumberOfBands_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KeyValuePair<Numbers, int> value = (KeyValuePair<Numbers, int>)(sender as ComboBox).SelectedItem;

            settings.NumberOfBands = value.Value;
        }

        private void fCapture_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.ShowInTaskbar = false;
            if (this.WindowState == FormWindowState.Normal)
                this.ShowInTaskbar = true;
        }

        private void fCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notifyIcon != null)
            {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            }

            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            int counter = settings.Counter;
            List<CamImage> camImages = new List<CamImage>();
            int count = (int)cbNumberOfBands.SelectedValue;
            try
            {
                int bandwidth;

                using (Ximea ximea = new Ximea(IntPtr.Zero))
                {
                    bandwidth = ximea.GetBendwidth(detected[0]);
                }

                Parallel.ForEach(detected, (device) =>
                {
                    int tmp = Array.IndexOf(detected, device);
                    if (Array.IndexOf(detected, device) < count)
                    {
                        using (Ximea ximea = new Ximea(IntPtr.Zero))
                        {
                            camImages.Add(
                                ximea.Capture(device, counter, bandwidth));
                        }
                    }
                });

                foreach (CamImage camImage in camImages)
                {
                    try
                    {
                        SaveBmp(camImage.Image, $"{settings.ImageSaveLocation}\\{string.Format(settings.FileName, camImage.DeviceId, counter.ToString("D4"))}");
                        camImage.Camera.StopAcquisition();
                        camImage.Camera.CloseDevice();
                    }
                    catch (ApplicationException appExc)
                    {
                        Error.WriteLog(appExc);
                        camImage.Camera.StopAcquisition();
                        camImage.Camera.CloseDevice();
                    }
                }
            }
            catch (ApplicationException appExc)
            {
                Error.WriteLog(appExc);
            }
        }

        private void lblAutoExposure_Click(object sender, EventArgs e)
        {

        }

        private void fCapture_Load(object sender, EventArgs e)
        {

        }

        private void fCapture_Shown(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://Camera.camera/support/capture");
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbNumberOfBands_BindingContextChanged(object sender, EventArgs e)
        {
            if (cbNumberOfBands.SelectedValue != null)
            {
                settings.NumberOfBands = (int)cbNumberOfBands.SelectedValue;
            }
        }

        private static void SaveBmp(Bitmap bmp, string path)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            BitmapData bitmapData = bmp.LockBits(rect, ImageLockMode.ReadOnly, bmp.PixelFormat);

            var pixelFormats = ConvertBmpPixelFormat(bmp.PixelFormat);

            BitmapSource source = BitmapSource.Create(bmp.Width,
                                                      bmp.Height,
                                                      bmp.HorizontalResolution,
                                                      bmp.VerticalResolution,
                                                      pixelFormats,
                                                      null,
                                                      bitmapData.Scan0,
                                                      bitmapData.Stride * bmp.Height,
                                                      bitmapData.Stride);
            bmp.UnlockBits(bitmapData);


            FileStream stream = new FileStream(path, FileMode.Create);

            TiffBitmapEncoder encoder = new TiffBitmapEncoder();

            encoder.Compression = TiffCompressOption.None;
            encoder.Frames.Add(BitmapFrame.Create(source));

            encoder.Save(stream);
            stream.Close();
        }

        private static System.Windows.Media.PixelFormat ConvertBmpPixelFormat(PixelFormat pixelformat)
        {
            System.Windows.Media.PixelFormat pixelFormats = System.Windows.Media.PixelFormats.Default;

            switch (pixelformat)
            {
                case PixelFormat.Format32bppArgb:
                    pixelFormats = System.Windows.Media.PixelFormats.Bgr32;
                    break;

                case PixelFormat.Format8bppIndexed:
                    pixelFormats = System.Windows.Media.PixelFormats.Gray8;
                    break;

                case PixelFormat.Format16bppGrayScale:
                    pixelFormats = System.Windows.Media.PixelFormats.Gray16;
                    break;
            }

            return pixelFormats;
        }

        private List<CamSettings> GetSettings()
        {
            List<CamSettings> camSettings = new List<CamSettings>();
            using (Ximea ximea = new Ximea(IntPtr.Zero))
            {
                try
                {
                    for (int i = 0; i < detected.Length; i++)
                    {
                        camSettings.Add(ximea.GetSettings(detected[i]));
                    }
                }
                catch (ApplicationException appExc)
                {
                    Error.WriteLog(appExc);
                }
            }
            return camSettings;
        }

        private void RestartApplication(bool YesNo = false)
        {
            if (YesNo)
            {
                var confirmResult = MessageBox.Show("The cameras were changed, need to restart the application. Continue?",
                         "Camera change alert",
                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            else
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == UsbNotification.WmDevicechange)
            {
                using (Ximea ximea = new Ximea(IntPtr.Zero))
                {
                    if (detected.Length != ximea.Devices.Length)
                    {
                        DeviceUpdateEvent();
                        notifyIcon.Visible = false;
                        notifyIcon.Dispose();
                        RestartApplication(false);
                    }
                }
            }
        }

        public void USBHandler(string Event)
        {
            WqlEventQuery q;
            ManagementScope scope = new ManagementScope("root\\CIMV2");
            scope.Options.EnablePrivileges = true;

            try
            {
                q = new WqlEventQuery();
                q.EventClassName = Event;
                q.WithinInterval = new TimeSpan(0, 0, 3);
                q.Condition = @"TargetInstance ISA 'Win32_USBHub'";
                w = new ManagementEventWatcher(scope, q);
                w.EventArrived += new EventArrivedEventHandler(USBEvent);
                w.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (w != null)
                    w.Stop();
            }
        }

        public void USBEvent(object sender, EventArrivedEventArgs e)
        {
            ManagementBaseObject values = (ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value;
            string value = values.Properties["Caption"].Value.ToString();

            if (value != "USB Mass Storage Device")
            {
                var confirmResult = MessageBox.Show("The cameras were changed, need to restart the application. Continue?",
                     "Camera change alert",
                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }
    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
    }

    internal static class UsbNotification
    {
        public const int DbtDevicearrival = 0x8000;
        public const int DbtDeviceremovecomplete = 0x8004;
        public const int WmDevicechange = 0x0219;
        private const int DbtDevtypDeviceinterface = 5;
        private static readonly Guid GuidDevinterfaceUSBDevice = new Guid(Settings.Guid);
        private static IntPtr notificationHandle;

        public static void RegisterUsbDeviceNotification(IntPtr windowHandle)
        {
            DevBroadcastDeviceinterface dbi = new DevBroadcastDeviceinterface
            {
                DeviceType = DbtDevtypDeviceinterface,
                Reserved = 0,
                ClassGuid = GuidDevinterfaceUSBDevice,
                Name = 0
            };

            dbi.Size = Marshal.SizeOf(dbi);
            IntPtr buffer = Marshal.AllocHGlobal(dbi.Size);
            Marshal.StructureToPtr(dbi, buffer, true);

            notificationHandle = RegisterDeviceNotification(windowHandle, buffer, 0);
        }

        public static void UnregisterUsbDeviceNotification()
        {
            UnregisterDeviceNotification(notificationHandle);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr RegisterDeviceNotification(IntPtr recipient, IntPtr notificationFilter, int flags);

        [DllImport("user32.dll")]
        private static extern bool UnregisterDeviceNotification(IntPtr handle);

        [StructLayout(LayoutKind.Sequential)]
        private struct DevBroadcastDeviceinterface
        {
            internal int Size;
            internal int DeviceType;
            internal int Reserved;
            internal Guid ClassGuid;
            internal short Name;
        }
    }
}
