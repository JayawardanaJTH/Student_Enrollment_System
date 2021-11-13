using Student_Enrolment_System.Forms;
using System;
using System.Windows.Forms;

namespace Student_Enrolment_System
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
            //Application.Run(new HomePage());
        }
    }
}