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
using Guna.UI2.WinForms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
namespace GYM_Mangment_System
{
    public partial class TraineeRenewal_Form : Form
    {
        // make object from the trainee options class 
        TraineeOptions_Class to;
        // this variable will hold the real payment the user Entered 
        int real_payment;
        // this variable will hold the date of the finish of the Trainee 
        string finish_date;
        // this variable will hold the start date of the trainee 
        string start_date;
        public TraineeRenewal_Form()
        {
            InitializeComponent();
            // initialize the object from the class 
            to = new TraineeOptions_Class();
            // intialize the real payment with 0 
            real_payment = 0;
            // intialize the finish date and the strat date variable 
            finish_date = start_date = "";
        }

        /// ///////////////////////////////////////////////////////////////////////////////
        // Main Functions /////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        
        private void TraineeRenewal_Form_Load(object sender, EventArgs e)
        {
            // make the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the selection and focus on the bar code id text box 
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

        /// ///////////////////////////////////////////////////////////////////////////////
        // Show Code Button /////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

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

        /// ///////////////////////////////////////////////////////////////////////////////
        // Checked Change Functions /////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

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
            //// clear the text in the discount text box 
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

        /// ///////////////////////////////////////////////////////////////////////////////
        // Key Down Functions /////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // in case the enter button is pressed 
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Renewal_Button_Click(sender, e);
        }

        private void Code_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // in case the enter button is pressed 
            if (e.KeyValue == (char)Keys.Enter) // call the button click event 
                ConfirmBarCode_Button_Click(sender, e);
        }

        /// ///////////////////////////////////////////////////////////////////////////////
        // Enter And Leave Text Boxes /////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

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

        /// ///////////////////////////////////////////////////////////////////////////////
        // Buttons Click /////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        // this function to handle the visibilty 
        public void HandleCodeTextBox_Events(bool visible_value, int id = 0)
        {
            // make the check on the normal system button 
            NormalSystem_Button.Checked = true;
            // put the place holder in the managers text box 
            ManagerName_TextBox.Text = "Enter The Manager Name";
            // clear the image in the trainee picture box 
            // TraineeImage_PictureBox.Image = null;
            // TraineeImage_PictureBox.ImageLocation = null;

            // make the focus and the select on the ID_TextBox if id is 1 
            if (id == 1)
            {
                // make the focus and the select on the id text box 
                Code_TextBox.Focus();
                Code_TextBox.Select();
                
            }
            // assign the visible value to the rest of the controls in the tool 
            Main_Saperator.Visible = PersonalInformation_Label.Visible =
                PesronalInofrmation_Saperator.Visible = GYMInformation_Label.Visible =
                GYMInformation_Saperator.Visible = Name_Label.Visible =
                Phone_Label.Visible = Discount_Label.Visible = Payment_Label.Visible =
                NormalSystem_Button.Visible = SuperSystem_Button.Visible = UltimateSystem_Button.Visible =
                Discount_TextBox.Visible = Payment_TextBox.Visible =
                ManagerName_TextBox.Visible = // CheckBox_Label.Visible =
                Renewal_Button.Visible = Year_CheckButton.Visible = visible_value;
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
            to.Get_DataControllers(code, ref Name_Label, ref Phone_Label);

            // make the focus and the select on the months text box
            Discount_TextBox.Focus();
            Discount_TextBox.Select();

            // take the payment finish date of the traineee using the id using this function 
            to.Get_FinishDate(code, ref finish_date, ref start_date);

        }

        private void Renewal_Button_Click(object sender, EventArgs e)
        {
            /// ///////////////////////////////////////////////////////////////////////////////
            // Take The Data /////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////

            string code = Code_TextBox.Text.Trim(to.tcs); // take the Trainee BarCode ID 
            // take the Payment data
            // string months = Months_TextBox.Text.Trim(to.tcs);
            string discount = Discount_TextBox.Text.Trim(to.tcs);
            string payment = Payment_TextBox.Text.Trim(to.tcs);

            // take the managers name
            string manager_name = ManagerName_TextBox.Text.Trim(to.tcs);

            /// ///////////////////////////////////////////////////////////////////////////////
            // Empty Data /////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////

            // check if all inputs are satisfied 
            if (code == "" || manager_name == "" || payment == "" 
                || code == "Enter The BarCode ID"  || 
                manager_name == "Enter The Manager Name")
            {
                // call this function to handle the alerts 
                to.Handle_Alerts("Data Incomplete\nPlease Fill the Required Data", 
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            /// ///////////////////////////////////////////////////////////////////////////////
            // Check The Validation of the Data /////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////
            
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

            /*
            // in case the ultimate system or the normal system with the fitness check box is checked 
            if (UltimateSystem_Button.Checked || (NormalSystem_Button.Checked &&
                Fitness_CheckBox.Checked))
                // make the fitnees string with yes 
                fittness = "yes";*/ 

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Take the Exact Payment Data ///////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

            // get the amount of months 
            int months_amount = 0;

            if (NormalSystem_Button.Checked) months_amount = 1;
            else if (SuperSystem_Button.Checked) months_amount = 3;
            else if (UltimateSystem_Button.Checked) months_amount = 6;
            else if (Year_CheckButton.Checked) months_amount = 12;

            // get the payment of the trainee 
            int payment_amount = Convert.ToInt32(payment);
            // this variable will hold the discount 
            int discount_amount = 0;
            // in case the discount text box is empty 
            if (discount == "") discount_amount = 0; // the value of the discount is zero 
            else  // this means the value of the discount is in the text box 
                discount_amount = Convert.ToInt32(discount);

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Get The Date Data ///////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////
            
            // get the time of the payment  
            string time = DateTime.Now.ToString("hh:mm tt");

            // This will indicate the operaition will done to the payment and the discount  
            string operaiton_discount = "@dis";
            string operaiton_payment = "@pay";
            // we have two cases 

            // if the date of membership finish is older than the current date or equal (date of today)
            if (DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) <= DateTime.Parse(finish_date))
            {
                // the start date will be the same 
                // the finish date will be the old finish date with the addition of the months 
                finish_date = (DateTime.Parse(finish_date).AddDays(to.get_days(months_amount)))
                    .ToString("yyyy-MM-dd");
                // change the string of the operations to the payment and the discount
                operaiton_discount = "Discount + @dis";
                operaiton_payment = "Payment + @pay";
            }

            // if the date of the finish of the member ship is less than the current date
            else if (DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) > DateTime.Parse(finish_date))
            {
                // get the new start date 
                start_date = DateTime.Now.ToString("yyyy-MM-dd");
                // get the new finish date 
                finish_date = (DateTime.Now.AddDays(to.get_days(months_amount)))
                    .ToString("yyyy-MM-dd");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////
            // Renewal Function and Revenues ///////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

            // now call this function to make the renewal 
            to.MemberShipTrainee_Renewal(code, time, start_date, finish_date, operaiton_payment,
                operaiton_discount, payment_amount, discount_amount, manager_name, gym, fittness);

            ////////////////////////////////////////////////////////////////////////////////////////////
            // Insert Revenues ///////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////

            // make object from the budget Options class 
            BudgetOptions_Class bo = new BudgetOptions_Class();
            // call this function to insert the amount of the revenues 
            bo.Add_Revenues(DateTime.Now.Month, DateTime.Now.Year, payment_amount);

            ////////////////////////////////////////////////////////////////////////////////////////////
            // Back To Original ///////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////

            // clear the text in the labels and the some of the text boxes 
            Payment_TextBox.Text = Discount_TextBox.Text = Phone_Label.Text = Name_Label.Text =
               Code_TextBox.Text = string.Empty;
            // put the place holders in the manager Name text box 
            ManagerName_TextBox.Text = "Enter The Manager Name";
            // call this function to handle the rest of the operations
            HandleCodeTextBox_Events(false, 1);
            // make the select and focus on the barcode id text box 
            Code_TextBox.Focus();
            Code_TextBox.Select();
        }
    }
}
