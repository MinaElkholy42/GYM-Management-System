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
    public partial class LogIn_Form2 : Form
    {
        // this is the object form the class that hold all the main functions we use in the code 
        LogIn_Class L_Class;
        public LogIn_Form2()
        {
            InitializeComponent();
            // make a new refrence in the code 
            L_Class = new LogIn_Class();
        }

        private void LogIn_Form2_Load(object sender, EventArgs e)
        {
            // make the select and the focus on the User Name Text Box 
            UserName_TextBox.Focus();
            UserName_TextBox.Select();
            // check if the default user name (and the password) is not empty 
            if (Properties.Settings.Default.UserName != string.Empty) // then 
            {
                // save the user name to the text box 
                UserName_TextBox.Text = Properties.Settings.Default.UserName;
                // save the password to the text box 
                Password_TextBox.Text = Properties.Settings.Default.Password;
                // make the password with the * charater security 
                Password_TextBox.PasswordChar = '*';
                // make the check box as checked 
                Remember_Switch.Checked = true;
            }
            // set the animation of the form to the animator 
            Form_Animation.SetAnimateWindow(this); 
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // this function to exit the application 
            L_Class.exit_application();
        }

        private void Minimization_Button_Click(object sender, EventArgs e)
        {
            // make the window minimized down to the bottom of the desktop 
            WindowState = FormWindowState.Minimized;
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            // hide the current form 
            this.Hide();
            // make object from the regestration form 
            SignUp_Form su = new SignUp_Form();
            // show the sign up form 
            su.Show();
        }

        private void Recover_Button_Click(object sender, EventArgs e)
        {
            // hide the current form 
            this.Hide();
            // make object from the Recover form 
            Remember_Form rf = new Remember_Form();
            // show the Recover form 
            rf.Show();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            // first make sure there is data in the table of managers in database 
            if (!L_Class.check_managers_existing())
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Empty Database\nThere are no Accounts To Login !!!",
                    Main_Functions.AlertType.Information, 80);
                // make the form on the top of the forms
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // exit the function 
                return;
            }

            //trim the user name and the password to make sure there is no spaces entered 
            string user_name = UserName_TextBox.Text.Trim(L_Class.tcs);
            string user_password = Password_TextBox.Text.Trim(L_Class.tcs);
            // check if there is any data entered in the text box (user name and password together)
            if (user_name == "" || user_password == "" || user_name == "Enter The UserName" 
               || user_password == "Enter The Password")
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired UserName and Password",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top of the forms
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }
            if (L_Class.search_username_password(user_name, user_password))
            {
                // if the check box of keep me signed in is checked then -> 
                if (Remember_Switch.Checked)
                {
                    // save the user name and password as the default and save them 
                    Properties.Settings.Default.UserName = user_name; // save the user name as default
                    Properties.Settings.Default.Password = user_password; // save the Password as default
                    // save the settings 
                    Properties.Settings.Default.Save();
                }
                // not to save the last data we enetred as the default values
                else
                {
                    // save the user name and password as the default and save them as empty
                    Properties.Settings.Default.UserName = ""; // save the user name as default (empty)
                    Properties.Settings.Default.Password = ""; // save the Password as default (empty)
                    // save the settings(empty)
                    Properties.Settings.Default.Save();
                }

                // set the current username 
                Main_Functions.set_current_username(user_name);
                // set the current password 
                Main_Functions.set_current_password(user_password);

                // check if the word of the reports is entered or not by using this function
                if (!L_Class.Check_Word())
                {
                    // this means there is no word so we move to this form to enter the word
                    // hide the current form
                    this.Hide();
                    // make a new object from the Reports Word Form
                    SetReportsWord_Form sf = new SetReportsWord_Form();
                    // show the controls form
                    sf.Show();
                }
                // in case the word is enterd 
                else 
                {
                    // hide the current form
                    this.Hide();
                    // make a new object from the controls form
                    NewControls_Form cf = new NewControls_Form();
                    // show the controls form
                    cf.Show();
                }
            }

            // this means the entered password , user name or both are wrong so send Error message to the user 
            else
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Data\n" +
                    "Please Check the Entered\nUserName Or Password", Main_Functions.AlertType.error, 100);
                // make the form on the top of the forms
                af.TopMost = true;
                // show the alert form 
                af.Show();
            }
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                LogIn_Button_Click(sender, e);
        }

        private void ShowPassword_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (Password_TextBox.Text != "Enter The Password" || Password_TextBox.Text == "")
            {
                // here we show the entered password to the user by setting the password char to null
                Password_TextBox.PasswordChar = '\0';
                // make the color of the text box as seagreen 
                Password_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowPassword_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (Password_TextBox.Text != "Enter The Password" || Password_TextBox.Text == "")
            {
                // here we hide the entered password to the user by setting the password char to *
                Password_TextBox.PasswordChar = '*';
                // make the color of the text box as White 
                Password_TextBox.ForeColor = Color.White;
            }
        }

        private void UserName_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the user name with the place holder 
            if (UserName_TextBox.Text == "Enter The UserName") // clear the text box string 
                UserName_TextBox.Text = String.Empty;
        }

        private void UserName_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the user name without the place holder and empty
            if (UserName_TextBox.Text.Trim(L_Class.tcs) == String.Empty) // Put the text box PlaceHolder 
                UserName_TextBox.Text = "Enter The UserName";
        }

        private void Password_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the Password with the place holder 
            if (Password_TextBox.Text == "Enter The Password")
            {
                // clear the text box string 
                Password_TextBox.Text = String.Empty;
                // make the password char as * 
                Password_TextBox.PasswordChar = '*';
            }
        }

        private void Password_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the Password with the place holder 
            if (Password_TextBox.Text.Trim(L_Class.tcs) == "")
            {
                // clear the text box string 
                Password_TextBox.Text = "Enter The Password";
                // clear the password char by setting it to the null character 
                Password_TextBox.PasswordChar = '\0';
            }
        }
    }
}
