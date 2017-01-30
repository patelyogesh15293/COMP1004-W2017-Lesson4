using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson4
{
    public static class Program
    {
        // Declare public static form
        public static SplashForm mySplashForm;

        // Declare public static form
        public static CalculatorForm myCalculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize SplashForm
            Program.mySplashForm = new SplashForm();
            //Initial CalculatorForm
            Program.myCalculatorForm = new CalculatorForm();
            Application.Run(Program.mySplashForm);
        }
    }
}
