using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xiApi.NET;

namespace Camera
{
    public class NumberOfBands
    {
        public NumberOfBands(int[] detected)
        {
            Detected = new List<Numbers>();

            foreach (int item in detected)
            {
                Detected.Add((Numbers)Enum.ToObject(typeof(Numbers), item));
            }
        }

        public Dictionary<Numbers, int> Items
        {
            get
            {
                Dictionary<Numbers, int> list = new Dictionary<Numbers, int>();

                foreach (Numbers item in Detected)
                {
                    list.Add(item, (int)item);
                }

                return list;
            }
        }

        public BindingSource DataSource
        {
            get
            {
                try
                {
                    return new BindingSource(Items, null);
                }
                catch
                {
                    return null;
                }
            }
        }

        private List<Numbers> Detected { get; set; }
    }

    public class ImageData
    {
        public static Dictionary<string, int> Items
        {
            get
            {
                Dictionary<string, int> list = new Dictionary<string, int>();

                list.Add("8-bit", IMG_FORMAT.RAW8);
                list.Add("10-bit", IMG_FORMAT.RAW16);

                return list;
            }
        }

        public static BindingSource DataSource
        {
            get
            {
                return new BindingSource(Items, null);
            }
        }
    }

    public class CamImage
    {
        public string DeviceId { get; set; }
        public xiCam Camera { get; set; }
        public Bitmap Image { get; set; }
    }
}
