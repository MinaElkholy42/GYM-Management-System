using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace GYM_Mangment_System
{
    class Loading_Class:Main_Functions // this class inherit form the main fucntions class
    {

        // this function to handel the budget of the year 
        public void handle_budget()
        {
            // get the current year and initizlize the last year with 0 
            int current_year = DateTime.Now.Year, last_year = 0;
            // make connection 
            SqlConnection con = get_connection();
            // make the sqlcommand  the query is to get the last year in the table of the demand
            SqlCommand cmd = new SqlCommand("Select DISTINCT Year from Demand order by Year DESC", con);
            // make the reader and excute it using the sql command
            SqlDataReader dr = cmd.ExecuteReader();
            // if the data reader has data 
            if (dr.Read())
            {
                // get the last year inserted in the data base 
                last_year = Convert.ToInt32(dr[0].ToString());
                // if the new year is no inserted in the data base call the function to solve it
                if (last_year < current_year) make_years(current_year);
            }
            // if not then insert directly for the 12 months 
            else 
                make_years(current_year);
            // close the data reader 
            dr.Close();
            // close the connection 
            con.Close();
        }

        // this function for making a new year in the demand table of the data base 
        private void make_years(int current_year)
        {
            // loop on the numbers of the 12 months 
            for (int i = 1; i <= 12; ++i)// for each one insert a new row in the data base with the new year, month
                // the revenu and expnesses are not know till now 
                insert_demand_months(i, current_year, 0, 0);
        }

        // This function for inserting the new months of the new year in the demand table
        public void insert_demand_months(int month, int year, int revenues, int expnesses)
        {
            // make connection 
            SqlConnection con = get_connection();
            // make the sqlcommand  the query is to get the last year in the table of the demand
            SqlCommand cmd = new SqlCommand("insert into Demand values (@month, @year, @r, @ex)", con);
            // add the parameters 
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@r", revenues);
            cmd.Parameters.AddWithValue("@ex", expnesses);
            // excute the command and return the integer result of the operation   
            int id_operation = cmd.ExecuteNonQuery();
            // close the connection 
            con.Close();

        }
    }
}
