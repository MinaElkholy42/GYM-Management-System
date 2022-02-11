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
// for using the bunifu controls 
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
namespace GYM_Mangment_System
{
    class Remeber_Class: Main_Functions // make the inheritance from the main class for the main functions
    {

        // this function to search the data base for the same code and the same name
        public void search_name_code(string name, string code, ref int id)
        {
            
            // get the connection 
            SqlConnection con = get_connection();
            // make the command to select all the rows in the table 
            SqlCommand cmd = new SqlCommand("select * from Managers where Name = @Name and authuntication_number = @code", 
                con);
            // add to the command the parameters 
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@code", code); 

            // get the rows in the table by using the reader 
            SqlDataReader datareader = cmd.ExecuteReader();

            // in case there is data reader has data (only one row) 
            if (datareader.HasRows)
            {
                // read the only row 
                datareader.Read();
                // make object form the alert form
                Alert_Form af = new Alert_Form("Data Recoverd\n" +
                    "User Name : " + datareader["user_N"].ToString() + "\n"
                    + "Password : " + datareader["Pass"].ToString(), Main_Functions.AlertType.success, 100);
                // make the form on the top most of the other forms 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // make the id to 1 as return every thing to original in the main remeber form desing 
                id = 1;
            }

            // this means the entered data is not correct
            else
            {
                // make object form the alert form
                Alert_Form af = new Alert_Form("Wrong Data\n" +
                    "Please Check the Entered\nName Or Authontication Code", Main_Functions.AlertType.error, 100);
                // make the form on the top most of the other forms 
                af.TopMost = true;
                // show the alert form 
                af.Show();
            }
            // close the data reader we just open 
            datareader.Close();
            // close the connection 
            con.Close();
    
        }
     
        // this function to back to the original state of the text boxes in the remeber main form 
        public void back_to_original(ref BunifuMaterialTextbox name, ref BunifuMaterialTextbox code)
        {
            // make the text boxes both of them to the empty string value 
            name.Text = string.Empty; // name textbox 
            code.Text = string.Empty; // authontication textbox

            // make the select on the name textbox 
            name.Focus();
            name.Select();
        }
    }
}
