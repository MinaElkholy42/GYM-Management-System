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
    public partial class PasswordChange_Form : Form
    {
        // make object from the options settings Class 
        SettingsOptions_Class so;
        public PasswordChange_Form()
        {
            InitializeComponent();
            // intialize the object from the options settings class 
            so = new SettingsOptions_Class();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // close the current form 
            this.Close();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            // make the form window down the desktop 
            WindowState = FormWindowState.Minimized;
        }

        private void PasswordChange_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the old password text box
            OldPassword_TextBox.Focus();
            OldPassword_TextBox.Select();
        }

        private void OldPassword_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder is in the text box 
            if (OldPassword_TextBox.Text == "Enter The Old Password")
            {
                // remove the place holder 
                OldPassword_TextBox.Text = string.Empty;
                // Put the password char in the text box to protect the password
                OldPassword_TextBox.PasswordChar = '*';
            }
        }

        private void OldPassword_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (OldPassword_TextBox.Text.Trim(so.tcs) == "")
            {
                // put the place holder in the text box 
                OldPassword_TextBox.Text = "Enter The Old Password";
                // remove the password char from the text box using the null character
                OldPassword_TextBox.PasswordChar = '\0';
            }
        }

        private void NewPassword_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder is in the text box 
            if (NewPassword_TextBox.Text == "Enter The New Password")
            {
                // remove the place holder 
                NewPassword_TextBox.Text = string.Empty;
                // Put the password char in the text box to protect the password
                NewPassword_TextBox.PasswordChar = '*';
            }
        }

        private void NewPassword_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (NewPassword_TextBox.Text.Trim(so.tcs) == "")
            {
                // put the place holder in the text box 
                NewPassword_TextBox.Text = "Enter The New Password";
                // remove the password char from the text box using the null character
                NewPassword_TextBox.PasswordChar = '\0';
            }
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Change_Button_Click(sender, e);
        }

        private void ShowPassword_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // if the place holder is not in the text box 
            if (NewPassword_TextBox.Text.Trim(so.tcs) != "Enter The New Password")
            {
                // remove the password char from the text box using the null character
                NewPassword_TextBox.PasswordChar = '\0';
                // change the fore color to seagreen 
                NewPassword_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowPassword_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // if the place holder is not in the text box 
            if (NewPassword_TextBox.Text.Trim(so.tcs) != "Enter The New Password")
            {
                // Put the password char in the text box to protect the password
                NewPassword_TextBox.PasswordChar = '*';
                // change the fore color to White 
                NewPassword_TextBox.ForeColor = Color.White;
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            // Take The Data ///////////////////////////////////////////

            // we take the data from the text boxes using trim to getrid of the additional spaces 
            string old_pass = OldPassword_TextBox.Text.Trim(so.tcs);
            string new_pass = NewPassword_TextBox.Text.Trim(so.tcs);

            // Check the Empty Data //////////////////////////////////////// 
            if (old_pass == "" || new_pass == "" || old_pass == "Enter The Old Password"
                || new_pass == "Enter The New Password")
            {
                // make the alert object 
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired The Old Password " +
                    "and\nThe New Password",
                    Main_Functions.AlertType.error,100);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // Validation of the Data ///////////////////////////////////// 
            
            // check if the entred old password is the right one 
            else if (!so.Check_OldPassword(old_pass))
            {
                // make the alert object 
                Alert_Form af = new Alert_Form("Wrong Data\nThe Old Password is Incorrect",
                    Main_Functions.AlertType.error, 80);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // check if the entred new password is in the right format or not 
            else if (!so.Check_NewPassword(new_pass))
            {
                // make the alert object 
                Alert_Form af = new Alert_Form("Wrong Input\nThe New Password is Not\nin The Correct " +
                    "Format",Main_Functions.AlertType.error, 100);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // check if the new password is the same as the old one 
            // also check that the new password is not exists in the data base before 
            else if (old_pass == new_pass || so.Check_Existance_NewPassword(new_pass))
            {
                // make the alert object 
                Alert_Form af = new Alert_Form("Wrong Data\nPlease Enter Different Password"
                    , Main_Functions.AlertType.error, 80);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // Update Section ///////////////////////////////////////////////////////////////////////

            // we call this function to update the password in the data base 
            so.Update_NewPassword(old_pass, new_pass);
            // now update the password in the managers main functions data of the current log in
            Main_Functions.set_current_password(new_pass);

            // Back To Original ////////////////////////////////////////////////////////////////////

            // make the two text box one with empty string and the other with the place holder 
            OldPassword_TextBox.Text = string.Empty;

            NewPassword_TextBox.Text = "Enter The New Password";
            NewPassword_TextBox.PasswordChar = '\0';
            // make the focous and the select on the OldUserName_TextBox
            OldPassword_TextBox.Focus();
            OldPassword_TextBox.Select();
        }
    }
}
