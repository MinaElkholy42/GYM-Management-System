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
using System.Text.RegularExpressions;
using Guna.UI2.WinForms;
namespace GYM_Mangment_System
{
    public partial class TraineeInsert_Form : Form
    {
        // make object from the Trainee Options class 
        TraineeOptions_Class to;
        // this variable will hold the real payment the user Entered 
        int real_payment;
        // this string for the location of the image 
        string imglocation;
        public TraineeInsert_Form()
        {
            InitializeComponent();
            // intialize the object from the Trainee Options Class 
            to = new TraineeOptions_Class();
            // intialize the real payment with 0 
            real_payment = 0;
        }



        /// <summary>
        /// ////////////////////////////
        /// 






         // this array holds the number of days in each month 
        public static int[] months_days = new int[]
        {
            31,28,31,30,31,30,31,31,30,31,30,31
        };


        public int get_days(int counter_months)
        {
            // this variable will hold the total number of days 
            // begin with the current number of months 
            int sum_days = 0, counter_array = Date_Time_Picker.Value.Month - 1;
            while (counter_months != 0)
            {
                // add the number of days to the summition 
                sum_days += months_days[counter_array];
                // increament the number of counter of the array (module by 12 for the new year) 
                counter_array = (counter_array + 1) % 12;
                // decreament the number of months 
                counter_months--;
            }
            // return with the excat number of days
            return sum_days;
        }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 






        private void TraineeInsert_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the name text box 
            Name_TextBox.Select();
            Name_TextBox.Focus();
            // make the checked of the normal text box 
            NormalSystem_Button.Checked = true;

            // make date time picker with today value 
            Date_Time_Picker.Value = DateTime.Now.AddDays(0);
        }

        // this function is to handle the alerts of the discount text box 
        public void DiscountTextBox_HandleAlerts(ref Guna2TextBox Discount_TextBox,
            string message, Main_Functions.AlertType alert, int hieght)
        {
            // clear the discount text box 
            Discount_TextBox.Text = string.Empty;
            // make the select and the focus on the discount text box 
            Discount_TextBox.Focus();
            Discount_TextBox.Select();
            // make the alert 
            Alert_Form af = new Alert_Form(message, alert, hieght);
            // make the alert  as the top most on all other forms
            af.TopMost = true;
            // show the alert 
            af.Show();
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Insert_Button_Click(sender, e);
        }

        private void Code_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // when the enter button is pressed 
            if (e.KeyValue == (char)Keys.Enter)
            {
                // make the select and the focus on the next text box 
                Address_TextBox.Focus();
                Address_TextBox.Select();
            }
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
            // in case there is no place holder in the Text Box
            if (Code_TextBox.Text != "Enter The BarCode ID")
            {
                // remove the password char in the text box using the null character 
                Code_TextBox.PasswordChar = '\0';
                // change the font color to seagreen 
                Code_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowCode_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // in case there is no place holder in the Text Box
            if (Code_TextBox.Text != "Enter The BarCode ID")
            {
                // put the password char back in the text box 
                Code_TextBox.PasswordChar = '*';
                // change the font color to white color 
                Code_TextBox.ForeColor = Color.White;
            }
        }

        private void Fitness_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // put the place holder in the months text box 
            // Months_TextBox.Text = "Months Amount";
            // clear the discount text box 
            Discount_TextBox.Text = string.Empty;
            // clear the payment text box 
            Payment_TextBox.Text = string.Empty;
        }

        // this function to handle the change events of the radio buttons systems 
        public void Handle_Systems(bool check_box)
        {
            //// make the check box label with the sent value 
            //CheckBox_Label.Visible = check_box;
            //// make the check box with the sent value  
            //Fitness_CheckBox.Enabled = check_box;
            //// make the Check box UnChecked 
            //Fitness_CheckBox.Checked = false;
            //// put the place holder again in the months text box 
            //Months_TextBox.Text = "Months Amount";
            // clear the text in the discount text box 
            Discount_TextBox.Text = string.Empty;
            // clear the payment text box 
            Payment_TextBox.Text = string.Empty;
        }

        private void NormalSystem_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the normal button is checked 
            if (NormalSystem_Button.Checked)
            {
                // call this function to handle the events 
                Handle_Systems(true);
                Payment_TextBox.Text = "200";
            }
        }

        private void SuperSystem_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the Super button is checked 
            if (SuperSystem_Button.Checked)
            {
                // call this function to handle the events 
                Handle_Systems(false);
                Payment_TextBox.Text = "500";
            }
        }

        private void UltimateSystem_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the Ultimate button is checked 
            if (UltimateSystem_Button.Checked)
            {
                // call this function to handle the events 
                Handle_Systems(false);
                Payment_TextBox.Text = "900";
            }
        }



        private void Year_CheckButton_CheckedChanged(object sender, EventArgs e)
        {
            // in case the Ultimate button is checked 
            if (Year_CheckButton.Checked)
            {
                // call this function to handle the events 
                Handle_Systems(false);
                Payment_TextBox.Text = "1600";
            }
        }

        private void Name_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Name_TextBox.Text == "Enter The Name")
                // remove the place holder 
                Name_TextBox.Text = string.Empty;
        }

        private void Name_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Name_TextBox.Text.Trim(to.tcs) == string.Empty)
                // put the place holder 
                Name_TextBox.Text = "Enter The Name";
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

        private void Phone_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Phone_TextBox.Text == "Enter The Phone Number")
                // remove the place holder 
                Phone_TextBox.Text = string.Empty;
        }

        private void Phone_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Phone_TextBox.Text.Trim(to.tcs) == string.Empty)
                // put the place holder 
                Phone_TextBox.Text = "Enter The Phone Number";
        }

        private void Address_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Address_TextBox.Text == "Enter The Address")
                // remove the place holder 
                Address_TextBox.Text = string.Empty;
        }

        private void Address_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Address_TextBox.Text.Trim(to.tcs) == string.Empty)
                // put the place holder 
                Address_TextBox.Text = "Enter The Address";
        }

        //private void Months_TextBox_Enter(object sender, EventArgs e)
        //{
        //    // in case the place holder inside the text box 
        //    if (Months_TextBox.Text == "Months Amount")
        //        // remove the place holder 
        //        Months_TextBox.Text = string.Empty;
        //}

        //private void Months_TextBox_Leave(object sender, EventArgs e)
        //{
        //    // in case the text box is empty 
        //    if (Months_TextBox.Text.Trim(to.tcs) == "")
        //    {
        //        // clear the payment and the discount text boxes 
        //        Payment_TextBox.Text = Discount_TextBox.Text = string.Empty;
        //        // put the place holder back 
        //        Months_TextBox.Text = "Months Amount";
        //    }

        //    // in the other cases 
        //    else
        //    {
        //        // take the text in the text box with out any additional spaces using the trim
        //        string months_text = Months_TextBox.Text.Trim(to.tcs);
        //        // check if the entered in the text box is not a number 
        //        if (!(Regex.IsMatch(months_text, @"^[0-9]+$")))
        //        {
        //            // make the alert 
        //            Alert_Form af = new Alert_Form("Wrong Input\nMonths Amount Must be A Number",
        //                Main_Functions.AlertType.error, 80);
        //            // make the alert  as the top most on all other forms
        //            af.TopMost = true;
        //            // show the alert 
        //            af.Show();

        //            // clear the payment , months and the discount text boxes 
        //            Months_TextBox.Text = Payment_TextBox.Text = Discount_TextBox.Text = string.Empty;
        //            // make the focus and the select on the months text box 
        //            Months_TextBox.Focus();
        //            Months_TextBox.Select();

        //            //exit the function 
        //            return;
        //        }

        //        // in case the checked button is the Normal System Button 
        //        else if (NormalSystem_Button.Checked)
        //            // we call this function to handle the payment 
        //            to.Check_NormalSystem(Convert.ToInt32(months_text), ref Months_TextBox
        //                , ref real_payment, ref Payment_TextBox, ref Discount_TextBox,
        //                Fitness_CheckBox.Checked);

        //        // in case the checked button is the Super System Button 
        //        else if (SuperSystem_Button.Checked)
        //            to.Check_SuperSystem_UltimateSystem(Convert.ToInt32(months_text), ref Months_TextBox
        //                , ref real_payment, ref Payment_TextBox, ref Discount_TextBox, 1);

        //        // in case the checked button is the Ultimate System Button
        //        else if (UltimateSystem_Button.Checked)
        //            to.Check_SuperSystem_UltimateSystem(Convert.ToInt32(months_text), ref Months_TextBox
        //                , ref real_payment, ref Payment_TextBox, ref Discount_TextBox, 2);
        //    }
        //}

        private void Discount_TextBox_Leave(object sender, EventArgs e)
        {
            int real_payment = 0;
            if (NormalSystem_Button.Checked) real_payment = 200;
            else if (SuperSystem_Button.Checked) real_payment = 500;
            else if (UltimateSystem_Button.Checked) real_payment = 900;
            else if (Year_CheckButton.Checked) real_payment = 1600;

            // Check if the trimmed string in the text box is valid number 
            if (!(Regex.IsMatch(Discount_TextBox.Text.Trim(to.tcs), @"^[0-9]+$"))
                 && Discount_TextBox.Text.Trim(to.tcs) != "")
            {
                // call this function to handle the alert 
                DiscountTextBox_HandleAlerts(ref Discount_TextBox,
                    "Wrong Input\nThe Discount Must be A Number", Main_Functions.AlertType.error, 80);
                // assign the real value of the payment in the text box
                Payment_TextBox.Text = real_payment.ToString();
                //exit the function 
                return;
            }

            // in the other cases (the pyament is in the text box and the discount is in the text box)
            else if (Discount_TextBox.Text.Trim(to.tcs) != "")
            {
                // get the amount of the discount 
                int discount = Convert.ToInt32(Discount_TextBox.Text.Trim(to.tcs));
               

                // check if the amount of the discount is zero 
                if (discount == 0)
                {
                    // call this function to handle the alert 
                    DiscountTextBox_HandleAlerts(ref Discount_TextBox,
                        "Wrong Input\nThe Discount Can Not Be Zero",
                        Main_Functions.AlertType.error, 80);
                    // assign the real value of the payment in the text box
                    Payment_TextBox.Text = real_payment.ToString();
                    // exit the function 
                    return;
                }
                // check if the amount of the discount is bigger than the payment or not  
                else if (discount > real_payment)
                {

                    // call this function to handle the alert 
                    DiscountTextBox_HandleAlerts(ref Discount_TextBox,
                        "Wrong Input\nThe Discount Must be Less Than\nor Equals to the payment",
                        Main_Functions.AlertType.error, 100);
                    // assign the real value of the payment in the text box
                    Payment_TextBox.Text = real_payment.ToString();
                    //exit the function 
                    return;
                }
                // now this means tha amount of discount is valid so 
                // put the payment in the payment text box after the discount 
                Payment_TextBox.Text = (real_payment - discount).ToString();
            }
            
            /*
            // in case we the months text box is empty with the discount text box 
            else if (Discount_TextBox.Text.Trim(to.tcs) == "" && 
                Months_TextBox.Text.Trim(to.tcs) == "Months Amount")
                // clear the payment text box 
                Payment_TextBox.Text = string.Empty;*/

            // in case the months text box is not empty and the discount text box is empyt
            else if (Discount_TextBox.Text.Trim(to.tcs) == "")
                // put the payment in the payment text box
                Payment_TextBox.Text = real_payment.ToString();
        }

        private void ManagerName_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (ManagerName_TextBox.Text == "Enter The Manager Name")
                // remove the place holder 
                ManagerName_TextBox.Text = string.Empty;
        }

        private void ManagerName_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (ManagerName_TextBox.Text.Trim(to.tcs) == "")
                // put the place holder in the text box 
                ManagerName_TextBox.Text = "Enter The Manager Name";
        }

        private void ChooseImage_Button_Click(object sender, EventArgs e)
        {
            // try this to avoid the errors
            try
            {
                // open the dialog of the browsing 
                OpenFileDialog filedialog = new OpenFileDialog();
                // add the types of the files the dialog will contains 
                // only -> (jpg, png, gif, all files) 
                filedialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.PNG)|*.PNG|GIF Files " +
                    "(*.gif)|*.gif" + "|All Files (*.*)|*.*";
                // make a title to the file dialog 
                filedialog.Title = "Select The Trainee Image";

                // check if every thing is OK 
                if (filedialog.ShowDialog() == DialogResult.OK)
                {
                    // get the image location from the dialog 
                    imglocation = filedialog.FileName.ToString();
                    // declare the location of the image in the picture box 
                    TraineeImage_PictureBox.ImageLocation = imglocation;
                }
            }

            // Catch if there is some error in getting the imgage of the trainee
            catch (Exception error_of_try)
            {
                // show the error to the user
                MessageBox.Show(error_of_try.ToString(), "Image Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////
            // Take the Entred Data ////////////////////////////////////////////////////////////// 
            //////////////////////////////////////////////////////////////////////////////////////////////////

            // take the personal data
            string name = Name_TextBox.Text.Trim(to.tcs);
            string id_code = Code_TextBox.Text.Trim(to.tcs);
            string phone = Phone_TextBox.Text.Trim(to.tcs);
            // string address = Address_TextBox.Text.Trim(to.tcs);

            // take the Payment data
            // string months = Months_TextBox.Text.Trim(to.tcs);
            string discount = Discount_TextBox.Text.Trim(to.tcs);
            string payment = Payment_TextBox.Text.Trim(to.tcs);

            // take the managers name
            string manager_name = ManagerName_TextBox.Text.Trim(to.tcs);

            // declare the hexdecimal array of the image 
            // byte[] img = null;

            //////////////////////////////////////////////////////////////////////////////////////////////
            // Check for the Empty Input ////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            // check for the entred data if there is any null of them 
            if (name == "" || id_code == "" || phone == ""
                || manager_name == "" || payment == "" || name == "Enter The Name" || 
                id_code == "Enter The BarCode ID" || phone == "Enter The Phone Number"
                 || manager_name == "Enter The Manager Name")
            {
                // call this function to handle the alerts 
                to.Handle_Alerts("Data Incomplete\nPlease Fill the Required Data"
                    , Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            /*
            // take the Trainee Image from the Picture Box 
            // make it in the try section as the image can be not be inserted 
            // (part of the take the data and the empty entered data)
            try
            { 
                // make the file stream that will read the image from the image location 
                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                // make binary reader to read the image 
                BinaryReader br = new BinaryReader(fs);
                // get the bytes of the image that will be inserted in the data base 
                img = br.ReadBytes((int)fs.Length);
                // close the file stream 
                fs.Close();
            }

            // if the image is not inserted (part of the take the data and the empty entered data)
            catch
            {
                // call this function to handle the alerts 
                to.Handle_Alerts("Data Incomplete\nPlease Add Trainee Image"
                    , Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            */
            //////////////////////////////////////////////////////////////////////////////////////////////////
            // Check the Validation Of Data /////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////

            // check the validation of the name of the trainee 
            if (!(Regex.IsMatch(name, @"^[a-zA-Z ]+$")))
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
            else if (to.CheckExistence_Phone(phone))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe Phone Exists For Another Trainee"
                    , Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            // check the validation of the Entered Bar Code IDs
            else if (!(Regex.IsMatch(id_code, @"^[0-9]+$")))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe BarCode Must Be A Number\nWith out Spaces"
                    , Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // check if the ID Exists in the data base before 
            else if (to.CheckExistence_BarCode(id_code))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe BarCode Belongs to\nAnother Trainee"
                    , Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            /*
            // now in case there is entred address check the validation of it 
            else if (address != "" && address != "Enter The Address"
                && !(Regex.IsMatch(address, "^(?=.*[a-zA-Z])(?=.*[ ])(?=.*[0-9])[A-Za-z0-9 ]+$")))
            {
                // call this function to handle the alert 
                to.Handle_Alerts("Wrong Input\nThe Address Must Contain\nNumber Of Block And Name of" +
                    " Street\nWith Spaces Between Them", Main_Functions.AlertType.error, 132);
                // exit the function 
                return;
            }*/ 

            // now check the validation of the manager name entered in the text box 
            else if (!(Regex.IsMatch(manager_name, @"^[a-zA-Z ]+$")))
            {
                // call this function to handle the alerts 
                to.Handle_Alerts("Wrong Input\nThe Manager Name Includes Only\nLetters and Spaces"
                    , Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            // Take GYM Data ////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////

            // make the GYM string as yes 
            string gym = "yes";
            // make the fitnees string 
            string fittness = "yes";

            //////////////////////////////////////////////////////////////////////////////////////////////
            // Take the Date and Time Member Ship Data ///////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            int months = 0;
            if (NormalSystem_Button.Checked) months = 1; 
            else if (SuperSystem_Button.Checked) months = 3;
            else if (UltimateSystem_Button.Checked) months = 6; 
            else if (Year_CheckButton.Checked) months = 12; 

                    // get the current date (now date) of the payment
                    string current_date = Date_Time_Picker.Value.ToString("yyyy-MM-dd");
            // get the time of the payment  
            string time = Date_Time_Picker.Value.ToString("hh:mm tt");
            // get the next date of the payment (renewal) (date to pay)
            // add the number of days according to the number of months to the current date
            // using this function to get the exact number of days 
            string payment_date = (Date_Time_Picker.Value.AddDays(
                get_days(Convert.ToInt32(months)))).ToString("yyyy-MM-dd");

            //////////////////////////////////////////////////////////////////////////////////////////////
            // Take the Exact Address ///////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // in case the place holder in the address or the address variable is empty 
            if (address == "" || address == "Enter The Address") // make the address as empty string 
                address = string.Empty;*/

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Take the Exact Payment Data ///////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

            // get the amount of months 
            // int months_amount = Convert.ToInt32(months);
            // get the payment of the trainee 
            int payment_amount = Convert.ToInt32(payment);
            // this variable will hold the discount 
            int discount_amount = 0;
            // in case the discount text box is empty 
            if (discount == "") discount_amount = 0; // the value of the discount is zero 
            else  // this means the value of the discount is in the text box 
                discount_amount = Convert.ToInt32(discount);

            ////////////////////////////////////////////////////////////////////////////////////////////
            // Save The Trainee Data ///////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////

            // call this function to insert the trainee in the data base 
            to.TraineeData_Insert(id_code, name, payment_amount, gym, fittness
                , time, current_date, payment_date, phone
                , discount_amount, manager_name);


            ////////////////////////////////////////////////////////////////////////////////////////////
            // Insert Revenues ///////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////

            // make object from the budget Options class 
            BudgetOptions_Class bo = new BudgetOptions_Class();
            // call this function to insert the amount of the revenues 
            bo.Add_Revenues(Date_Time_Picker.Value.Month, Date_Time_Picker.Value.Year, payment_amount);


            ////////////////////////////////////////////////////////////////////////////////////////////
            // Back To Original ///////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////

            // first select and focus on the name text box after clearing it 
            Name_TextBox.Text = string.Empty;
            Name_TextBox.Focus();
            Name_TextBox.Select();
            // put the place holders in the other text boxes 
            Phone_TextBox.Text = "Enter The Phone Number";
            // Address_TextBox.Text = "Enter The Address";
            ManagerName_TextBox.Text = "Enter The Manager Name";
            // put the place holder in the code text box after removing the null character 
            Code_TextBox.PasswordChar = '\0';
            Code_TextBox.Text = "Enter The BarCode ID";
            // clear the image in the picture box 
            // TraineeImage_PictureBox.Image = null;
            // TraineeImage_PictureBox.ImageLocation = null;
            // imglocation = null; // make the path to the image is null (no path)
            // make the normal button system checked 
            NormalSystem_Button.Checked = true;

            // make date time picker with today value 
            Date_Time_Picker.Value = DateTime.Now.AddDays(0);
        }
    }
}
