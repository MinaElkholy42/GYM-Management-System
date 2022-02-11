using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace GYM_Mangment_System
{
    public partial class SignUp_Form : Form
    {
        // first make object from the SingUp_class
        SignUp_Class S_Class;

        // default constructor
        public SignUp_Form()
        {
            InitializeComponent();
            // make the initialization of the SignUp_Class object 
            S_Class = new SignUp_Class();
        }

        // the paramatrized constructor 
        public SignUp_Form(string name, string username, string password)
        {
            InitializeComponent();
            // make a new reference for the object
            S_Class = new SignUp_Class();
            // assign the values to the textboxes as before 
            Name_TextBox.Text = name;
            UserName_TextBox.Text = username;
            Password_TextBox.Text = ConfirmPassword_TextBox.Text = password;
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            // on the load of the form make the selection and focus on the name text box 
            Name_TextBox.Focus();
            Name_TextBox.Select();
            // set the animation of the form to the animator 
            Form_Animation.SetAnimateWindow(this);
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // this function to exit the application 
            S_Class.exit_application();
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

        private void Password_TextBox_OnValueChanged(object sender, EventArgs e)
        {
            // call this function to make the characters as password for the text box 
            S_Class.make_password(ref Password_TextBox);
        }

        private void ConfirmPassword_TextBox_OnValueChanged(object sender, EventArgs e)
        {
            // call this function to make the characters as password for the text box 
            S_Class.make_password(ref ConfirmPassword_TextBox);
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                SignUp_Button_Click(sender, e);
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            // take the values form the textboxes using trim to Eliminate of any more 
            // spaces on the right or the left
            string name = Name_TextBox.Text.Trim(S_Class.tcs), pass = Password_TextBox.Text.Trim(S_Class.tcs),
                confirm = ConfirmPassword_TextBox.Text.Trim(S_Class.tcs),
                user_name = UserName_TextBox.Text.Trim(S_Class.tcs);
            // first check if any of the textboxes is empty 
            if (name == "" || user_name == "" || pass == "" || confirm == "")
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired Name,UserName\nPasswrod and " +
                    "Confirmation",
                    Main_Functions.AlertType.error, 100);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }
            // first the name must be only characters with out any numbers or signs or _ 
            // use the regular expressions to define the name 
            else if (!(Regex.IsMatch(name, @"^[a-zA-Z ]+$")))
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Input\nThe Name Must Contain Letters Only",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }
            // after that check if the user name start with any charcter and contains only 
            // charachters, numbers and _ sign with out any spaces or signs
            else if (!(Regex.IsMatch(user_name, @"^[a-zA-Z]+[a-zA-Z0-9_]+$")))
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Input\nThe UserName Must Contain Letters,\nNumbers OR " +
                    "Under_Score (_)\nMust Be Without Spaces\nMust Strat With Alphabet",
                    Main_Functions.AlertType.error, 155);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // exit the function 
                return;
            }
            // after That check if the passwords contains at least one dot or one underscore signs 
            // contains atleast one capital characters without any spaces or signs and the length is
            else if (!Regex.IsMatch(pass, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-._]).{8,}$")
                || pass.Contains(" "))
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Input\nThe Password Must Contains At Least:\n" +
                    "One Capital letter\nOne Small Letter\nOne Special Character\nOne Number\n" +
                    "Must Be At Least With Length 8\nMust Be With No Spaces",
                    Main_Functions.AlertType.error, 235);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // exit the function 
                return;
            }

            // check that the password and the confirmed passwords are the same 
            else if (confirm != pass)
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Input\nThe Entered Password is Not the Same\n" +
                    "in the Password TextBox",
                    Main_Functions.AlertType.error, 100);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // exit the function 
                return;
            }

            // this bool to indicate weather the user name or password is in the data base before 
            // so we call this function for this 
            bool the_same = S_Class.search_username_password_identical(user_name, pass);
            // if the flag is on this means it is the same in the data base password or user name 
            if (the_same)
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Data\nPlease Enter Another:\nUser Name OR Password",
                    Main_Functions.AlertType.error, 100);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // exit the function 
                return;
            }
            this.Hide(); // hide the current registration form 
            // we call this function to get it 
            string authuntication_code = S_Class.create_authontication_code();
            // before saving the data in the data base we will move the the confirm account form
            ConfirmAccount_Form ca = new ConfirmAccount_Form(name, user_name, pass, authuntication_code); // with the paramatrized constructor
            ca.Show(); // show the confirm account form
        }

        private void Name_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box contains only spaces 
            if (Name_TextBox.Text.Trim(S_Class.tcs) == "")
                // place the empty string inside the text box 
                Name_TextBox.Text = string.Empty;
        }

        private void UserName_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box contains only spaces 
            if (UserName_TextBox.Text.Trim(S_Class.tcs) == "")
                // place the empty string inside the text box 
                UserName_TextBox.Text = string.Empty;
        }

        private void Password_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box contains only spaces 
            if (Password_TextBox.Text.Trim(S_Class.tcs) == "")
                // place the empty string inside the text box 
                Password_TextBox.Text = string.Empty;
        }

        private void ConfirmPassword_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box contains only spaces 
            if (ConfirmPassword_TextBox.Text.Trim(S_Class.tcs) == "")
                // place the empty string inside the text box 
                ConfirmPassword_TextBox.Text = string.Empty;
        }
    }
}
