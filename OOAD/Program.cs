using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD
{
    internal static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
           
            
                const string appName = "OOAD"; // Replace with your application name
                // Check if another instance of the application is already running
                bool createdNew;
                mutex = new Mutex(true, appName, out createdNew);

                if (!createdNew)
                {
                    // Another instance is already running, exit this instance
                    MessageBox.Show("Another instance of the application is already running.");
                    return;
                }

                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //plication.Run(new Form2());

                // Release the mutex on application exit
                mutex.ReleaseMutex();
            
        }
    }
}
