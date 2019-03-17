using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camera
{
    public class CamSettings
    {
        public bool SenorPixelCorrection { get; set; }

        public int ImageDataType { get; set; }

        public int Gain { get; set; }

        public bool FlatFieldCorrection { get; set; }

        public int AutoExposureValue { get; set; }

        public bool AutoExposure { get; set; }
    }
}
