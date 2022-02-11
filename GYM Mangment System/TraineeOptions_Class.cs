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
    class TraineeOptions_Class : Main_Functions // make the inheritance from the main functions class
    {

        //////////////////////////////////////////////////////////////////////////////////////////////
        // Helper Systems Functions //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////

        // this function to check the validation of the months with the system
        public bool Check_Months(int months, int id = 0)
        {
            // this flag to indicate the validation of the months 
            bool months_valid = true;
            // check if the months is 0 
            if (months == 0)
            {
                months_valid = false; // turn the flag off
                // make the alert object form 
                Alert_Form af = new Alert_Form("Wrong Input\nMonths Amount Can Not be Zero", 
                    AlertType.error, 80);
                // make the alert on the top most of all other forms 
                af.TopMost = true;
                // show the alert form 
                af.Show();
            }

            // in case the id is not  0 which means  the super system or ultimate system 
            else if (id != 0)
            {
                // first take the months in temp variable 
                int temp_months = months;
                // loop on the temp months until it reaches zero
                while(temp_months != 0)
                {
                    temp_months -= 3; // decreament the value 
                    // check the validation of the months in case the temp_months is negative 
                    if (temp_months < 0)
                    {
                        months_valid = false; // turn the flag off
                        // make the alert object form 
                        Alert_Form af = new Alert_Form("Wrong Input\nMonths Amount in The Super System\n" +
                            "or in The Ultimate System\nMust Be Multiplication Of 3",
                            AlertType.error, 132);
                        // make the alert on the top most of all other forms 
                        af.TopMost = true;
                        // show the alert form 
                        af.Show(); 
                        // break the loop
                        break;
                    }
                }
            }
            // return with the value of the flag 
            return months_valid;
        }

        // this function to clear the text boxes in case the non valid amount of months 
        public void Clear_TextBoxes(ref Guna2TextBox months_textbox,
            ref Guna2TextBox pay_textbox, ref Guna2TextBox discount_textbox)
        {
            // clear the payment, months and the discount text boxes 
            pay_textbox.Text = discount_textbox.Text = months_textbox.Text = string.Empty;
            // make the focus and the select on the months text box 
            months_textbox.Focus();
            months_textbox.Select();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        // Systems Functions //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////

        // this function to check the validation of the normal system 
        public void Check_NormalSystem(int months, ref Guna2TextBox month_textbox, ref int payment, 
            ref Guna2TextBox pay_textbox, ref Guna2TextBox discount_textbox , bool fitness)
        {
            // intialize the period money with 150 
            int period_money = 150;
            // in case the fitness is checked 
            if (fitness) period_money += 50; // add another 50 

            // check if the number of months is valid according to the system 
            if (!Check_Months(months))
            {
                // call this function to clear the text boxes 
                Clear_TextBoxes(ref month_textbox, ref pay_textbox, ref discount_textbox);
                // exit the function 
                return;
            }
            // calculate the payment amount according to this equation 
            payment = period_money * months;
            // put the payment in the text box of the payment 
            pay_textbox.Text = payment.ToString();
        }

        // this function to check the validation in Super System and Ultimate System
        public void Check_SuperSystem_UltimateSystem(int months, ref Guna2TextBox month_textbox, 
            ref int payment, ref Guna2TextBox pay_textbox, ref Guna2TextBox discount_textbox,
            int id_system)
        {

            // Declare the period on the money
            int period_money;
            // in case the id is 1 
            if (id_system == 1) period_money = 350; // this means Super System
            else period_money = 450; // this means the Ultimate System
            // check the validation of the months in case of the non valid amount of months 
            if (!Check_Months(months, 1))
            {
                // call this function to clear the text boxes 
                Clear_TextBoxes(ref month_textbox, ref pay_textbox, ref discount_textbox);
                // exit the function 
                return;
            }
            // calculate the payment according to the equation and the period of months 
            payment = (months / 3) * period_money;
            // assign the payment in the payment text box 
            pay_textbox.Text = payment.ToString();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Existence Of Data Functions //////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////

        // this function to check the existence of the phone in the data base 
        public bool CheckExistence_Phone(string phone)
        {
            // this flag to check if the phone in the data base or not 
            bool phone_found = false;
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Phone_Number from Traineers where 
                                                   Phone_Number = @phone", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@phone", phone);
            // Excute the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // in case the data reader has rows -> the phone Exists 
            if (dr.HasRows) phone_found = true; // turn the flag on 
            // close the data reader 
            dr.Close();
            // close the sql connection 
            con.Close();
            // return with the flag
            return phone_found;
        }

        // this function to check if the ID Exists for another trainee in the data base 
        public bool CheckExistence_BarCode(string code)
        {
            // this flag to check if the phone in the data base or not 
            bool code_found = false;
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select BarCode_ID from Traineers where 
                                                   BarCode_ID = @code", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@code", code);
            // Excute the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // in case the data reader has rows -> the phone Exists 
            if (dr.HasRows) code_found = true; // turn the flag on 
            // close the data reader 
            dr.Close();
            // close the sql connection 
            con.Close();
            // return with the flag
            return code_found;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        // Date Calculations Function ////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////

        // this function to get the exact number of days to get the member ship renewal date
        public int get_days(int counter_months)
        {
            // this variable will hold the total number of days 
            // begin with the current number of months 
            int sum_days = 0, counter_array = DateTime.Now.Month - 1; 
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

        /////////////////////////////////////////////////////////////////////////////////////////////////
        // Insert Trainee Function  ////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////
        
        // this function to insert the trainee entered data in the data base 
        public void TraineeData_Insert(string id, string name, int payment, string GYM, string fitness,
            string time, string current_data, string date_to_pay, string phone
            , int discount, string manager_name)
        {
            // open the connection 
            SqlConnection con = get_connection();
            // make the sql command with query 
            SqlCommand cmd = new SqlCommand(@"insert into Traineers values(@id, @name, @pay, @G, @fit, 
                                                @time, @currentdate, @datepay, @PP, 
                                                @dis, @manage)", con);
            // add the parameteres 
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pay", payment);
            cmd.Parameters.AddWithValue("@G", GYM);
            cmd.Parameters.AddWithValue("@fit", fitness);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@currentdate", current_data);
            cmd.Parameters.AddWithValue("@datepay", date_to_pay);
            cmd.Parameters.AddWithValue("@PP", phone);

            cmd.Parameters.AddWithValue("@dis", discount);
            cmd.Parameters.AddWithValue("@manage", manager_name);
            // now excute the operation if the return is 1 so it is done successfully 
            int id_operation = cmd.ExecuteNonQuery();
            // close the sql connection 
            con.Close();
            // in case the id is one this means the operation is succeeded 
            if (id_operation == 1)
            {
                // make the alert 
                Alert_Form af = new Alert_Form("Opertion Succeeded\nTrainee is Inserted Successfully", 
                    AlertType.success, 80);
                // make the alert on the top of all other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
            }
            // close the connection 
            con.Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        // Get Trainee Name Functions  ////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////

        // this function to get the name of the trainee by the Bar Code ID
        public void GetTraineeName_BarCode(string id, ref string name)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Name, BarCode_ID from Traineers 
                                              where BarCode_ID = @id", con);
            // add the Command parameters 
            cmd.Parameters.AddWithValue("@id", id);
            // Execute the  command with the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the single row in the data reader 
            dr.Read();
            // assign the name 
            name = dr[0].ToString();
            // close the data reader 
            dr.Close();
            // close the sql connection 
            con.Close();
        }

        // this function to get the name of the trainee by the Phone Number
        public void GetTraineeName_Phone(string phone, ref string name)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Name, Phone_Number from Traineers 
                                              where Phone_Number = @phone", con);
            // add the Command parameters 
            cmd.Parameters.AddWithValue("@phone", phone);
            // Execute the  command with the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the single row in the data reader 
            dr.Read();
            // assign the name 
            name = dr[0].ToString();
            // close the data reader 
            dr.Close();
            // close the sql connection 
            con.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////
        // Delete Functions //////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

        // this function to delete the trainee using the Bar Code ID 
        public void DeleteTrainee_BarCode(string id)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("delete from Traineers where BarCode_ID = @id", con);
            // add the command parameters 
            cmd.Parameters.AddWithValue("@id", id);
            // excute the sql command 
            cmd.ExecuteNonQuery();
            // close the sql connection 
            con.Close();
        }

        // this function to delete the trainee using the Phone Number
        public void DeleteTrainee_Phone(string phone)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("delete from Traineers where Phone_Number = @phone", con);
            // add the command parameters 
            cmd.Parameters.AddWithValue("@phone", phone);
            // excute the sql command 
            cmd.ExecuteNonQuery();
            // close the sql connection 
            con.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////
        // Renewal, Update Helper Functions //////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

        // this function to get the data on the name, phone, image sections 
        public void Get_DataControllers_Helper(ref Guna2HtmlLabel Name_Label
            , ref Guna2HtmlLabel Phone_Label
            , SqlDataReader dr )
        {
            // show the name in the name label 
            Name_Label.Text = dr[0].ToString();
            // show the phone in the phone label 
            Phone_Label.Text = dr[2].ToString();
            // take the image 
            // byte[] img = (byte[])dr[1];
            // make the memory stream for the image 
            // MemoryStream ms = new MemoryStream(img);
            // make the image to null first 
            // TraineeImage_PictureBox.Image = null;
            // get the image in the image format from the stream of bytes in the trainee picture box
            // TraineeImage_PictureBox.Image = Image.FromStream(ms);
            // close the memory stream to use again later 
            // ms.Close();
        }
        
        // this function to get the data according to the id on the controllers 
        public void Get_DataControllers(string code, ref Guna2HtmlLabel Name_Label,
            ref Guna2HtmlLabel Phone_Label)
        {
            // make the connection
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Name, BarCode_ID, Phone_Number 
                                             from Traineers Where BarCode_ID = @id", con);
            // add the parameters to the sql command 
            cmd.Parameters.AddWithValue("@id", code);
            // execute the sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the single row in the data reader 
            dr.Read();
            // call this function to get the controllers data using the data reader 
            Get_DataControllers_Helper(ref Name_Label, ref Phone_Label
                , dr);
            // close the data reader 
            dr.Close();
            // close the conncetion 
            con.Close();
        }

        // this function to get the data according to the id on the controllers 
        public void Get_DataControllerss(string code, ref Guna2HtmlLabel Name_Label,
            ref Guna2HtmlLabel Phone_Label)
        {
            // make the connection
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Name,  BarCode_ID, Phone_Number
                                             from Traineers Where BarCode_ID = @id", con);
            // add the parameters to the sql command 
            cmd.Parameters.AddWithValue("@id", code);
            // execute the sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the single row in the data reader 
            dr.Read();
            // call this function to get the controllers data using the data reader 
            Get_DataControllers_Helper(ref Name_Label, ref Phone_Label
                , dr);
            // assigh the address to the address label 
            // Address_Label.Text = dr[4].ToString();
            // in case there is no address assigned 
            // if (Address_Label.Text == "") Address_Label.Text = "____________________";
            // close the data reader 
            dr.Close();
            // close the conncetion 
            con.Close();
        }

        // this function to get the finish date of the trainee using the id 
        public void Get_FinishDate(string id, ref string finish_date, ref string start_date)
        {
            // open the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"select Date_To_Pay, Date_Of_Pyament, BarCode_ID 
                                              from Traineers Where BarCode_ID = @id", con);
            // add the command parameters 
            cmd.Parameters.AddWithValue("@id", id);
            // execute using the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the first line
            dr.Read();
            // assign the finish date 
            finish_date = dr[0].ToString();
            // assign the start date 
            start_date = dr[1].ToString();
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////
        // Renewal Main Functions //////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        
        // this function to renewe the membership of the trainee 
        public void MemberShipTrainee_Renewal(string id, string time, string start_date, string finish_date
            , string payment_operation, string discount_operation, int payment, int discount
            , string manager_name, string gym, string fitness)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"update Traineers set Time_Of_Payment = @time,
            Date_Of_Pyament = @start, Date_To_Pay = @finish, Manager_Name = @name,
            GYM = @g, Fittness = @fit, Payment = " + payment_operation + ", Discount = " + 
            discount_operation + " where BarCode_ID = @id", con);
            // add the sql parameters of the query 
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@start", start_date);
            cmd.Parameters.AddWithValue("@finish", finish_date);
            cmd.Parameters.AddWithValue("@name", manager_name);
            cmd.Parameters.AddWithValue("@g", gym);
            cmd.Parameters.AddWithValue("@fit", fitness);
            cmd.Parameters.AddWithValue("@pay", payment);
            cmd.Parameters.AddWithValue("@dis", discount);
            cmd.Parameters.AddWithValue("@id", id);
            // execute the query of the sql 
            int id_operation = cmd.ExecuteNonQuery();
            // in case the id_operation is one 
            if (id_operation == 1)
                // call this function to handle the alerts 
                Handle_Alerts("Operation Succeeded\nMemberShip Renewal Has Done", AlertType.success, 80);

            // close the connection 
            con.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////
        // Update Main Functions //////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        
        // this function to update the information of the current trainee 
        public void UpdateInformation_Trainee(string code, string phone, string name)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the command 
            SqlCommand cmd = new SqlCommand(@"update Traineers set Phone_Number = @phone,
                                             Name = @name
                                            where BarCode_ID = @code", con);
            // add the command parameters 
            cmd.Parameters.AddWithValue("@phone", phone);
            // cmd.Parameters.AddWithValue("@addresss", address);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@code", code);
            // execute the query 
            int id_operation = cmd.ExecuteNonQuery();
            if (id_operation == 1)
                // call this function to handle the alerts 
                Handle_Alerts("Operation Succeeded\nThe Update Is Done", AlertType.success, 80);
            // close the connection 
            con.Close();
        }
    }
}
