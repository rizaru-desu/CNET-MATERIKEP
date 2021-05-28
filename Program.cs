using System;
using System.Threading;
using System.Windows.Forms;

namespace APPS
{
    static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Settings for single instance app start
            const string appName = "MKEP";
            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);
            if (!createdNew)
            {
                //app is already running! Exiting the application  
                MessageBox.Show("Application is already running.");
                return;
            }
            //Settings for single instance app end
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XtraFormMenu());
        }
    }
}
