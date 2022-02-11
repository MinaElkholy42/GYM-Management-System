using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Mangment_System
{
    public partial class BudgetFullReport_Form : Form
    {
        // make object from the class Budget Options Class
        BudgetOptions_Class bo;
        public BudgetFullReport_Form()
        {
            InitializeComponent();
            // initialize the Budget Options Class Object 
            bo = new BudgetOptions_Class();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // close the current form 
            this.Close();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            // make the form window down the desktop 
            WindowState = FormWindowState.Minimized;
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Refresh_Button_Click(sender, e);
        }

        private void BudgetFullReport_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the form animator 
            Form_Animation.SetAnimateWindow(this);
            // call this function to make the combo box with the list of years in the data base
            bo.Load_Years(ref Years_ComboBox);
        }

        private void Years_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call this function to handle the report of the budget 
            bo.BudgetReport_Show(ref Report_GridView, Years_ComboBox);
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            // call this function of the selected index changed again
            Years_ComboBox_SelectedIndexChanged(sender, e);
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
                // take the selected year 
                int year = Convert.ToInt32(Years_ComboBox.SelectedItem.ToString());
                // make the query 
                string query = "select * from Demand Where year = " + year.ToString();
                // make a list from the names of the columns 
                List<string> column_names = new List<string>() { "Month", "Year", "Revenues",
                    "Expensses" };
                // just try to do the following 
                try
                {
                    // call this function to save the file in the excel data 
                    bo.Export_To_ExcelSheet(query, file_name, column_names,
                        "Budget Full Report");
                }
                // in case the error happend 
                catch
                {
                    // call this function to handle the error alert 
                    bo.Handle_Alerts("Worng Input\nRequired The Name Of the File Only",
                        Main_Functions.AlertType.error, 80);
                }
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            string file_name = "";
            // open load file dialog to get the name of the excel sheet 
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Choose Full Budget Excel File";
            od.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (od.ShowDialog() == DialogResult.OK)
            {
                file_name = od.FileName;

                try
                {
                    bo.Import_From_Excel_Sheet_Budget(file_name);
                }
                catch
                {
                    // call this function to handle the error alert 
                    bo.Handle_Alerts("Worng Input\nRequired The Excel Of Full Budget Only",
                        Main_Functions.AlertType.error, 80);
                }
            }
        }
    }
}
