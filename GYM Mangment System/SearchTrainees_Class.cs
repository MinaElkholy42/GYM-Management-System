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
    class SearchTrainees_Class : Main_Functions // make the inheritance from the main functions class
    {
        // this function for handling the search of the code entered in the BarCode ID 
        public bool search_BarCodeID(string code)
        {
            // make this bool flag to indicate if the code exists in the data base or not 
            bool code_exists = false;
            // make the query 
            string query = "select * from Traineers where BarCode_ID = @code";
            // first get the connection of the sql server 
            SqlConnection con = get_connection();
            // make the command to select all the rows in the table 
            SqlCommand cmd = new SqlCommand(query, con);
            // add the parameters to the sql command 
            cmd.Parameters.AddWithValue("@code", code);
            // get the rows in the table by using the reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // in case the data reader has rows (the code exists)
            if (dr.HasRows)
                code_exists = true;// turn the flag on (to true)
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            // return with the flag 
            return code_exists;
        }

        // this function for handling the search of the Phone entered in the PhoneNumber TextBox
        public bool search_PhoneNumber(string PhoneNumber)
        {
            // make this bool flag to indicate if the Phone Number exists in the data base or not 
            bool Phone_Exists = false;
            // make the query 
            string query = "select * from Traineers where Phone_Number = @Phone";
            // first get the connection of the sql server 
            SqlConnection con = get_connection();
            // make the command to select all the rows in the table 
            SqlCommand cmd = new SqlCommand(query, con);
            // add the parameters to the sql command 
            cmd.Parameters.AddWithValue("@Phone", PhoneNumber);
            // get the rows in the table by using the reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // in case the data reader has rows (the Phone Number exists)
            if (dr.HasRows)
                Phone_Exists = true; // turn the flag on (to true)
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            // return with the flag 
            return Phone_Exists;
        }

        // Report Section 

        // this function for making the connction and the data reader with the sent query 
        public void Make_SQLData(string query, ref SqlConnection con, ref SqlDataReader dr)
        {
            // make the connection 
            con = get_connection();
            // make the sqlcommand 
            SqlCommand cmd = new SqlCommand(query, con);
            // excute the data reader  
            dr = cmd.ExecuteReader();
        }

        // this fuction for making the cell increase in the height 
        public void increase_height(ref DataGridView Report_GridView)
        {
            // loop on each row in the data grid view 
            for (int i = 0; i < Report_GridView.Rows.Count - 1; ++i)
            {
                DataGridViewRow row = Report_GridView.Rows[i]; // get the row
                row.Height = 45; // assign the height
            }
        }

        // this fucntion for the format of the gridview 
        public void format_gridview(ref DataGridView Report_GridView, bool all_trainess)
        {
            // in case the all trainees (the full report requested)
            if (all_trainess)
            {

                // loop on each row in the data grid view 
                foreach (DataGridViewRow row in Report_GridView.Rows)
                {
                    // take the value of the date in the data grid view 
                    // inside try and catch for the last row in the data grid view
                    string date = "";
                    try { date = (row.Cells[4].Value).ToString(); }
                    catch { break; }
                    // if the date to pay is more than the current date change the back ground 
                    if (DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) > DateTime.Parse(date))
                        // make the background color to Dark red 
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                }
            }
            // make the selection and the focus on the first cell in the empty row 
            Report_GridView.CurrentCell = Report_GridView.Rows[Report_GridView.Rows.Count - 1].Cells[0];
        }
    }
}
