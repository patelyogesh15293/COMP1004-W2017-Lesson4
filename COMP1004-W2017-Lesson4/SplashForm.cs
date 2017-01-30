using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // 1. Initialize the next form
            CalculatorForm calculatorForm = new CalculatorForm();

            // 2. create a refernace to the parentform
            calculatorForm.parentForm = this;
            this.SplashFormTimer.Enabled = false;
            this.Hide();
            Program.myCalculatorForm.Show();
        }
    }
}
