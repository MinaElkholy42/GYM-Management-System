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
    public partial class TraineeUpdate_Form : Form
    {
        // make object from the trainee options class 
        TraineeOptions_Class to;
        public TraineeUpdate_Form()
        {
            InitializeComponent();
            // intialzie the object from the trainee options class 
            to = new TraineeOptions_Class();
        }

        private void TraineeUpdate_Form_Load(object sender, EventArgs e)
        {
            // set the animation of this form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the selection and the focus on the id text box 
            Code_TextBox.Focus();
            Code_TextBox.Select();
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

        private void ShowCode_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // in case there is no Text in the Text Box just the place holder
            if (Code_TextBox.Text.Trim(to.tcs) != "Enter The BarCode ID")
            {
                // remove the password char in the text box using the null character 
                Code_TextBox.PasswordChar = '\0';
                // change the font color to seagreen 
                Code_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowCode_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // in case there is no Text in the Text Box just the place holder
            if (Code_TextBox.Text.Trim(to.tcs) != "Enter The BarCode ID")
            {
                // put the password char back in the text box 
                Code_TextBox.PasswordChar = '*';
                // change the font color to white color 
                Code_TextBox.ForeColor = Color.White;
            }
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Update_Button_Click(sender, e);
        }

        private void Code_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // if the entered button is pressed 
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                ConfirmBarCode_Button_Click(sender, e);
        }

        private void Code_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder in the text box 
            if (Code_TextBox.Text == "Enter The BarCode ID")
            {
                // remove the place holder 
                Code_TextBox.Text = string.Empty;
                // put the character of the password char 
                Code_TextBox.PasswordChar = '*';
            }
        }

        private void Code_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Code_TextBox.Text.Trim(to.tcs) == "")
            {
                // remove the password char from the text box using the null character
                Code_TextBox.PasswordChar = '\0';
                // put the place holder back in the text box 
                Code_TextBox.Text = "Enter The BarCode ID";
            }
        }

        private void Name_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Name_TextBox.Text == "Enter The New Name")
                // remove the place holder 
                Name_TextBox.Text = string.Empty;
        }

        private void Name_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Name_TextBox.Text.Trim(to.tcs) == string.Empty)
                // put the place holder 
                Name_TextBox.Text = "Enter The New Name";
        }

        private void Phone_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Phone_TextBox.Text == "Enter The New Phone Number")
                // remove the place holder 
                Phone_TextBox.Text = string.Empty;
        }

        private void Phone_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Phone_TextBox.Text.Trim(to.tcs) == string.Empty)
                // put the place holder 
                Phone_TextBox.Text = "Enter The New Phone Number";
        }

        private void Address_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Address_TextBox.Text == "Enter The New Address")
                // remove the place holder 
                Address_TextBox.Text = string.Empty;
        }

        private void Address_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Address_TextBox.Text.Trim(to.tcs) == string.Empty)
                // put the place holder 
                Address_TextBox.Text = "Enter The New Address";
        }

        // this function to handle the visibilty 
        public void HandleCodeTextBox_Events(bool visible_value, int id = 0)
        {
            // clear the text boxes with their place holders 
            Name_TextBox.Text = "Enter The New Name";
            // Address_TextBox.Text = "Enter The New Address";
            Phone_TextBox.Text = "Enter The New Phone Number";
            // clear the Picture Box location and image 
            // TraineeImage_PictureBox.ImageLocation = null;
            // TraineeImage_PictureBox.Image = null;

            // make the focus and the select on the ID_TextBox if id is 1 
            if (id == 1)
            {
                // make the focus and the select on the id text box 
                Code_TextBox.Focus();
                Code_TextBox.Select();

            }
            // assign the visible value to the rest of the controls in the tool 
            Main_Saperator.Visible = CurrentData_Label.Visible = CurrentData_Saperator.Visible
               = NameHeader_Label.Visible = PhoneHeader_Label.Visible // = AddressHeader_Label.Visible
                = Name_Label.Visible = Phone_Label.Visible // = Address_Label.Visible  
                = CurrentDataMain_Saperator.Visible = Name_TextBox.Visible = 
                Phone_TextBox.Visible  // Address_TextBox.Visible = TraineeImage_PictureBox.Visible
                = Update_Button.Visible = NewData_Label.Visible = 
                NewData_Saperator.Visible = visible_value;


        }

        private void ConfirmBarCode_Button_Click(object sender, EventArgs e)
        {
            // take the barcode id in the string with trim 
            string code = Code_TextBox.Text.Trim(to.tcs);
            // check the empty input 
            if (code == "")
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Data InCompelete\nRequired Trainee BarCode ID"
                    , Main_Functions.AlertType.error, 80);
                // call this function to handle the focus and the visibilty 
                HandleCodeTextBox_Events(false, 1);
                // exit the function 
                return;
            }
            // check the validation of the Entered Bar Code IDs
            else if (!(Regex.IsMatch(code, @"^[0-9]+$")))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe BarCode Must Be A Number\nWith out Spaces"
                    , Main_Functions.AlertType.error, 100);
                // call this function to handle the focus and the visibilty 
                HandleCodeTextBox_Events(false, 1);
                // exit the function 
                return;
            }
            // check if the ID Exists in the data base before 
            else if (!to.CheckExistence_BarCode(code))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe BarCode ID is InCorrect"
                    , Main_Functions.AlertType.error, 80);
                // call this function to handle the focus and the visibilty 
                HandleCodeTextBox_Events(false, 1);
                // exit the function 
                return;
            }
            // call this function to handle the visibilty 
            HandleCodeTextBox_Events(true);

            // call this function to get the data on the controllers 
            to.Get_DataControllerss(code, ref Name_Label, ref Phone_Label);

            // make the focus and the select on the Name text box
            Name_TextBox.Focus();
            Name_TextBox.Select();

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////
            // Take Data ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

            string code = Code_TextBox.Text.Trim(to.tcs);
            string phone = Phone_TextBox.Text.Trim(to.tcs);
            string name = Name_TextBox.Text.Trim(to.tcs);
            // string address = Address_TextBox.Text.Trim(to.tcs);

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Empty Data Check ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

            // in case there is some input Error
            if (code == "" || phone == ""  || name == "" || code == "Enter The BarCode ID"
                || name == "Enter The New Name" || phone == "Enter The New Phone Number")
            {
                // call this function to handle the alerts 
                to.Handle_Alerts("Data InComplete\nRequired Name, BarCode ID" +
                    "\nand the Phone, Address is Optional",
                    Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Check the Whole Data ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

            // check if all the entered data are the same as before 
            else if (phone == Phone_Label.Text && name == Name_Label.Text)
            {
                // call this function to handle the alerts 
                to.Handle_Alerts("Wrong Data\nPlease, Enter New Data",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Check the Validation ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

            // check the validation of the name of the trainee 
            else if (!(Regex.IsMatch(name, @"^[a-zA-Z ]+$")))
            {
                // call this function to handle the alerts 
                to.Handle_Alerts("Wrong Input\nThe Name Includes Only\nLetters and Spaces"
                    , Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // check the validation of the entered phone 
            else if (!(Regex.IsMatch(phone, @"^[0-9]+$")) || phone.Length != 11)
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe Phone Must Be 11 Digits Only\nWith Out Spaces"
                    , Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // check the entred phone is not in the data base before
            else if (to.CheckExistence_Phone(phone) && phone != Phone_Label.Text)
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe Phone Exists For Another Trainee"
                    , Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            /*
            // now in case there is entred address check the validation of it 
            else if (address != "" && address != "Enter The New Address"
                && !(Regex.IsMatch(address, "^(?=.*[a-zA-Z])(?=.*[ ])(?=.*[0-9])[A-Za-z0-9 ]+$")))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe Address Must Contain\nNumber Of Block And Name of" +
                    " Street\nWith Spaces Between Them", Main_Functions.AlertType.error, 132);
                // exit the function 
                return;
            }
            */
            //////////////////////////////////////////////////////////////////////////////////////////////
            // Take the Exact Address ///////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // in case the place holder in the address or the address variable is empty 
            if (address == "" || address == "Enter The New Address") // make the address as empty string 
                address = string.Empty;*/

            //////////////////////////////////////////////////////////////////
            // Update Call ///////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////

            // call this function to make the update to the information 
            to.UpdateInformation_Trainee(code, phone, name);

            //////////////////////////////////////////////////////////////////
            // Back to Original ///////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////

            // make the bar code id empty of any text 
            Code_TextBox.Text = string.Empty;

            // call this function to handle the visibilty of the controllers 
            HandleCodeTextBox_Events(false, 1);
        }
    }
}
