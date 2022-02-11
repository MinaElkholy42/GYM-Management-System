using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Guna.UI2.WinForms;
using System.Windows.Forms;
namespace GYM_Mangment_System
{
    class BudgetOptions_Class : Main_Functions // make the inheritance from the main functions class
    {

        // this function to load the years in the combo box of the main form 
        public void Load_Years(ref Guna2ComboBox Years_ComboBox)
        {
            // we want here to make the cell height to some number to increase it 
            // once on the load select all the years inside the data base table of Demand 
            string last_year = ""; // this variable to hold the last year in the combo box 
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command with the query and the connection 
            SqlCommand cmd = new SqlCommand("select DISTINCT year from Demand order by year", con);
            // excute the reader to read the data 
            SqlDataReader dr = cmd.ExecuteReader();
            // now we have all unique years fill the combo box with the yeras 
            while (dr.Read())// while we read the years
            {
                // add the years to the combo box 
                Years_ComboBox.Items.Add(dr[0].ToString());
                last_year = dr[0].ToString(); // assign the new year in the variable to get the last year
            }
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            // now we make the last year the default value in the combo box 
            Years_ComboBox.SelectedIndex = Years_ComboBox.Items.IndexOf(last_year);
        }

        // this function to load the months of the year to the Months Combobox 
        public void Load_Months(int year, ref Guna2ComboBox Months_ComboBox, 
            ref Guna2GradientTileButton button_refresh, ref Guna2GradientTileButton button_save)
        {
            // first clear the items in the combo box 
            Months_ComboBox.Items.Clear();

            string last_month = ""; // this variable to hold the last month in the combo box 
            // make the connection 
            SqlConnection con = get_connection();
            // make the command 
            SqlCommand cmd = new SqlCommand(@"select DISTINCT month from Expenses 
                                             where year = @y order by month", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@y", year);
            // make the data reader
            SqlDataReader dr = cmd.ExecuteReader();
            // loop on the reading of the data reader 
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // add the months to the combo box 
                    Months_ComboBox.Items.Add(dr[0].ToString());
                    last_month = dr[0].ToString(); // assign the new month in the variable to get the last month
                }
                // now we make the last month the default value in the combo box 
                Months_ComboBox.SelectedIndex = Months_ComboBox.Items.IndexOf(last_month);
                // enable the buttons 
                button_refresh.Enabled = button_save.Enabled = true;
            }
            else
            {
                // call this function to handle the alerts 
                Handle_Alerts("Empty Year\nNo Expenses To Show For This Year", AlertType.Information,
                    80);
                // Disable the buttons 
                button_refresh.Enabled = button_save.Enabled = false;
            }
            // close the data reader 
            dr.Close();
            // now close the connection 
            con.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        // Budget Full Report ////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////

        // this function to format the back ground color of the gridview 
        private void Format_GridView(ref DataGridView Report_GridView)
        {
            // loop on each row in the data grid view 
            foreach(DataGridViewRow row in Report_GridView.Rows)
            {
                // intizlize the revenues and expenses with 0 
                int revenues = 0, exepenses = 0;
                // try to get the revenues and expenses in the data grid view 
                try
                {
                    // get the values of the revenues and the expenses
                    revenues = Convert.ToInt32(row.Cells[1].Value.ToString());
                    exepenses = Convert.ToInt32(row.Cells[2].Value.ToString());
                    // check if the expenses is much bigger thant the revenues 
                    if (exepenses > revenues) // in this case 
                        // turn the back ground of the row to dark red 
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                    // make the height of the row is 45 
                    row.Height = 45;
                }
                // the catch will do nothing just end the process
                catch { break; }
            }
        }

        // this function to handle the report in the gridview in the budget report 
        public void BudgetReport_Show(ref DataGridView Report_GridView, Guna2ComboBox Years_ComboBox)
        {
            // first clear the data gridview rows
            Report_GridView.Rows.Clear();
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command with the query and the connection 
            SqlCommand cmd = new SqlCommand(@"select month, revenues, expensses, revenues-expensses 
                                               from Demand where year = @y", con);
            // add the sql parameter 
            cmd.Parameters.Add(new SqlParameter("@y", 
                Convert.ToInt32(Years_ComboBox.SelectedItem.ToString())));
            // excute the reader to read the data 
            SqlDataReader dr = cmd.ExecuteReader();
            // while reading each row in the date reader 
            while (dr.Read())
            {
                // firs we get the total column as integer 
                int total = Convert.ToInt32(dr[3].ToString());
                if (total < 0)// this mean we lost money negative number 
                    // add the current row to the data grid view 
                    Report_GridView.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), 
                        (-total).ToString());
                else
                    // add this row to the data grid view 
                    Report_GridView.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                         total.ToString());
            }
            Format_GridView(ref Report_GridView);
            // make the focus on the next cell in the next row 
            Report_GridView.CurrentCell = Report_GridView.Rows[Report_GridView.Rows.Count - 1].Cells[0];
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        // Add Revenues ////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        
        public void Add_Revenues(int month, int year, int amount)
        {
            // get the connection 
            SqlConnection con = get_connection();
            // make the command 
            SqlCommand cmd = new SqlCommand(@"Update Demand set revenues = revenues + @rev
                                            Where month = @month and year = @year", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@rev", amount);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            // execute the command wiht the non query 
            int id_operation = cmd.ExecuteNonQuery();
            // in case the update has done 
            if (id_operation == 1) // call this function to handle the alert 
                Handle_Alerts("Opeartion Succeeded\nRevenues Addition Is Done", AlertType.success, 80);
            // close the connection 
            con.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        // Add Expenses With the Text ////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        
        // this function to add the amount of expenses wiht respect to the year and the month
        public void Add_Expenses(int month, int year, int amount)
        {
            // get the connection 
            SqlConnection con = get_connection();
            // make the command 
            SqlCommand cmd = new SqlCommand(@"Update Demand set expensses = expensses + @exp
                                            Where month = @month and year = @year", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@exp", amount);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            // execute the command wiht the non query 
            int id_operation = cmd.ExecuteNonQuery();
            // in case the update has done 
            if (id_operation == 1) // call this function to handle the alert 
                Handle_Alerts("Opeartion Succeeded\nExpenses Has Been Inserted", AlertType.success, 80);
            // close the connection 
            con.Close();
        }

        // this function to insert the amount of expenses with the porpuse of it
        public void Insert_Expenses(int month, int year, int amount, string text)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("insert into Expenses values (@month, @year, @exp, @text)", 
                con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@exp", amount);
            cmd.Parameters.AddWithValue("@text", text);
            // excute the sql command 
            cmd.ExecuteNonQuery();
            // close the connection 
            con.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        // Expenses Report Show ////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////

        // this function to fill the gridview according to the month and the year 
        public void ExpensesReport_Show(int month, int year, ref DataGridView Report_GridView)
        {
            // first clear the data grid view 
            Report_GridView.Rows.Clear();
            // get the connection
            SqlConnection con = get_connection();
            // make the command 
            SqlCommand cmd = new SqlCommand(
                "select Expensses, Text from Expenses where year = @y and month = @m", con);
            // add the sql parameters 
            cmd.Parameters.AddWithValue("@y", year);
            cmd.Parameters.AddWithValue("@m", month);
            // make the data reader
            SqlDataReader dr = cmd.ExecuteReader();
            // loop on eahc row in the data reader 
            while (dr.Read())
                // add the row to the grid view 
                Report_GridView.Rows.Add(dr[0].ToString(), dr[1].ToString());
            // close the connection 
            con.Close();

            // loop on each row in the data grid view 
            foreach (DataGridViewRow row in Report_GridView.Rows)
                // make the height of the row to 45 
                row.Height = 45;
            // make the selection and the focus on the first cell in the empty row 
            Report_GridView.CurrentCell = Report_GridView.Rows[Report_GridView.Rows.Count - 1].Cells[0];
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        // Modify Section ////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        
        // this function to check the amount of the revenues money validation
        public bool Check_Revenues(int money, int month, int year)
        {
            // make this flage to indicate the validation for the amount of the money 
            bool valid_amount = true;
            // get the connection 
            SqlConnection con = get_connection();
            // make the command 
            SqlCommand cmd = new SqlCommand(@"select revenues from Demand where month = @m and year = @y", 
                con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@m", month);
            cmd.Parameters.AddWithValue("@y", year);
            // make the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the single line 
            dr.Read();
            // check if the amount of money is larger than the amount of the revenues
            if (Convert.ToInt32(dr[0].ToString()) < money) valid_amount = false; // turn the flag off 
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            // return with the flag 
            return valid_amount;
        }

        // this function to check the amount of the Expenses money validation
        public bool Check_Expenses(int money, int month, int year)
        {
            // make this flage to indicate the validation for the amount of the money 
            bool valid_amount = true;
            // get the connection 
            SqlConnection con = get_connection();
            // make the command 
            SqlCommand cmd = new SqlCommand(@"select expensses from Demand where month = @m and year = @y",
                con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@m", month);
            cmd.Parameters.AddWithValue("@y", year);
            // make the data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            // read the single line 
            dr.Read();
            // check if the amount of money is larger than the amount of the revenues
            if (Convert.ToInt32(dr[0].ToString()) < money) valid_amount = false; // turn the flag off 
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
            // return with the flag 
            return valid_amount;
        }

        // this function for the update of the desired modification 
        public void Update_Modification(int month, int year, string operation, string direction, int money)
        {
            // make the connection 
            SqlConnection con = get_connection();
            // make the sql command 
            SqlCommand cmd = new SqlCommand("Update Demand Set " + direction + " = " + 
                direction + operation + " @amount where month = @m and year = @y", con);
            // add the command parameters 
            cmd.Parameters.AddWithValue("@amount", money);
            cmd.Parameters.AddWithValue("@m", month);
            cmd.Parameters.AddWithValue("@y", year);
            // execute the command 
            int id_operation = cmd.ExecuteNonQuery();
            // in case the id is 1 and the operation succeeded 
            if (id_operation == 1) // call this function to handle the alert 
                Handle_Alerts("Operation Succeeded\nUpdate of " + direction + " Has Done", 
                    AlertType.success, 80);
            // close the connection 
            con.Close();
        }
    }
}
