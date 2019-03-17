using Camera.Dialog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using xiApi.NET;

namespace Camera
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mtex = new Mutex(true, "CameraCamera", out bool instance))
            {
                if (instance)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new fCapture());
                    mtex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("An application instance is already running");
                }
            }
        }
    }
}
