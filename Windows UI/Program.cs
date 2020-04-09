using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace BAFactory.XEMail.Windows
{
    static class Program
    {
        private static Mutex mtx;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentCulture = new System.Globalization.CultureInfo("es-AR");
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            mtx = new Mutex(false, Application.ProductName);
            bool free = mtx.WaitOne(TimeSpan.Zero, false);
            if (free)
            {
                Application.Run(new MainForm());
            }
            else
            {
                mtx = null;
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string debugText = string.Format("Message: {0}{3}Source: {1}{3}Stack Trace: {2}", e.Exception.Message, e.Exception.Source, e.Exception.StackTrace, System.Environment.NewLine);
            MainForm.AddDebugInfo(new string[] { debugText });
        }

        static void ReleaseResources()
        {
            if (mtx != null)
            {
                mtx.ReleaseMutex();
            }
        }
    }
}