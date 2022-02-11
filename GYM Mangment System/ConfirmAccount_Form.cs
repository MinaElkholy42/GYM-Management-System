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
    public partial class ConfirmAccount_Form : Form
    {
        // those variables we will use to store the data in the sql database
        string name, username, password, authonticationcode;
        // make this variable as the limit of the number of accounts in the database 
        int limit_number = 5;
        // make the variable from class of the sign up (object) 
        SignUp_Class S_Class;
        // default constructor
        public ConfirmAccount_Form()
        {
            InitializeComponent();
            // make the intialization of the new reference of the object 
            S_Class = new SignUp_Class();
        }

        // paramatrized constructor 
        public ConfirmAccount_Form(string name, string user_name, string password, string code)
        {
            InitializeComponent();
            // make the intialization of the new reference of the object 
            S_Class = new SignUp_Class();
            // get the values in the form variables 
            this.name = name;
            this.username = user_name;
            this.password = password;
            this.authonticationcode = code;
            // set the name to the label of the name 

            Name_Label.Text = name;
            // set the user_name to the label of the user name 
            UserName_Label.Text = user_name;
            // intialize the label of the password with the first two characters of the password 
            Password_Label.Text = "" + password[0] + password[1];
            // loop on the rest of characters of the password 
            for (int i = 2; i < password.Length; ++i) // concatenate for each character * to the string of the label
                Password_Label.Text = Password_Label.Text + '*';
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
            // make object from the sign up form
            SignUp_Form su = new SignUp_Form(name, username, password);
            // show the sign up form 
            su.Show();
        }

        private void Minimization_Button_Click(object sender, EventArgs e)
        {
            // now we want to make the window minimized to the down of the desk top 
            WindowState = FormWindowState.Minimized;
        }

        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Confirm_Button_Click(sender, e);
        }

        private void ConfirmAccount_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form to the animator 
            Form_Animation.SetAnimateWindow(this);
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            // first we want to make sure there is no more than limit number of accounts in the database
            if (S_Class.check_limit_accounts(limit_number))
            {
                // make object form the alert form
                Alert_Form aff = new Alert_Form("Full Database\nYou Can Not Create More Accounts\n" +
                    "Please Contact Us",
                    Main_Functions.AlertType.Information, 100);
                // make the form on the top of the forms
                aff.TopMost = true;
                // show the alert form 
                aff.Show();
                // exit the function 
                return;
            }
            // we call this function to save the data of the account in the data base 
            S_Class.save_managers_data(name, username, password, authonticationcode);

            // make object form the alert form
            Alert_Form af = new Alert_Form("Regestration Done\nSave Those Data\nTo Recover Your Account\n" +
                "Name : " + name + "\nthe Authontication Code : " + authonticationcode,
                Main_Functions.AlertType.success, 155);
            // make the form on the top of the forms
            af.TopMost = true;
            // show the alert form 
            af.Show();

            // hide the current form 
            this.Hide();
            // make a new object from the form 
            LogIn_Form2 lf = new LogIn_Form2();
            // show the login form
            lf.Show();
        }
    }
}
