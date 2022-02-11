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
    public partial class UserNameChange_Form : Form
    {
        // make object from the Settings options Class 
        SettingsOptions_Class so;
        public UserNameChange_Form()
        {
            InitializeComponent();
            // intialize the object from the settings options form 
            so = new SettingsOptions_Class();
        }

        private void UserNameChange_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the current form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the old user name text box 
            OldUserName_TextBox.Focus();
            OldUserName_TextBox.Select();
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

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Change_Button_Click(sender, e);
        }

        private void OldUserName_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (OldUserName_TextBox.Text == "Enter The Old UserName")
                // make it empty 
                OldUserName_TextBox.Text = string.Empty;
        }

        private void OldUserName_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (OldUserName_TextBox.Text.Trim(so.tcs) == "")
                // place the place holder 
                OldUserName_TextBox.Text = "Enter The Old UserName";
        }

        private void NewUserName_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (NewUserName_TextBox.Text == "Enter The New UserName")
                // make it empty 
                NewUserName_TextBox.Text = string.Empty;
        }

        private void NewUserName_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (NewUserName_TextBox.Text.Trim(so.tcs) == "")
                // place the place holder 
                NewUserName_TextBox.Text = "Enter The New UserName";
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            // Take The Entered Data ////////////////////////////////////// 
            string old_username = OldUserName_TextBox.Text.Trim(so.tcs);
            string new_username = NewUserName_TextBox.Text.Trim(so.tcs);
            // Check Empty 

            // check if the entered data is empty or not 
            if (old_username == "" || new_username == "" || old_username == "Enter The Old UserName" ||
                new_username == "Enter The New UserName")
            {
                // make object from the alret form 
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired The Old User Name and\n" +
                    "The New User Name", Main_Functions.AlertType.error, 100);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // Check the Validation of Entered Data ///////////////////////////////////////// 

            // check if the entered old user name is the same as the right one using this function
            else if (!so.Check_OldUserName(old_username))
            {
                // make object from the alret form 
                Alert_Form af = new Alert_Form("Wrong Data\nThe Old User Name is Incorrect"
                    , Main_Functions.AlertType.error, 80);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // check the new user name follow the correct format 
            else if (!so.Check_NewUserName(new_username))
            {
                // make object from the alret form 
                Alert_Form af = new Alert_Form("Wrong Input\nThe New User Name is not\nIn The Correct " +
                    "Format" , Main_Functions.AlertType.error, 100);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // check the new user name is not the same as the old one 
            // and check if the new user name is the same as any one in the data base for other account
            else if (new_username == old_username || so.Check_Existance_NewUserName(new_username))
            {
                // make object from the alret form 
                Alert_Form af = new Alert_Form("Wrong Data\nPlease Enter Different User Name"
                    , Main_Functions.AlertType.error, 80);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }

            // Update Section ////////////////////////////////////////////////////////////////////

            // call this function to update the user name in the data base 
            so.Update_NewUserName(old_username, new_username);
            // update the current login user name by calling this function 
            Main_Functions.set_current_username(new_username);

            // Back To Original ////////////////////////////////////////////////////////////////////

            // make the two text box one with empty string  and the other with the place holder
            OldUserName_TextBox.Text = string.Empty;
            NewUserName_TextBox.Text = "Enter The New UserName";
            // make the focous and the select on the OldUserName_TextBox
            OldUserName_TextBox.Focus();
            OldUserName_TextBox.Select();
        }
    }
}
