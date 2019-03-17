using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Camera
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class Property
    {
        public Property(object sender, string attribute)
        {

            Value = sender.GetType().GetProperties()
                          .Single(p => p.Name == attribute)
                          .GetValue(sender, null);

        }

        public Type Type { get { return Value.GetType(); } }
        public object Value { get; set; }
    }

    public class Error
    {
        public static void WriteLog(ApplicationException appExc, string deviceId = "")
        {
            try
            {
                string folder = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\errors.log";
                //File.AppendAllText(folder, $"{Environment.NewLine}{DateTime.Now}{Environment.NewLine}{deviceId} - {appExc.Message}");
            }
            catch { }
        }
    }

    public class USB
    {

    }
}
