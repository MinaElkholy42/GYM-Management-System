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
    public partial class Remember_Form : Form
    {
        // make an object from the remeber class 
        Remeber_Class R_Class;
        public Remember_Form()
        {
            InitializeComponent();
            // make a new reference for the remember class 
            R_Class = new Remeber_Class();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // this function to exit the application 
            R_Class.exit_application();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            // hide the current form 
            this.Hide();
            // make object from the log in form 
            LogIn_Form2 lg = new LogIn_Form2();
            // show the login form 
            lg.Show();
        }

        private void Minimization_Button_Click(object sender, EventArgs e)
        {
            // now we want to make the window minimized to the down of the desk top 
            WindowState = FormWindowState.Minimized;
        }

        private void Code_TextBox_OnValueChanged(object sender, EventArgs e)
        {
            // call this function to make the text box as password entered 
            R_Class.make_password(ref Code_TextBox);
        }

        private void Remember_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form to the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and selection on the name text box
            Name_TextBox.Focus();
            Name_TextBox.Select();
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Remeber_Button_Click(sender, e);
        }

        private void Remeber_Button_Click(object sender, EventArgs e)
        {
            // take the values form the textboxes 
            string name = Name_TextBox.Text.Trim(R_Class.tcs), code = Code_TextBox.Text.Trim(R_Class.tcs);
            // first check if there is data in the table 
            if (!R_Class.check_managers_existing()) // in case there is no data
            {
                // make object from the alert 
                Alert_Form af = new Alert_Form("Empty Database\nThere are no Accounts To Recover !!!",
                    Main_Functions.AlertType.Information, 80);
                // make the form on the top most of the other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }
            // make the id to know the operation success or failure 
            int id = 0;
            // first check if any of the textboxes is empty 
            if (name == "Enter Your Name" || code == "Enter Your Authontication Code"
                || name == "" || code == "")
            {
                // make object from the alert 
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired the Name and\nthe Authontication Code",
                    Main_Functions.AlertType.error, 100);
                // make the form on the top most of the other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // Exit the function
                return;
            }

            // if the data is filled in both text boxes so we will move to check with the data base  
            // we call this function to search the data base and send message to the user 
            R_Class.search_name_code(name, code, ref id);
            // in case the success of the operation
            if (id != 0)// call this function for this operation 
                R_Class.back_to_original(ref Name_TextBox, ref Code_TextBox);
        }

        private void Name_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box contains only spaces 
            if (Name_TextBox.Text.Trim(R_Class.tcs) == "")
                // place the empty string inside the text box 
                Name_TextBox.Text = string.Empty;
        }

        private void Code_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box contains only spaces 
            if (Code_TextBox.Text.Trim(R_Class.tcs) == "")
                // place the empty string inside the text box 
                Code_TextBox.Text = string.Empty;
        }
    }
}
