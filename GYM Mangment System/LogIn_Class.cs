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
    class LogIn_Class:Main_Functions // this class inhrit from the main class that hold the main functions and attributes
    {

        // this function to help the login in the search of the user name and password in the data base
        public bool search_username_password(string us, string pass)
        {
            // this flage indicates if the data for the login is right or not
            bool is_right = false; 
            // make the connection 
            SqlConnection con = get_connection();
            // make the sqlcommand 
            SqlCommand cmd = new SqlCommand("select user_N, Pass, Name from Managers where user_N = @user_name and " +
                "Pass = @password", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@user_name", us);
            cmd.Parameters.AddWithValue("@password", pass);
            // make the sql datareader and excute it 
            SqlDataReader dr = cmd.ExecuteReader();
            // in case there is rows (signle row) in the data reader 
            if (dr.HasRows)
            {
                is_right = true; // make the flage on
                // read the row 
                dr.Read();
                // set the name in the main functions class
                set_name(dr["Name"].ToString());
            }
            //close the connection 
            con.Close();
            return is_right; // return the result
        }

        // this function to check the word is entered or not of the reports 
        public bool Check_Word()
        {
            // make the path of the string 
            string path = "Word.txt";
            // make the bool flag to indicate true or false
            bool there_is_word = true;

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
            
            // make the stream reader 
            StreamReader rd = new StreamReader(path);
            // first read the file 
            string line = rd.ReadLine();
            // close the data reader 
            rd.Close();
            // in case the line is null (no word) return false
            if (line == null || line == "") there_is_word = false;
            else set_word(line); // set the line word 
            return there_is_word;
        }
    }
}
