using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camera
{
    public class Settings
    {
        public bool SenorPixelCorrection
        {
            get
            {
                return Properties.Settings.Default.SenorPixelCorrection;
            }
            set
            {
                Properties.Settings.Default.SenorPixelCorrection = value;
                Properties.Settings.Default.Save();
            }
        }

        public int NumberOfBands
        {
            get
            {
                return Properties.Settings.Default.NumberOfBands;
            }
            set
            {
                Properties.Settings.Default.NumberOfBands = value;
                Properties.Settings.Default.Save();
            }
        }

        public string ImageSaveLocation
        {
            get
            {
                return Properties.Settings.Default.ImageSaveLocation;
            }
            set
            {
                Properties.Settings.Default.ImageSaveLocation = value;
                Properties.Settings.Default.Save();
            }
        }

        public int ImageDataType
        {
            get
            {
                return Properties.Settings.Default.ImageDataType;
            }
            set
            {
                Properties.Settings.Default.ImageDataType = value;
                Properties.Settings.Default.Save();
            }
        }

        public int Gain4
        {
            get
            {
                return Properties.Settings.Default.Gain4;
            }
            set
            {
                Properties.Settings.Default.Gain4 = value;
                Properties.Settings.Default.Save();
            }
        }

        public int Gain3
        {
            get
            {
                return Properties.Settings.Default.Gain3;
            }
            set
            {
                Properties.Settings.Default.Gain3 = value;
                Properties.Settings.Default.Save();
            }
        }

        public int Gain2
        {
            get
            {
                return Properties.Settings.Default.Gain2;
            }
            set
            {
                Properties.Settings.Default.Gain2 = value;
                Properties.Settings.Default.Save();
            }
        }

        public int Gain1
        {
            get
            {
                return Properties.Settings.Default.Gain1;
            }
            set
            {
                Properties.Settings.Default.Gain1 = value;
                Properties.Settings.Default.Save();
            }
        }

        public bool FlatFieldCorrection
        {
            get
            {
                return Properties.Settings.Default.FlatFieldCorrection;
            }
            set
            {
                Properties.Settings.Default.FlatFieldCorrection = value;
                Properties.Settings.Default.Save();
            }
        }

        public string CorrectionImageDirectory
        {
            get
            {
                return Properties.Settings.Default.CorrectionImageDirectory;
            }
            set
            {
                Properties.Settings.Default.CorrectionImageDirectory = value;
                Properties.Settings.Default.Save();
            }
        }

        public int AutoExposureValue
        {
            get
            {
                return Properties.Settings.Default.AutoExposureValue;
            }
            set
            {
                Properties.Settings.Default.AutoExposureValue = value;
                Properties.Settings.Default.Save();
            }
        }

        public bool AutoExposure
        {
            get
            {
                return Properties.Settings.Default.AutoExposure;
            }
            set
            {
                Properties.Settings.Default.AutoExposure = value;
                Properties.Settings.Default.Save();
            }
        }

        public int Counter
        {
            get
            {
                Properties.Settings.Default.Counter += 1;
                Properties.Settings.Default.Save();
                return Properties.Settings.Default.Counter;
            }
            set
            {
                Properties.Settings.Default.Counter = value;
                Properties.Settings.Default.Save();
            }
        }

        public int Detected
        {
            get
            {
                return Properties.Settings.Default.Detected;
            }
            set
            {
                Properties.Settings.Default.Detected = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string Guid
        {
            get
            {
                return Properties.Settings.Default.Guid;
            }
        }

        public static bool UsbRestart
        {
            get
            {
                return Properties.Settings.Default.UsbRestart;
            }
        }

        public string FileName
        {
            get
            {
                //return $"BUZ_{DateTime.Now.ToString("yyyMMdd")}_{DateTime.Now.ToString("hhmmss")}_{"{1}"}_{"{0}"}.tif";
                return $"BUZ_{DateTime.Now.ToString("yyyMMdd")}_{"{1}"}_{"{0}"}.tif";
            }
        }
    }
}
