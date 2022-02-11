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
    public partial class Alert_Form : Form
    {
        // this counter for the top of the form increament in the show 
        int icounter;
        // make this variable to handle the opacity of the 
        double opacity_amount;
        // default constructor 
        public Alert_Form()
        {
            InitializeComponent();
            // initialize the icounter 
            icounter = 70;
            // initialize the opacity amount 
            opacity_amount = 0.01;
        }

        // paramatrized constructor 
        public Alert_Form(string message, Main_Functions.AlertType alert_type, int height_form)
        {

            InitializeComponent();
            // make the width of the form as the user sent 
            this.Height = height_form;
            // initialize the icounter 
            icounter = 0;
            // in all cases make the text of the label to the message sent 
            Message_Label.Text = message;
            // first if the alert type is error then 
            if (alert_type == Main_Functions.AlertType.error)
            {
                // change the background to red 
                this.BackColor = Color.Red;
                // change the back ground color of the button to be red
                Close_Button.BackColor = Color.Red;
                // assign the error icon to the picture box
                Icon_PictureBox.Image = Properties.Resources.Error_1;
            }
            // second if the alert type is success then 
            else if (alert_type == Main_Functions.AlertType.success)
            {
                // change the background to seagreen     
                this.BackColor = Color.SeaGreen;
                // change the back ground color of the button to be red
                Close_Button.BackColor = Color.SeaGreen;
                // assign the right icon to the picture box
                Icon_PictureBox.Image = Properties.Resources.Right_1;
            }
            // third if the alert type is just information
            else if (alert_type == Main_Functions.AlertType.Information)
            {
                // change the background to gray     
                this.BackColor = Color.DarkGray;
                // change the back ground color of the button to be dark grey
                Close_Button.BackColor = Color.DarkGray;
                // assign the right icon to the picture box
                Icon_PictureBox.Image = Properties.Resources.Inventory_1;
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // close the pop out alret 
            this.Close();
        }

        private void Alert_Form_Load(object sender, EventArgs e)
        {
            // on the load of the form make it in the most top of the screen on the left 
            this.Top = -1 * (this.Height); // assign the height to be on the top (not inside the screen)
            // make the left coordinate according to the screen width and the width of the from assigned to 
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            // start the timer of the alert to show and close 
            Show_Timer.Start(); 
        }

        private void Show_Timer_Tick(object sender, EventArgs e)
        {
            // in case the top of the screen is less than 60 (the position wanted for the pop) 
            if (this.Top < 60)
            {
                // add to the top the counter 
                this.Top += icounter;
                // add the icounter to make the message faster in the show 
                icounter += 30;
            }
            else
            {
                // stop the timer to stop the message
                Show_Timer.Stop();
                // begin the timer on the close of the form 
                Close_Timer.Start();
            }
        }

        private void Close_Timer_Tick(object sender, EventArgs e)
        {
            // while the opacity of the form is not 0 
            if (this.Opacity > 0)
            {
                // decrease the opacity of the form
                this.Opacity -= opacity_amount;
                opacity_amount += 0.0015;
            }
            // other case close the window
            else
                this.Close();
        }
    }
}
