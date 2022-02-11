using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Mangment_System
{
    public partial class Loading2_Form : Form
    {
        // make the variable to indicates the period of the loading 
        int icount_loading;
        public Loading2_Form()
        {
            InitializeComponent();
            // initilize the loading counter by zero (0)
            icount_loading = 0;
        }

        private void Loading2_Form_Load(object sender, EventArgs e)
        {
            // on the load of the form first make the animator to this form 
            Form_Animation.SetAnimateWindow(this);
            // then start the ticks of the timer 
            Loading_Timer.Start();
        }

        private void Loading_Timer_Tick(object sender, EventArgs e)
        {
            // in case the counter is 10 
            if(icount_loading == 7)
            {
                // stop the timer 
                Loading_Timer.Stop();
                // hide the current form
                this.Hide(); 
                // make object from the Login  (next) form
                LogIn_Form2 lg = new LogIn_Form2();
                // show the signup form 
                lg.Show();
            }
            // for each tick increament the counter of the timer 
            icount_loading++;
        }
    }
}
