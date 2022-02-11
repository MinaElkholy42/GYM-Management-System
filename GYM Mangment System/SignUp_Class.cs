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
namespace GYM_Mangment_System
{
    class SignUp_Class: Main_Functions// make the inheritance from the main class for the main functions
    {
        // this function to search if the user name or password are there located in the data base
        public bool search_username_password_identical(string user_name, string pass)
        {
            // get the connection 
            SqlConnection con = get_connection();
            // make the command to select all the rows in the table with the user name or the pass
            SqlCommand cmd = new SqlCommand("select user_N,Pass from Managers where user_N = @username or Pass = @password", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@username", user_name);
            cmd.Parameters.AddWithValue("@password", pass);
            // get the rows in the table by using the reader  
            SqlDataReader datareader = cmd.ExecuteReader();
            // this flag to indicate weather the entred password or the user name are the same in the data base
            bool the_same = true;
            // in case we did not find any rows inside the data reader 
            if (!(datareader.HasRows))
                // this means non of the user name or the password is in the data base so turn the flag off 
                the_same = false;
            // close the reader 
            datareader.Close();
            // close the connection 
            con.Close();
            return the_same; // return the value of the flag to the main sign up form
        }

        // this function to make sure there is no more than the limit accounts number in the database
        public bool check_limit_accounts(int limit_number)
        {
            // this variable hold the number of rows in the table in the database 
            int count_rows = 0;
            // this flag will hold the result of the search in the database
            bool is_limit = false;
            // make the sql connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("select user_N from Managers", con);
            // make the data reader of the sql with the excution of the sql command 
            SqlDataReader dr = cmd.ExecuteReader();
            // now loop on the rows in the data reader 
            while (dr.Read()) count_rows++; // for each row increament the counter of the variable 
            // in case the number of rows in the database table is the limit number then 
            if (count_rows == limit_number) is_limit = true;  // return with non success operation flag
            // close the data reader of the sql 
            dr.Close();
            // close the connection 
            con.Close();
            return is_limit;
        }

        // This function to create the authontication code for the user in case of  the password is forgotten
        public string create_authontication_code()
        {
            // this is the random generator for the digits of the number 
            Random generator = new Random();
            // make the variable that will hold the authontication codes
            string code = "";
            // this flag to indicate if the code is in the data base or not 
            bool is_found = true;
            // loop until find a code not in the data base and 
            while (code == "" || is_found)
            {
                // call this function to create the code 
                code = create_code(generator);
                // now check if the code is in the data base before 
                is_found = check_code_in_database(code);
            }
            return code; // return with the generated code 
        }

        // this function to create the code of the authontication 
        private string create_code(Random generator)
        {
            string code = "";
            // creation of the code is about 9 numbers each one is random digit 
            // each digit is between 0 and 9 -> [0, 9]
            for (int i = 0; i < 9; ++i) code = String.Concat(code, generator.Next(10).ToString());
            return code; // return with the generated code
        }

        // this function to check if the code is in the data base 
        private bool check_code_in_database(string code)
        {
            // this flag to identicate if the code is in the data base or not 
            bool is_found = false;
            // first get the connection of the sql server 
            SqlConnection con = get_connection();
            // make the command to select all the rows in the table 
            SqlCommand cmd = new SqlCommand("select authuntication_number from Managers where authuntication_number = @code", con);
            // add the command parameters 
            cmd.Parameters.AddWithValue("@code", code);
            // get the rows in the table by using the reader 
            SqlDataReader datareader = cmd.ExecuteReader();
            // in case the data reader has rows (the code exists) 
            if (datareader.HasRows) // in this case make the flag on 
                is_found = true;
            // close the data reader we just open 
            datareader.Close();
            // close the connection 
            con.Close();
            return is_found; // return with the flag
        }

        // this function for saving the managers data in the data base
        public void save_managers_data(string name, string user_name, string password, string authuntication_code)
        {
            // first get the connection of the sql server 
            SqlConnection con = get_connection();
            // make the command to select all the rows in the table 
            SqlCommand cmd = new SqlCommand("insert into Managers values(@name, @username, @password, @code)", con);
            // declare the parameters and add them to the cmd (sql command) 
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@username", user_name);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@code", authuntication_code);
            // now excute the query 
            cmd.ExecuteNonQuery();
            // close the connection 
            con.Close();
        }
    }
}
