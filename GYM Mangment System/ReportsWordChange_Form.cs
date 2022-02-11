using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GYM_Mangment_System
{
    public partial class ReportsWordChange_Form : Form
    {
        // make object from the Settings Options class
        SettingsOptions_Class so;
        public ReportsWordChange_Form()
        {
            InitializeComponent();
            // intialize the object from the main functions class
            so = new SettingsOptions_Class();
        }

        private void UserNameChange_Form_Load(object sender, EventArgs e)
        {
            // set the animation of this form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the old word text box 
            OldWord_TextBox.Focus();
            OldWord_TextBox.Select();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            // make the form window down the desktop 
            WindowState = FormWindowState.Minimized;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // close the current form 
            this.Close();
        }

        private void ShowWord_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (NewWord_TextBox.Text.Trim(so.tcs) != "Enter The New Word")
            {
                // here we show the entered Code to the user by setting the password char to null
                NewWord_TextBox.PasswordChar = '\0';
                // make the color of the text box as seagreen 
                NewWord_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowWord_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (NewWord_TextBox.Text.Trim(so.tcs) != "Enter The New Word")
            {
                // here we hide the entered Code to the user by setting the password char to *
                NewWord_TextBox.PasswordChar = '*';
                // make the color of the text box as White 
                NewWord_TextBox.ForeColor = Color.White;
            }
        }

        private void OldWord_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (OldWord_TextBox.Text == "Enter The Old Word")
            {
                // make the text box empty 
                OldWord_TextBox.Text = string.Empty;
                // set the password char to the text box 
                OldWord_TextBox.PasswordChar = '*';
            }
        }

        private void OldWord_TextBox_Leave(object sender, EventArgs e)
        {
            // if the place holder is not in the text box and the text box is empty
            if (OldWord_TextBox.Text.Trim(so.tcs) == "")
            {
                // place the place holder in the text box 
                OldWord_TextBox.Text = "Enter The Old Word";
                // remove the password char from the text box using the null character
                OldWord_TextBox.PasswordChar = '\0';
            }
        }

        private void NewWord_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (NewWord_TextBox.Text == "Enter The New Word")
            {
                // make the text box empty 
                NewWord_TextBox.Text = string.Empty;
                // set the password char to the text box 
                NewWord_TextBox.PasswordChar = '*';
            }
        }

        private void NewWord_TextBox_Leave(object sender, EventArgs e)
        {
            // if the place holder is not in the text box and the text box is empty
            if (NewWord_TextBox.Text.Trim(so.tcs) == "")
            {
                // place the place holder in the text box 
                NewWord_TextBox.Text = "Enter The New Word";
                // remove the password char from the text box using the null character
                NewWord_TextBox.PasswordChar = '\0';
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

        private void Change_Button_Click(object sender, EventArgs e)
        {
            // Take the data /////////////////////////////////////////////

            // first take the strings form the textboxes with trim to elminate both side spaces
            string old_word = OldWord_TextBox.Text.Trim(so.tcs);
            string new_word = NewWord_TextBox.Text.Trim(so.tcs); 

            // Empty Data /////////////////////////////////////////////

            // check if there is entered data 
            if (old_word == "" || new_word == "" || old_word == "Enter The Old Word" || 
                new_word == "Enter The New Word")
            {
                // make object from the alert form 
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired The Old Word and\nThe New Word", 
                    Main_Functions.AlertType.error, 100);
                // make the alert on the top of all windows 
                af.TopMost = true;
                // show the alert
                af.Show();
                // exit the function 
                return;
            }

            // Data Validation /////////////////////////////////////////////

            // check if the entered old word is the same as the main functions on by usin this function 
            if (!so.Check_OldWord(old_word))
            {
                // make object from the alert form 
                Alert_Form af = new Alert_Form("Wrong Data\nThe Old Word is Incorrect",
                    Main_Functions.AlertType.error, 80);
                // make the alert on the top of all windows 
                af.TopMost = true;
                // show the alert
                af.Show();
                // exit the function 
                return;
            }

            // check the format of the new word using this function 
            else if (!so.Check_NewWord(new_word))
            {
                // make object from the alert form 
                Alert_Form af = new Alert_Form("Wrong Input\nThe New Word is Not\nin The Correct Format",
                    Main_Functions.AlertType.error, 100);
                // make the alert on the top of all windows 
                af.TopMost = true;
                // show the alert
                af.Show();
                // exit the function 
                return;
            }

            // check that the new word is not is the same as the old word
            else if (old_word == new_word)
            {
                // make object from the alert form 
                Alert_Form af = new Alert_Form("Wrong Data\nPlease Enter Different Word",
                    Main_Functions.AlertType.error, 80);
                // make the alert on the top of all windows 
                af.TopMost = true;
                // show the alert
                af.Show();
                // exit the function 
                return;
            }

            // Set Word //////////////////////////////////////////////////// 

            // call this function to set the new word eneterd 
            Main_Functions.set_word(new_word);
            // make object from the alert form 
            Alert_Form su = new Alert_Form("Operation Succeeded\n" +
                "The New Word has been Set", Main_Functions.AlertType.success, 80);
            // make the alert on the top of all windows 
            su.TopMost = true;
            // show the alert
            su.Show();

            // Write Word in File ///////////////////////////////////
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
            Main_Functions.set_word(new_word);
            // write the word in the file (over write)
            StreamWriter wr = new StreamWriter(path);
            // write the word 
            wr.WriteLine(new_word);
            // close the stream writer
            wr.Close();

            // Back To the Original //////////////////////////////////////// 

            // put the empty string in one text box and the other put the place holder
            OldWord_TextBox.Text = string.Empty;

            NewWord_TextBox.Text = "Enter The New Word";
            NewWord_TextBox.PasswordChar = '\0';

            // make the focus and the select on the 
            OldWord_TextBox.Focus();
            OldWord_TextBox.Select();
        }
    }
}
