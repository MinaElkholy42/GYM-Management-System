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
    public partial class EnterReprotWord_Form : Form
    {
        // make object from the main functions class 
        Main_Functions mf;
        // make object of the form we want to open 
        Form open_form;
        // default constructor
        public EnterReprotWord_Form()
        {
            InitializeComponent();
            // initialize the object from the main functions class 
            mf = new Main_Functions();
        }

        // paramatrized constructor
        public EnterReprotWord_Form(Form wantopen_form)
        {
            InitializeComponent();
            // initialize the object from the main functions class 
            mf = new Main_Functions();
            // set the form we want to open 
            open_form = wantopen_form;
        }

        private void EnterReprotWord_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the selection and the focus on the word text box 
            Word_TextBox.Focus();
            Word_TextBox.Select();
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
            // in case the enter button is pressed 
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Enter_Button_Click(sender, e);
        }

        private void ShowWord_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (Word_TextBox.Text.Trim(mf.tcs) != "Enter The Word")
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
            if (Word_TextBox.Text.Trim(mf.tcs) != "Enter The Word")
            {
                // here we hide the entered Word to the user by setting the password char to *
                Word_TextBox.PasswordChar = '*';
                // make the color of the text box as White 
                Word_TextBox.ForeColor = Color.White;
            }
        }

        private void Word_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (Word_TextBox.Text == "Enter The Word")
            {
                // remove the place holder 
                Word_TextBox.Text = string.Empty;
                // add the password char 
                Word_TextBox.PasswordChar = '*';
            }
        }

        private void Word_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (Word_TextBox.Text.Trim(mf.tcs) == string.Empty)
            {
                // put the place holder 
                Word_TextBox.Text = "Enter The Word";
                // remove the password char uisng the null character
                Word_TextBox.PasswordChar = '\0';
            }
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // take the word first with trim 
            string word = Word_TextBox.Text.Trim(mf.tcs);
            // Check for the empty input 
            if (word == "" || word == "Enter The Word")
            {
                // call this function to handle the alerts 
                mf.Handle_Alerts("Data InComplete\nRequired The Report Word",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            // check the wrong entered Word
            else if (word != Main_Functions.get_word())
            {
                // call this function to handle the alerts 
                mf.Handle_Alerts("Wrong Data\nThe Word is InCorrect",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            // this means the word is just right so 

            // close the current window 
            this.Close();
            // open the form we want 
            open_form.Show();
        }
    }
}
