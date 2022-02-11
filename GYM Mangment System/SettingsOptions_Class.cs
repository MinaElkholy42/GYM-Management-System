using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
namespace GYM_Mangment_System
{
    class SettingsOptions_Class : Main_Functions // make the class inherit from the main functions class
    {
        // Word Change Section /////////////////////////////////////

        // this function to check the old word if it is the same as the entered 
        public bool Check_OldWord(string old_word)
        {
            // make this flag to indicate if the entred word is the same word or not 
            bool same_word = false;
            // check if the word in the main functions class is the same as the entered one 
            if (get_word() == old_word) same_word = true; // turn the flag on
            // return with the flag value
            return same_word;
        }

        // this function to check the format of the new entered word of reports 
        public bool Check_NewWord(string new_word)
        {
            // make this flag to indicate if the entred word is in the rigth format
            bool format_word = true;
            // check if the word follow the format of the reports word
            if (!Regex.IsMatch(new_word,
                @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-._]).{8,}$") 
                || new_word.Contains(" "))
                format_word = false; // turn the flag off as the word does not follow the format
            // return with the flag value
            return format_word;
        }

        // UserName Change Section /////////////////////////////////////

        // this function to make sure that the entered old User Name is the right one 
        public bool Check_OldUserName(string old_username)
        {
            // make this flag to indicate if the entred Usert Name is the same one or not 
            bool same_username = false;
            // check if the user name in the main functions class is the same as the entered one 
            if (get_current_username() == old_username) same_username = true; // turn the flag on
            // return with the flag value
            return same_username;
        }

        // this function to validate the entered user name (new one) follow the right format 
        public bool Check_NewUserName(string new_username)
        {
            // make this flag to indicate if the entred Username is in the right format
            bool format_username = true;
            // check if the New username follow the format
            if (!(Regex.IsMatch(new_username, @"^[a-zA-Z]+[a-zA-Z0-9_]+$")))
                format_username = false; //turn the flag off that the user name does not follow the fromat
            // return with the flag value
            return format_username;
        }

        // this function to check if the new entered user name exists in the data base 
        public bool Check_Existance_NewUserName(string new_username)
        {
            // make this flag to indicate if the entered user name exists for another account or not
            bool username_exists = false;
            // open the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("select user_N from Managers where user_N = @user", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@user", new_username);
            // make the sql data reader and excute it 
            SqlDataReader dr = cmd.ExecuteReader();
            // check if there is any rows in the data reader 
            if (dr.HasRows) username_exists = true; // in this case turn the flag on 
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            // return with the flag 
            return username_exists;
        }

        // this function for the update of the user name in the data base 
        public void Update_NewUserName(string old_username, string new_username)
        {
            // open the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand(@"update Managers set user_N = @new
                                               where user_N = @old", con);
            // add the query parameters 
            cmd.Parameters.AddWithValue("@new", new_username);
            cmd.Parameters.AddWithValue("@old", old_username);
            // Excute the non query 
            int id_operation = cmd.ExecuteNonQuery(); 
            // in case the id_operation = 1 (the update has done in the data base)
            if (id_operation == 1)
            {
                // make object from the alret form 
                Alert_Form alert = new Alert_Form("Operation Succeeded\nThe New User Name has been Set"
                    , Main_Functions.AlertType.success, 80);
                // make the alert on the top most of all other forms 
                alert.TopMost = true;
                // show the alert 
                alert.Show();
            }
            // close the connection 
            con.Close();
        }

        // Password Change Section /////////////////////////////////////

        // this function to check if the entered old password is the same as the right one 
        public bool Check_OldPassword(string old_pass)
        {
            // this flag to indicate if the password is right or wrong 
            bool same_pass = false;
            // check if the entered password is the same old password 
            if (old_pass == get_current_password()) same_pass = true;  // turn the flag on
            // return with the flag 
            return same_pass;
        }

        // this function to check the fromat of the new entred password 
        public bool Check_NewPassword(string new_pass)
        {
            // this flag to indicate if the new password is in the right format or not 
            bool password_format = true;
            // check if the new password follow the correct format or not 
            if (!Regex.IsMatch(new_pass, 
                @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-._]).{8,}$")
                || new_pass.Contains(" "))
                // turn the flag off (not the right format) 
                password_format = false;
            // return with the flag 
            return password_format;
        }

        // this function to check if the new entered password is entered or not 
        public bool Check_Existance_NewPassword(string new_pass)
        {
            // this flag to indicate if the password is in the data base or not 
            bool pass_exsits = false;
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("select Pass from Managers where Pass = @pass", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@pass", new_pass);
            // excute the sql data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) pass_exsits = true;
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            // return with the flag 
            return pass_exsits;
        }

        // this function to update the new password of the current account 
        public void Update_NewPassword(string old_pass, string new_pass)
        {
            // make the sql connection 
            SqlConnection con = get_connection();
            // make the sql command with the new query and the connection 
            SqlCommand cmd = new SqlCommand("update Managers set Pass = @new_pass where Pass = @old_pass",
                con);
            // add the parameters to the command 
            cmd.Parameters.AddWithValue("@new_pass", new_pass);
            cmd.Parameters.AddWithValue("@old_pass", old_pass);
            // excute the command 
            int id_operation = cmd.ExecuteNonQuery(); 
            // in case the id_operation is one (the operation is succeeded) 
            if (id_operation == 1)
            {
                // make object from the alret form 
                Alert_Form alert = new Alert_Form("Operation Succeeded\nThe New Password has been Set"
                    , Main_Functions.AlertType.success, 80);
                // make the alert on the top most of all other forms 
                alert.TopMost = true;
                // show the alert 
                alert.Show();
            }
            // close the connection 
            con.Close();
        }
    }
}
