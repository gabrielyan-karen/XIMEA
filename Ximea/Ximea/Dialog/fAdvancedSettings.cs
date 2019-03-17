using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xiApi.NET;

namespace Camera.Dialog
{
    public partial class fAdvancedSettings : Form
    {
        Settings settings;
        int[] detected;

        public fAdvancedSettings(Settings configurations, int[] cameras)
        {
            InitializeComponent();

            settings = configurations;
            detected = cameras;

            LoadSettings();
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                CorrectionImageDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Gain1_Scroll(object sender, EventArgs e)
        {
            lblGainValue1.Text = $"{Gain1.Value} dB";
            btnApply.Enabled = !CheckChanged(sender, "Value");
        }

        private void Gain2_Scroll(object sender, EventArgs e)
        {
            lblGainValue2.Text = $"{Gain2.Value} dB";
            btnApply.Enabled = !CheckChanged(sender, "Value");
        }

        private void Gain3_Scroll(object sender, EventArgs e)
        {
            lblGainValue3.Text = $"{Gain3.Value} dB";
            btnApply.Enabled = !CheckChanged(sender, "Value");
        }

        private void Gain4_Scroll(object sender, EventArgs e)
        {
            lblGainValue4.Text = $"{Gain4.Value} dB";
            btnApply.Enabled = !CheckChanged(sender, "Value");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SaveSettings();
            btnApply.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //LoadSettings();
            ResetSettings();
            //btnApply.Enabled = false;
        }

        private void SenorPixelCorrection_CheckedChanged(object sender, EventArgs e)
        {
            if (SenorPixelCorrection.IsHandleCreated)
                btnApply.Enabled = !CheckChanged(sender, "Checked");
        }

        private void rbSenorPixelCorrectionOff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FlatFieldCorrection_CheckedChanged(object sender, EventArgs e)
        {
            if (FlatFieldCorrection.IsHandleCreated)
                btnApply.Enabled = !CheckChanged(sender, "Checked");
        }

        private void rbFlatFieldCorrectionOff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CorrectionImageDirectory_TextChanged(object sender, EventArgs e)
        {
            if (CorrectionImageDirectory.IsHandleCreated)
                btnApply.Enabled = !CheckChanged(sender, "Text");
        }

        private void ResetSettings()
        {
            settings.Gain1 = 0;
            settings.Gain2 = 0;
            settings.Gain3 = 0;
            settings.Gain4 = 0;
            settings.Counter = 0;
            settings.ImageSaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            settings.CorrectionImageDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            settings.AutoExposure = false;
            settings.AutoExposureValue = 10000;
            settings.FlatFieldCorrection = false;
            settings.ImageDataType = IMG_FORMAT.RAW8;
            settings.NumberOfBands = detected.Length;
            settings.SenorPixelCorrection = false;

            LoadSettings();
        }

        private void LoadSettings()
        {
            lblGainValue1.Text = $"{settings.Gain1} dB";
            lblGainValue2.Text = $"{settings.Gain2} dB";
            lblGainValue3.Text = $"{settings.Gain3} dB";
            lblGainValue4.Text = $"{settings.Gain4} dB";

            Gain1.Enabled = detected.Length > 0;
            Gain1.Value = settings.Gain1;
            Gain2.Enabled = detected.Length > 1;
            Gain2.Value = settings.Gain2;
            Gain3.Enabled = detected.Length > 2;
            Gain3.Value = settings.Gain3;
            Gain4.Enabled = detected.Length > 3;
            Gain4.Value = settings.Gain4;

            CorrectionImageDirectory.Text = settings.CorrectionImageDirectory;

            if (settings.SenorPixelCorrection)
                SenorPixelCorrection.Checked = true;
            else
                rbSenorPixelCorrectionOff.Checked = true;

            if (settings.FlatFieldCorrection)
                FlatFieldCorrection.Checked = true;
            else
                rbFlatFieldCorrectionOff.Checked = true;
        }

        private void SaveSettings()
        {
            settings.Gain1 = Gain1.Value;
            settings.Gain2 = Gain2.Value;
            settings.Gain3 = Gain3.Value;
            settings.Gain4 = Gain4.Value;

            settings.SenorPixelCorrection = SenorPixelCorrection.Checked;
            settings.FlatFieldCorrection = FlatFieldCorrection.Checked;
            settings.CorrectionImageDirectory = CorrectionImageDirectory.Text;
        }

        private bool CheckChanged(object sender, string attribute)
        {
            Control c = (Control)sender;

            Property control = new Property(c, attribute);
            Property setting = new Property(settings, c.Name);

            return control.Value == setting.Value;
        }

        private void lblSenorPixelCorrection_Click(object sender, EventArgs e)
        {

        }
    }
}
