using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using xiApi.NET;

namespace Camera
{
    public class Ximea : IDisposable
    {
        xiCam myCam;
        bool disposed = false;
        private IntPtr handle;

        public Ximea(IntPtr handle)
        {
            this.handle = handle;
            myCam = new xiCam();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // ***********
            }

            CloseHandle(handle);
            handle = IntPtr.Zero;
            disposed = true;
        }

        [DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);

        ~Ximea()
        {
            Dispose(false);
        }

        public int[] Devices
        {
            get
            {
                int[] devices = new int[0];

                try
                {
                    myCam.GetNumberDevices(out int numDevices);

                    devices = new int[numDevices];
                    for (int i = 0; i < numDevices; i++)
                    {
                        devices[i] = i + 1;
                    }
                }
                catch { }

                return devices;
            }
        }

        public CamSettings GetSettings(int device)
        {
            CamSettings camSettings = null;
            string deviceId = $"b{device}";
            try
            {
                myCam.GetNumberDevices(out int numDevices);
                myCam.OpenDevice(xiCam.OpenDevBy.DeviceUserId, $"b{device}");
                myCam.GetParam(PRM.AEAG, out int aeag);
                myCam.GetParam(PRM.EXPOSURE, out int exposure);
                myCam.GetParam(PRM.IMAGE_DATA_FORMAT, out int format);
                myCam.GetParam(PRM.GAIN, out float gain);
                myCam.GetParam(PRM.FFC, out int ffc);
                myCam.GetParam(PRM.SENS_DEFECTS_CORR, out int sdc);
                camSettings = new CamSettings()
                {
                    AutoExposure = aeag == 1,
                    AutoExposureValue = exposure,
                    FlatFieldCorrection = ffc == 1,
                    Gain = (int)gain,
                    ImageDataType = format,
                    SenorPixelCorrection = sdc == 1
                };
            }
            catch (ApplicationException appExc)
            {
                Error.WriteLog(appExc, deviceId);
            }
            return camSettings;
        }

        public void SetSettings(Settings settings, int device, int[] detected)
        {
            string deviceId = $"b{device}";
            try
            {
                myCam.GetNumberDevices(out int numDevices);
                myCam.OpenDevice(xiCam.OpenDevBy.DeviceUserId, deviceId);
                myCam.SetParam(PRM.AEAG, settings.AutoExposure ? 1 : 0);
                myCam.SetParam(PRM.EXPOSURE, settings.AutoExposureValue);
                myCam.SetParam(PRM.SENS_DEFECTS_CORR, settings.SenorPixelCorrection ? 1 : 0);
                myCam.SetParam(PRM.FFC, settings.FlatFieldCorrection ? 1 : 0);
                myCam.SetParam(PRM.IMAGE_DATA_FORMAT, settings.ImageDataType);
                for (int i = 0; i < detected.Length; i++)
                {
                    myCam.SetParam(PRM.GAIN, i);
                    Property setting = new Property(settings, $"Gain{detected[i]}");
                    myCam.SetParam(PRM.GAIN, float.Parse(setting.Value.ToString()));
                }
            }
            catch (ApplicationException appExc)
            {
                Error.WriteLog(appExc, deviceId);
            }
        }

        public int GetBendwidth(int device)
        {
            string deviceId = $"b{device}";

            try
            {
                myCam.GetNumberDevices(out int numDevices);
                myCam.OpenDevice(xiCam.OpenDevBy.DeviceUserId, deviceId);
                myCam.GetParam(PRM.LIMIT_BANDWIDTH, out int bandwidth);
                //myCam.CloseDevice();
                return bandwidth;
            }
            catch
            {
                return 0;
            }
        }

        public CamImage Capture(int device, int counter, int bandwidth)
        {
            Settings settings = new Settings();
            Property gain = new Property(settings, $"Gain{device}");
            CamImage camImage = null;

            string deviceId = $"b{device}";

            try
            {
                myCam.GetNumberDevices(out int numDevices);
                myCam.OpenDevice(xiCam.OpenDevBy.DeviceUserId, deviceId);

                myCam.SetParam(PRM.AUTO_BANDWIDTH_CALCULATION, 1);

                if (bandwidth > 0)
                {
                    myCam.SetParam(PRM.LIMIT_BANDWIDTH, bandwidth);
                }
                else
                {
                    myCam.GetParam(PRM.LIMIT_BANDWIDTH, out int getbandwidth);
                    myCam.SetParam(PRM.LIMIT_BANDWIDTH, getbandwidth);
                }

                myCam.SetParam(PRM.GAIN, float.Parse(gain.Value.ToString()));
                myCam.SetParam(PRM.IMAGE_DATA_FORMAT, settings.ImageDataType);
                myCam.SetParam(PRM.SENS_DEFECTS_CORR, settings.SenorPixelCorrection ? 1 : 0);
                myCam.SetParam(PRM.FFC, settings.FlatFieldCorrection ? 1 : 0);
                myCam.SetParam(PRM.AEAG, settings.AutoExposure ? 1 : 0);

                if (settings.AutoExposure)
                {
                    myCam.GetParam(PRM.EXPOSURE, out int autoExposureValue);
                    myCam.SetParam(PRM.EXPOSURE, autoExposureValue);
                }
                else
                {
                    myCam.SetParam(PRM.EXPOSURE, settings.AutoExposureValue);
                }

                if (settings.FlatFieldCorrection)
                {
                    try
                    {
                        string flatField = Path.Combine(settings.CorrectionImageDirectory, $"{deviceId}-mid-{ImageData.Items.Where(o => o.Value == settings.ImageDataType).FirstOrDefault().Key}.tif");
                        string darkField = Path.Combine(settings.CorrectionImageDirectory, $"{deviceId}-dark-{ImageData.Items.Where(o => o.Value == settings.ImageDataType).FirstOrDefault().Key}.tif");
                        myCam.SetParam(PRM.FFC_FLAT_FIELD_FILE_NAME, flatField);
                        myCam.SetParam(PRM.FFC_DARK_FIELD_FILE_NAME, darkField);
                    }
                    catch (ApplicationException appExc)
                    {
                        Error.WriteLog(appExc, deviceId);
                    }
                }

                myCam.GetParam(PRM.WIDTH, out int width);
                myCam.GetParam(PRM.HEIGHT, out int height);

                Bitmap myImage = new Bitmap(width, height, (settings.ImageDataType == IMG_FORMAT.RAW8) ? PixelFormat.Format8bppIndexed : PixelFormat.Format16bppGrayScale);

                myCam.SetParam(PRM.BUFFER_POLICY, BUFF_POLICY.SAFE);
                myCam.StartAcquisition();

                if (settings.AutoExposure)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        myCam.GetImage(myImage, 10000);
                    }
                }

                myCam.GetImage(myImage, 10000);

                camImage = new CamImage() {
                    DeviceId = deviceId,
                    Image = myImage,
                    Camera = myCam
                };
            }
            catch (ApplicationException appExc)
            {
                Error.WriteLog(appExc, deviceId);
                if (myCam != null)
                {
                    myCam.StopAcquisition();
                    myCam.CloseDevice();
                }
            }

            return camImage;
        }
    }
}
