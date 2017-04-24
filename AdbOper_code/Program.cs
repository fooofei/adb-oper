using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace AdbOper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RunOneInstance();
        }
        public static void RunOneInstance()
        {
            bool createNew;

            using (System.Threading.Mutex mutex = new System.Threading.Mutex(true,
                "Global\\"+System.Windows.Forms.Application.ProductName, out createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
        }//RunOneInstance
        


        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }

    
}
