using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
namespace GYM_Mangment_System
{
    public partial class SearchIDCard_Form : Form
    {
        // make object form the Search Trainees Class 
        SearchTrainees_Class stc;
        public SearchIDCard_Form()
        {
            InitializeComponent();
            // make the initialization of this object to new reference 
            stc = new SearchTrainees_Class();
        }

        // this function to assign the data on the form and to show the controls 
        public void assign_data(SqlDataReader dr)
        {
            // assign the Personal Information Data 
            Name_Label.Text = dr[1].ToString();
            Code_Label.Text = dr[0].ToString();
            Phone_Label.Text = dr[8].ToString();
    
            /*
            // check the address if the user Entre it or not 
            if (dr[9].ToString() == "")
                // make the address as _____________ no data
                Address_Label.Text = "____________________";
            else // assign the address to the label 
                Address_Label.Text = dr[9].ToString();*/

            // assign the GYM Informatoin Data 
            Payment_Label.Text = dr[2].ToString();
            Discount_Label.Text = dr[9].ToString();
            Manager_Label.Text = dr[10].ToString();

            // check the yes or no to assign images for both gym and fittness data 
            // check the gym status
            if (dr[3].ToString() == "yes") // assign the right image
                GYM_PictureBox.Image = Properties.Resources.Right_2; 
            else // assign the wrong image 
                GYM_PictureBox.Image = Properties.Resources.Close_7;

            // check the Fitness status
            if (dr[4].ToString() == "yes") // assign the right image
                Fitneess_PictureBox.Image = Properties.Resources.Right_2;
            else // assign the wrong image 
                Fitneess_PictureBox.Image = Properties.Resources.Close_7;

            // assign the Membership Data 
            PaymentTime_Label.Text = dr[5].ToString();
            PaymentDate_Label.Text = dr[6].ToString();
            FinishedDate_Label.Text = dr[7].ToString();

            /*
            // now get the image from the data base and assign it to the picturebox 
            Trainee_PictureBox.Image = null;
            // take the image 
            byte[] img = (byte[])dr[10];
            // make the memory stream for the image 
            MemoryStream ms = new MemoryStream(img);
            // get the image in the image format from the stream of bytes in the trainee picture box
            Trainee_PictureBox.Image = Image.FromStream(ms);
            // close the memory stream to use again later 
            ms.Close();*/

            // call this function to change the fore color according to the finished date of the user 
            Change_ForeColor(dr);
            // make the infromation appears using this function 
            Show_Controls();
        }

        // this function to change the fore color of the user according to the finished date of the 
        // membership
        public void Change_ForeColor(SqlDataReader dr)
        {
            // if the date to pay is more than the current date change the back ground  
            if (DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) > DateTime.Parse(dr[7].ToString()))
                // change the fore color of the labels to the red color 
                Name_Label.ForeColor = Phone_Label.ForeColor = Address_Label.ForeColor =
                    Code_Label.ForeColor = Manager_Label.ForeColor = Payment_Label.ForeColor =
                    Discount_Label.ForeColor = PaymentTime_Label.ForeColor = PaymentDate_Label.ForeColor =
                    FinishedDate_Label.ForeColor = Color.Red;

            // that means the member ship still in progress
            else // change the fore color of the lables to the lime green color
                Name_Label.ForeColor = Phone_Label.ForeColor = Address_Label.ForeColor =
                    Code_Label.ForeColor = Manager_Label.ForeColor = Payment_Label.ForeColor =
                    Discount_Label.ForeColor = PaymentTime_Label.ForeColor = PaymentDate_Label.ForeColor =
                    FinishedDate_Label.ForeColor = Color.Lime;

        }

        // this function to make all the information of the trainee appears 
        public void Show_Controls()
        {
            // make the visible of the main saperator
            Main_Saperator.Visible = true;
            // make the visible appears of the personal information section 
            PersonalInformation_Label.Visible = PesronalInofrmation_Saperator.Visible =
                NameHeader_Label.Visible = PhoneHeader_Label.Visible = //AddressHeader_Label.Visible =
                CodeHeader_Label.Visible = // Trainee_PictureBox.Visible = 
                Name_Label.Visible = Phone_Label.Visible = // Address_Label.Visible = 
                Code_Label.Visible = GYM_Saperator.Visible = true;

            // make the visible appears of the GYM Information Section 
            GYMInformation_Label.Visible = GYMInformation_Saperator.Visible = GYM_Saperator.Visible = 
                PaymentHeader_Label.Visible = DiscountHeader_Label.Visible = GYMHeader_Label.Visible =
                FittnessHeader_Label.Visible = Payment_Label.Visible = Discount_Label.Visible =
                GYM_PictureBox.Visible = Fitneess_PictureBox.Visible 
                = ManagerHeader_Label.Visible = Manager_Label.Visible =  true;

            // make the visible appears of the Membership Section 
            MemberShip_Saperator.Visible = MembershipInformation_Saperator.Visible = 
                MemberShipInformation_Label.Visible = PaymentTimeHeader_Label.Visible 
                = PaymentDateHeader_Label.Visible = FinishedDateHeader_Label.Visible 
                = PaymentDate_Label.Visible = PaymentTime_Label.Visible = FinishedDate_Label.Visible = true;
        }

        // this function to make all the information of the trainee appears 
        public void Hide_Controls()
        {
            // make the visible of the main saperator
            Main_Saperator.Visible = false;
            // make the visible Disappears of the personal information section 
            PersonalInformation_Label.Visible = PesronalInofrmation_Saperator.Visible =
                NameHeader_Label.Visible = PhoneHeader_Label.Visible = AddressHeader_Label.Visible =
                CodeHeader_Label.Visible = Trainee_PictureBox.Visible =
                Name_Label.Visible = Phone_Label.Visible = Address_Label.Visible =
                Code_Label.Visible = GYM_Saperator.Visible = false;

            // make the visible Disappears of the GYM Information Section 
            GYMInformation_Label.Visible = GYMInformation_Saperator.Visible = GYM_Saperator.Visible =
                PaymentHeader_Label.Visible = DiscountHeader_Label.Visible = GYMHeader_Label.Visible =
                FittnessHeader_Label.Visible = Payment_Label.Visible = Discount_Label.Visible =
                GYM_PictureBox.Visible = Fitneess_PictureBox.Visible
                = ManagerHeader_Label.Visible = Manager_Label.Visible = false;

            // make the visible Disappears of the Membership Section 
            MemberShip_Saperator.Visible = MembershipInformation_Saperator.Visible =
                MemberShipInformation_Label.Visible = PaymentTimeHeader_Label.Visible
                = PaymentDateHeader_Label.Visible = FinishedDateHeader_Label.Visible
                = PaymentDate_Label.Visible = PaymentTime_Label.Visible = FinishedDate_Label.Visible = false;
        }

        private void SearchIDCard_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form to the animator 
            Form_Animation.SetAnimateWindow(this);
            // once the form is loaded make the focus and select on the code textbox 
            Code_TextBox.Focus();
            Code_TextBox.Select();
        }

        private void ShowPassword_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (Code_TextBox.Text.Trim(stc.tcs) != "Enter The BarCode ID")
            {
                // here we show the entered Code to the user by setting the password char to null
                Code_TextBox.PasswordChar = '\0';
                // make the color of the text box as seagreen 
                Code_TextBox.ForeColor = Color.SeaGreen;
            }
        }

        private void ShowPassword_Button_MouseUp(object sender, MouseEventArgs e)
        {
            // in case the place holder is not in the text box 
            if (Code_TextBox.Text.Trim(stc.tcs) != "Enter The BarCode ID")
            {
                // here we hide the entered Code to the user by setting the password char to *
                Code_TextBox.PasswordChar = '*';
                // make the color of the text box as White 
                Code_TextBox.ForeColor = Color.White;
            }
        }

        private void Code_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the Code with the place holder 
            if (Code_TextBox.Text == "Enter The BarCode ID")
            {
                // clear the text box string 
                Code_TextBox.Text = String.Empty;
                // make the password char as * 
                Code_TextBox.PasswordChar = '*';
            }
        }

        private void Code_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the Code with the place holder 
            if (Code_TextBox.Text.Trim(stc.tcs) == "")
            {
                // clear the text box string 
                Code_TextBox.Text = "Enter The BarCode ID";
                // clear the password char by setting it to the null character 
                Code_TextBox.PasswordChar = '\0';
            }
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Search_Button_Click(sender, e);
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // close the current form only 
            this.Close();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            // make the minimization of the form to the down of the desktop 
            WindowState = FormWindowState.Minimized;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            // take the code in this string with trim to eliminate the additional spaces from both sides
            string code = Code_TextBox.Text.Trim(stc.tcs);
            // check if the Code Text Box Is Entered 
            if (code == "Enter The BarCode ID" || code == "")
            {
                // call this function to hide the controls 
                Hide_Controls();
                // make object form the alert form
                Alert_Form af = new Alert_Form("Data Incomplete\nRequired The BarCode ID",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top of the forms
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }
            // now check if the code entered exists in the data base 
            if (!stc.search_BarCodeID(code))
            {
                // call this function to hide the controls 
                Hide_Controls();
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Data\nPlease Check the Entered BarCode ID",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top of the forms
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }
            // now this means all data are right so we get the data of this customer using this function 
            // make the connection 
            SqlConnection con = stc.get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("select * from Traineers where BarCode_ID = @code", con);
            // add the bind variable 
            cmd.Parameters.AddWithValue("@code", code);
            // get the data using the data reader  
            SqlDataReader dr = cmd.ExecuteReader();
            // read the single row in the data reader 
            dr.Read();
            // assign now the data to the labels and pictureboxes using this function 
            assign_data(dr);
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();

            // back to the original of the text box (select and clear the text) 
            Code_TextBox.Text = String.Empty;
            Code_TextBox.Focus();
            Code_TextBox.Select();
        }
    }
}
