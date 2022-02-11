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
    public partial class ReportTrainees_Form : Form
    {
        // make an object from the Search class 
        SearchTrainees_Class stc;
        // make the sql connection, sql data reader 
        SqlConnection con;
        SqlDataReader dr;
        public ReportTrainees_Form()
        {
            InitializeComponent();
            // intialize the search trainee object 
            stc = new SearchTrainees_Class();
            // intialize the connection and the data reader 
            con = null;
            dr = null;
        }

        // this function to handle the gridview for each button 
        public void Handle_GridView(bool is_all, int ID_Fill)
        {
            // call this function to get the connction and the data reader
            stc.Make_SQLData("select * from Traineers", ref con, ref dr);
            // check if there is data in the rows of the database 
            if (!dr.HasRows)
            {
                // make object from the alert 
                Alert_Form af = new Alert_Form("Empty Database\nThere are no Data To Show !!!",
                    Main_Functions.AlertType.Information, 80);
                // make the form on the top most of the other forms 
                af.TopMost = true;
                // show the alert 
                af.Show();
                // exit the function 
                return;
            }
            // check the id to know wich way to fill the data grid view 
            if (ID_Fill == 1)
            {
                // loop on the rows in the data reader 
                while (dr.Read())
                    // add the data in the data grid view for each trainee
                    Report_GridView.Rows.Add(dr[1].ToString(), dr[0].ToString(),dr[2].ToString(),
                        dr[6].ToString(), dr[7].ToString());
            }
            else if (ID_Fill == 2)
            {
                // loop on the rows in the data reader 
                while (dr.Read())
                    // in case the current date is less than the date of payment 
                    if (DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) <= DateTime.Parse(dr[7].ToString()))
                        // add the data in the data grid view for each trainee
                        Report_GridView.Rows.Add(dr[1].ToString(), dr[0].ToString(), dr[2].ToString(),
                        dr[6].ToString(), dr[7].ToString());
            }
            else if (ID_Fill == 3)
            {
                // loop on the rows in the data reader 
                while (dr.Read())
                    // in case the current date is less than the date of payment 
                    if (DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) > DateTime.Parse(dr[7].ToString()))
                        // add the data in the data grid view for each trainee
                        Report_GridView.Rows.Add(dr[1].ToString(), dr[0].ToString(), dr[2].ToString(),
                        dr[6].ToString(), dr[7].ToString());
            }
            // close the data reader 
            dr.Close();
            //close the connection 
            con.Close();
            // formate the Grid View by calling this fucntion
            stc.format_gridview(ref Report_GridView, is_all);
            // this function for increasing the cell height 
            stc.increase_height(ref Report_GridView);
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

        private void ReportTrainees_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the full Trainees Button as Checked (Defult Option) 
            FullTrainees_Button.Checked = true;

            // set the Full Trainees Button Tip 
            AllTraineesButton_Tip.SetToolTip(FullTrainees_Button,
                "المتمرنين الجميع عرض");
            // set the In Progress Button Tip 
            InProgressTraineesButton_Tip.SetToolTip(InPorgressTrainees_Button,
                "الساريه الاشتراكات اصحاب المتمرنين عرض");
            // set the Finished Button Tip 
            FinishedTraineesButton_Tip.SetToolTip(FinishedTrainees_Button,
                "المنتهيه الاشتراكات اصحاب المتمرنين عرض");
        }

        private void FullTrainees_Button_CheckedChanged(object sender, EventArgs e)
        {
            // if this button is checked 
            if (FullTrainees_Button.Checked)
            {
                // first clear the grid view rows 
                Report_GridView.Rows.Clear();
                // call this function to handel the data in the gridview 
                Handle_GridView(true,1);
            }
        }

        private void InPorgressTrainees_Button_CheckedChanged(object sender, EventArgs e)
        {
            // if this button is checked 
            if (InPorgressTrainees_Button.Checked)
            {
                // first clear the grid view rows 
                Report_GridView.Rows.Clear();
                // call this function to handel the data in the gridview 
                Handle_GridView(false,2);
            }
        }

        private void FinishedTrainees_Button_CheckedChanged(object sender, EventArgs e)
        {
            // if this button is checked 
            if (FinishedTrainees_Button.Checked)
            {
                // first clear the grid view rows 
                Report_GridView.Rows.Clear();
                // call this function to handel the data in the gridview 
                Handle_GridView(false,3);
            }
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Refresh_Button_Click(sender, e);
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            // in case the full trainee button is checkecd 
            if (FullTrainees_Button.Checked)
                FullTrainees_Button_CheckedChanged(sender, e);
            // in case the in progress button is checked
            else if (InPorgressTrainees_Button.Checked)
                InPorgressTrainees_Button_CheckedChanged(sender, e);
            // in case the finished button is checked
            else if (FinishedTrainees_Button.Checked)
                FinishedTrainees_Button_CheckedChanged(sender, e);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            // first open the file diaglog for save 
            SaveFileDialog sfd = new SaveFileDialog();
            // make default name for the save file dialog 
            sfd.FileName = "Defualt Name";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // get the name of the file
                string file_name = sfd.FileName;
                // make the query 
                string query = "select BarCode_ID, Name, Payment," +
                                 "GYM, Fittness, Time_Of_Payment, Date_Of_Pyament," +
                                "Date_To_Pay, Phone_Number, Discount, Manager_Name from Traineers";
                // make a list from the names of the columns 
                List<string> column_names = new List<string>() { "BarCode_ID",
                "Name", "Payment"
                 , "GYM", "Fittness", "Time_Of_Payment", "Date_Of_Pyament"
                , "Date_To_Pay", "Phone_Number", "Discount", "Manager_Name"};
                // just try to do the following 
                try
                {
                    // call this function to save the file in the excel data 
                    stc.Export_To_ExcelSheet(query, file_name, column_names,
                        "Trainees Full Report");
                }
                // in case the error happend 
                catch
                {
                    // call this function to handle the error alert 
                    stc.Handle_Alerts("Worng Input\nRequired The Name Of the File Only",
                        Main_Functions.AlertType.error, 80);
                }
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            string file_name = "";
            // open load file dialog to get the name of the excel sheet 
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Choose Traineers Excel File";
            od.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (od.ShowDialog() == DialogResult.OK)
            {
                file_name = od.FileName;

                try
                {
                    stc.Import_From_Excel_Sheet_Trainners(file_name);
                }
                catch
                {
                    // call this function to handle the error alert 
                    stc.Handle_Alerts("Worng Input\nRequired The Excel Of Traineers Only",
                        Main_Functions.AlertType.error, 80);
                }
            }
        }
    }
}
