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
using System.IO;
namespace GYM_Mangment_System
{
    public partial class SetReportsWord_Form : Form
    {
        // this is the object form the class that hold all the main functions we use in the code 
        LogIn_Class L_Class;
        public SetReportsWord_Form()
        {
            InitializeComponent();
            // make a new refrence in the code 
            L_Class = new LogIn_Class();
        }

        private void SetReportsWord_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the word text box
            Word_TextBox.Focus();
            Word_TextBox.Select();
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

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Confirm_Button_Click (sender, e);
        }

        private void ShowWord_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (Word_TextBox.Text.Trim(L_Class.tcs) != "Enter The Word")
            {
                // here we show the entered Word to the user by setting the password char to null
                Word_TextBox.PasswordChar = '\0';
                // make the color of the text box as seagreen 
                Word_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowWord_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (Word_TextBox.Text.Trim(L_Class.tcs) != "Enter The Word")
            {
                // here we hide the entered Word to the user by setting the password char to *
                Word_TextBox.PasswordChar = '*';
                // make the color of the text box as White 
                Word_TextBox.ForeColor = Color.White;
            }
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            // first get the word from the text box with the trim from the both sides of the spaces
            string word = Word_TextBox.Text.Trim(L_Class.tcs); 
            // check the word if it is empty (no data entered) 
            if (word == "" || word == "Enter The Word")
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired Reprot Word",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top of the forms
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }

            // now check if the word follow the required format 
            else if (!Regex.IsMatch(word,
                @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-._]).{8,}$")
                || word.Contains(" "))
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Input\nThe Word Is Not In the Correct Format",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top of the forms
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }
            // make object form the alert form
            Alert_Form su = new Alert_Form("Operation Succeeded\nThe Word has been Set",
                Main_Functions.AlertType.success, 80);
            // make the form on the top of the forms
            su.TopMost = true;
            // show the alert form 
            su.Show();

            // make the path of the file word 
            string path = "Word.txt";

            // if the file is not in the directory 
            if (!File.Exists(path))
            {
                // make stream writer with the path
                StreamWriter sw = new StreamWriter(path);
                // wirte the following content with out taking any line 
                sw.Write(Properties.Resources.Word);
                // close the stream writer 
                sw.Close();
            }
            // set the word in the main functions class 
            Main_Functions.set_word(word);
            // write the word in the file (over write)
            StreamWriter wr = new StreamWriter(path);
            // write the word 
            wr.WriteLine(word);
            // close the stream writer
            wr.Close();

            // as all things are done now move to the controls form 
            // hide the current form
            this.Hide();
            // make a new object from the controls form
            NewControls_Form cf = new NewControls_Form();
            // show the controls form
            cf.Show();
        }

        private void Word_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the TextBox with the place holder 
            if (Word_TextBox.Text == "Enter The Word")
            {
                // clear the text box string 
                Word_TextBox.Text = String.Empty;
                // make the password char as * 
                Word_TextBox.PasswordChar = '*';
            }
        }

        private void Word_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the Word with the place holder 
            if (Word_TextBox.Text.Trim(L_Class.tcs) == "")
            {
                // clear the text box string 
                Word_TextBox.Text = "Enter The Word";
                // clear the password char by setting it to the null character 
                Word_TextBox.PasswordChar = '\0';
            }
        }
    }
}
