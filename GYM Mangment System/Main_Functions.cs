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
using Bunifu.Framework.UI; // to use the bunifu toolbox
using ClosedXML.Excel;
using System.IO;
namespace GYM_Mangment_System
{
    public class Main_Functions // this is the main class holding the main functions we will use in all other classes
    {

        /////////////////////////////////////////////////////////////////////////////////////////////////
        // MAIN VARIABLES FOR ALL FORMS /////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public char[] tcs = new char[]{' '}; //char array for the trim postions of the string 
        static string user_name { get; set; } // for the current manager user name 
        static string password { get; set; } // for the current manager password 
        static string password_key { get; set; }// for the passwords of the reports in the control form 
        static string name_manager { get; set; } // for the name of the log in manager to the controls form 
        // this enum holds the types we need for the alerts 
        public enum AlertType
        {
            success, error, Information
        }
        // this array holds the number of days in each month 
        public static int[] months_days = new int[]
        {
            31,28,31,30,31,30,31,31,30,31,30,31
        };

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // MAIN FUNCTIONS FOR ALL FORMS /////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        // this function to handle any type of the alerts types 
        public void Handle_Alerts(string message, Main_Functions.AlertType alert, int hieght)
        {
            // make the alert 
            Alert_Form af = new Alert_Form(message, alert, hieght);
            // make the alert  as the top most on all other forms
            af.TopMost = true;
            // show the alert 
            af.Show();
        }

        // this function to check if the from is opened or not 
        public void FormIsOpen(string form_name, ref bool is_opened)
        {
            // loop on all the opened forms in the applicaiton 
            foreach(Form form in Application.OpenForms)
            {
                // check if the name is the same name sent 
                if (form.Name == form_name)
                {
                    // turn the flag (bool) to on mode 
                    is_opened = true;
                    // make the form window state in the normal state 
                    form.WindowState = FormWindowState.Normal;
                    // bring the form to the front 
                    form.BringToFront();
                    // break the loop to prevent continue in the search 
                    break;
                }
            }
        }

        // this function to set the current user name log in the new controls form 
        public static void set_current_username(string username)
        {
            // set the current user name 
            user_name = username;
        }
        // this function to return the current user name
        public static string get_current_username()
        {
            // return with the current user name 
            return user_name;
        }

        // this function to set the current password log in the new controls form 
        public static void set_current_password(string pass)
        {
            // set the current password
            password = pass;
        }
        // this function to return the current password
        public static string get_current_password()
        {
            // return with the current password 
            return password;
        }

        // this fucntion to set the word of the user in the new format 
        public static void set_word(string word)
        {
            // set the password key to the word the user sent
            password_key = word;
        }
        // this function to get the word of the user in the new format 
        public static string get_word()
        {
            // return with the word 
            return password_key;
        }

        // this function to set the name of the current manager 
        public static void set_name (string name)
        {
            // now set the name of the manager that log in to the system
            name_manager = name; 
        }
        // this funciton to get the name of the manager that is in the system 
        public static string get_name()
        {
            // return with the name
            return name_manager;
        }

        // this function to open the connection of the sql data base 
        public SqlConnection get_connection()
        {
            // this for the sql server conncetion 
            string sql_connection = "Data Source=.\\SQLEXPRESS;Initial Catalog=GYM_DataBase;Integrated Security=SSPI;";

            // this for the local data base
            // string local_connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\LionGYM_DataBase.mdf\";Integrated Security=True";

            // make the connection
            SqlConnection con = new SqlConnection(sql_connection);
            // open the connection 
            con.Open();
            return con;
        }

        // this fucntion for exit the application in any form or button call this 
        public void exit_application()
        {
            // exit the Application
            Application.Exit();
        }

        // this function to make the password character for the text box of the bunifu material textbox 
        public void make_password(ref BunifuMaterialTextbox textbox)
        {
            // make the password property true for the text box
            textbox.isPassword = true;
        }

        // this function to make sure if there is data in the managers table or not
        public bool check_managers_existing()
        {
            int icount_rows = 0; // this will hold the number of rows in the manager table in the database
            // make the connection
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("select user_N from Managers", con);
            // make the data reader and excute the command 
            SqlDataReader dr = cmd.ExecuteReader();
            // read at least on row in the datareader if exists
            if (dr.Read()) icount_rows++;
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();

            // if there were any rows in the data base table (Managers) 
            if (icount_rows != 0) return true;
            return false;
        }

        // this function to export the data base to excel sheet
        public void Export_To_ExcelSheet(string query, string location
            , List<string> column_names, string file_name)
        {
            // open the work book first
            using (var workbook = new XLWorkbook())
            {
                // make a new work sheet as excel with the name of the parameter 
                var ws = workbook.Worksheets.Add(file_name);
                // make the headers of the work sheet (loop on the names of the columns)
                for (int i = 1; i <= column_names.Count; ++i)
                    // assign the value of the cell in the row number 1 with the column name 
                    ws.Cell(1, i).Value = column_names[i - 1];

                // make the sqlconnection 
                SqlConnection con = get_connection();
                // make the sql data adapter 
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                // make data table 
                DataTable dt = new DataTable();
                // fill the data table with the sql data adapter 
                ad.Fill(dt);

                // this variable to count the rows of the excel in the data table rows
                int row_count = 2;
                foreach(DataRow row in dt.Rows)
                {
                    // loop on each column in the data table
                    for (int i = 1; i <= column_names.Count; ++i)
                    {
                        if (i == 6) ws.Cell(row_count, i).Value = (Convert.ToDateTime(row[i - 1].ToString())).ToString("hh:mm tt");
                        if (i == 7 || i == 8) ws.Cell(row_count, i).Value = (Convert.ToDateTime(row[i - 1].ToString())).ToString("yyyy-MM-dd");
                        else
                        // assign the value to the cell in the selected row 
                        ws.Cell(row_count, i).Value = row[i - 1].ToString();
                    }
                    // increament the row 
                    row_count++;
                }

                // save the excel file 
                workbook.SaveAs(location + ".xlsx");
                // call this function to make the alert 
                Handle_Alerts("Operation Succeeded\nThe Report Is Saved", AlertType.success, 80);
                // close the data adapter 
                ad.Dispose();
                // close the connection 
                con.Close();
            }
        }


        // this function to export the data base to excel sheet
        public void Import_From_Excel_Sheet_Trainners(string file_name)
        {

            

            // open the workbook 
            using (var workbook = new XLWorkbook(file_name))
            {

                var rows = workbook.Worksheet(1).RowsUsed();
                int i = -1;
                // first delete all data in the traineers 
                SqlConnection con_del = get_connection();
                // make the query of delete 
                SqlCommand cmd_del = new SqlCommand("DELETE FROM TRAINEERS;", con_del);
                // execute the query 
                int id_del = cmd_del.ExecuteNonQuery();
                // close the connection 
                con_del.Close();

                foreach(var r in rows)
                {
                    if (i == -1) { i++; continue; }
                    // make new connection for insertion 
                    SqlConnection con = get_connection();
                    // make sql command 
                    string query = "insert into TRAINEERS values (@code, @name, @pay, @g, @f, @top, @dop, @dtp, @phone, @dis, @mn)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // add the bind parameters 
                    cmd.Parameters.AddWithValue("@code", r.Cell(1).Value.ToString());
                    cmd.Parameters.AddWithValue("@name", r.Cell(2).Value.ToString());
                    cmd.Parameters.AddWithValue("@pay", Convert.ToInt32(r.Cell(3).Value.ToString()));
                    cmd.Parameters.AddWithValue("@g", r.Cell(4).Value.ToString());
                    cmd.Parameters.AddWithValue("@f", r.Cell(5).Value.ToString());
                    cmd.Parameters.AddWithValue("@top", Convert.ToDateTime(r.Cell(6).Value.ToString()).ToString("hh:mm tt"));
                    cmd.Parameters.AddWithValue("@dop", Convert.ToDateTime(r.Cell(7).Value.ToString()).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dtp", Convert.ToDateTime(r.Cell(8).Value.ToString()).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@phone", r.Cell(9).Value.ToString());
                    cmd.Parameters.AddWithValue("@dis", Convert.ToInt32(r.Cell(10).Value.ToString()));
                    cmd.Parameters.AddWithValue("@mn", r.Cell(11).Value.ToString());

                    // now execute the query 
                    int id = cmd.ExecuteNonQuery();

                    // close the connection 
                    con.Close();

                    
                }
                // call this function to make the alert 
                Handle_Alerts("Operation Succeeded\nThe Report Is Here", AlertType.success, 80);
            }
            
        }


        // this function to export the data base to excel sheet
        public void Import_From_Excel_Sheet_Budget(string file_name)
        {



            // open the workbook 
            using (var workbook = new XLWorkbook(file_name))
            {

                var rows = workbook.Worksheet(1).RowsUsed();
                int i = -1;
                int years = 0;
                

                foreach (var r in rows)
                {
                    if (i == -1) { i++; continue; }
                    if (i == 0)
                    {
                        years = Convert.ToInt32(r.Cell(2).Value.ToString());
                        // first delete all data in the traineers 
                        SqlConnection con_del = get_connection();
                        // make the query of delete 
                        SqlCommand cmd_del = new SqlCommand("DELETE FROM Demand where year = @y", con_del);
                        cmd_del.Parameters.AddWithValue("@y", years);
                        // execute the query 
                        int id_del = cmd_del.ExecuteNonQuery();
                        // close the connection 
                        con_del.Close();
                        ++i;
                    }
                    // make new connection for insertion 
                    SqlConnection con = get_connection();
                    // make sql command 
                    string query = "insert into DEMAND values (@m, @y, @r, @e)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // add the bind parameters 
                    cmd.Parameters.AddWithValue("@m", Convert.ToInt32(r.Cell(1).Value.ToString()));
                    cmd.Parameters.AddWithValue("@y", Convert.ToInt32(r.Cell(2).Value.ToString()));
                    cmd.Parameters.AddWithValue("@r", Convert.ToInt32(r.Cell(3).Value.ToString()));
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(r.Cell(4).Value.ToString()));

                    // now execute the query 
                    int id = cmd.ExecuteNonQuery();

                    // close the connection 
                    con.Close();

                    
                }
                // call this function to make the alert 
                Handle_Alerts("Operation Succeeded\nThe Report Is Here", AlertType.success, 80);
            }

        }


        // this function to export the data base to excel sheet
        public void Import_From_Excel_Sheet_Expensses(string file_name)
        {



            // open the workbook 
            using (var workbook = new XLWorkbook(file_name))
            {

                var rows = workbook.Worksheet(1).RowsUsed();
                int i = -1;
                int years = 0;
                int months = 0;

                foreach (var r in rows)
                {
                    if (i == -1) { i++; continue; }
                    if (i == 0)
                    {
                        months = Convert.ToInt32(r.Cell(1).Value.ToString());
                        years = Convert.ToInt32(r.Cell(2).Value.ToString());
                        // first delete all data in the traineers 
                        SqlConnection con_del = get_connection();
                        // make the query of delete 
                        SqlCommand cmd_del = new SqlCommand("DELETE FROM Expenses where year = @y and month = @m", con_del);
                        cmd_del.Parameters.AddWithValue("@y", years);
                        cmd_del.Parameters.AddWithValue("@m", months);
                        // execute the query 
                        int id_del = cmd_del.ExecuteNonQuery();
                        // close the connection 
                        con_del.Close();
                        ++i;
                    }
                    // make new connection for insertion 
                    SqlConnection con = get_connection();
                    // make sql command 
                    string query = "insert into Expenses values (@m, @y, @e, @t)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // add the bind parameters 
                    cmd.Parameters.AddWithValue("@m", Convert.ToInt32(r.Cell(1).Value.ToString()));
                    cmd.Parameters.AddWithValue("@y", Convert.ToInt32(r.Cell(2).Value.ToString()));
                    cmd.Parameters.AddWithValue("@e", Convert.ToInt32(r.Cell(3).Value.ToString()));
                    cmd.Parameters.AddWithValue("@t", r.Cell(4).Value.ToString());
                    // now execute the query 
                    int id = cmd.ExecuteNonQuery();

                    // close the connection 
                    con.Close();
                }
                // call this function to make the alert 
                Handle_Alerts("Operation Succeeded\nThe Report Is Here", AlertType.success, 80);
            }

        }



    }
}
