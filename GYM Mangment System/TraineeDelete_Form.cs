using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace GYM_Mangment_System
{
    public partial class TraineeDelete_Form : Form
    {
        // make object form the Trainee options class 
        TraineeOptions_Class to;
        public TraineeDelete_Form()
        {
            InitializeComponent();
            // initialize the object form the trainee options class 
            to = new TraineeOptions_Class();
        }

        // this function to handle the visibilty of the text boxes in the form 
        public void TextBoxes_Visibility(Guna2TextBox Show_TextBox, Guna2TextBox Hide_TextBox)
        {
            // clear both text boxes 
            Show_TextBox.Text = Hide_TextBox.Text = string.Empty;
            // Show the Hidden Text Box 
            Show_TextBox.Visible = true;
            // make the select and the focus on the showed TextBox
            Show_TextBox.Focus();
            Show_TextBox.Select();
            // Hide the other Text Box
            Hide_TextBox.Visible = false;
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Delete_Button_Click(sender, e);
        }

        private void TraineeDelete_Form_Load(object sender, EventArgs e)
        {
            // make the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the the bar code button checked 
            BarCode_Button.Checked = true;
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

        private void BarCode_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the BarCode Button is checked 
            if (BarCode_Button.Checked) // call this function to handle the visibilty 
                TextBoxes_Visibility(Code_TextBox, Phone_TextBox);
        }

        private void Phone_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the Phone Button is checked 
            if (Phone_Button.Checked) // call this function to handle the visibilty 
                TextBoxes_Visibility(Phone_TextBox, Code_TextBox);
        }

        private void ShowPassword_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // in case there is no place holder in the Text Box
            if (Code_TextBox.Text.Trim(to.tcs) != "")
            {
                // remove the password char in the text box using the null character 
                Code_TextBox.PasswordChar = '\0';
                // change the font color to seagreen 
                Code_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowPassword_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // in case there is no place holder in the Text Box
            if (Code_TextBox.Text.Trim(to.tcs) != "")
            {
                // put the password char back in the text box 
                Code_TextBox.PasswordChar = '*';
                // change the font color to white color 
                Code_TextBox.ForeColor = Color.White;
            }
        }

        private void Code_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Code_TextBox.Text.Trim(to.tcs) == "") // place the empty string
                Code_TextBox.Text = string.Empty;
        }

        private void Phone_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Phone_TextBox.Text.Trim(to.tcs) == "") // place the empty string
                Phone_TextBox.Text = string.Empty;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////
            // Take The Data ///////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////
            string code = Code_TextBox.Text.Trim(to.tcs);
            string phone = Phone_TextBox.Text.Trim(to.tcs);


            ///////////////////////////////////////////////////////////////////////////
            // Check Empty Input ///////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // check if the bar code has been entered
            if ((BarCode_Button.Checked && code == ""))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Data InCompelete\nRequired Trainee BarCode ID",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            // check if the Phone has been entered
            else if ((Phone_Button.Checked && phone == ""))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Data InCompelete\nRequired Trainee Phone Number",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            ///////////////////////////////////////////////////////////////////////////
            // Check Existence Of Entered Data ////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////
            
            // check if the entered Bar Code ID Exists in the Data Base
            else if (BarCode_Button.Checked && !(to.CheckExistence_BarCode(code)))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Data\nTrainee BarCode ID Is Not Correct",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            // check if the entered Phone Number Exists in the Data Base
            else if (Phone_Button.Checked && !(to.CheckExistence_Phone(phone)))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Data\nTrainee Phone Number Is Not Correct",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////
            // Get Trainee Name ////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////

            // this variable will hold the name of the trainee
            string name = "";
            // in case the id button is checked 
            if (BarCode_Button.Checked) // call this function to get the name 
                to.GetTraineeName_BarCode(code, ref name);
            // in case the phone button is checked 
            else if (Phone_Button.Checked) // call this function to get the name 
                to.GetTraineeName_Phone(phone, ref name); 

            ////////////////////////////////////////////////////////////////////////////////////////////
            // Delete Trainee ////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////

            // in case the BarCode button is checked 
            if (BarCode_Button.Checked)
            {
                // call this function to handle the delete 
                to.DeleteTrainee_BarCode(code);
                // make the barcode text box clear 
                Code_TextBox.Text = string.Empty;
                // make the focus and the select on the barcode text box 
                Code_TextBox.Focus();
                Code_TextBox.Select();
            }
            // in case the phone button is checked 
            else if (Phone_Button.Checked)
            {
                // call this function to handle the delete 
                to.DeleteTrainee_Phone(phone);
                // make the Phone text box clear 
                Phone_TextBox.Text = string.Empty;
                // make the focus and the select on the Phone text box 
                Phone_TextBox.Focus();
                Phone_TextBox.Select();
            }

            ////////////////////////////////////////////////////////////////////////////////////////////
            // Send User Alert ////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////

            // call this function to handle the alert 
            to.Handle_Alerts("Operation Succeeded\nGood Bye " + name,
                Main_Functions.AlertType.success, 80);
        }

        
    }
}
