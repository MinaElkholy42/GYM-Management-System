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
    public partial class BudgetExpensesReport_Form : Form
    {
        // make object from the budget options class
        BudgetOptions_Class bo;
        public BudgetExpensesReport_Form()
        {
            InitializeComponent();
            // make initialization for the object from the budget options class 
            bo = new BudgetOptions_Class();
        }

        private void BudgetExpensesReport_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the form animator 
            Form_Animation.SetAnimateWindow(this);
            // call this function to make the combo box with the list of years in the data base
            bo.Load_Years(ref Years_ComboBox);
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

        private void Years_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected year
            int selected_year = Convert.ToInt32(Years_ComboBox.SelectedItem.ToString());
            // call this function to load the months of the year in the combo box 
            bo.Load_Months(selected_year, ref Months_ComboBox, ref Refresh_Button
                , ref Save_Button);

        }

        private void Months_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected month 
            int selected_month = Convert.ToInt32(Months_ComboBox.SelectedItem.ToString());
            // get the selected year
            int selected_year = Convert.ToInt32(Years_ComboBox.SelectedItem.ToString());
            // call this fucntion to load the expenses in the gridview 
            bo.ExpensesReport_Show(selected_month, selected_year, ref Report_GridView);
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            // just call the months selected function 
            Months_ComboBox_SelectedIndexChanged(sender, e);
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
                // take the selected month 
                int month = Convert.ToInt32(Months_ComboBox.SelectedItem.ToString());
                // make the query 
                string query = "select * from Expenses Where year = " + year.ToString()
                                + " and month = " + month.ToString();
                // make a list from the names of the columns 
                List<string> column_names = new List<string>() { "Month", "Year",
                    "Expensses", "Text"};
                // just try to do the following 
                try
                {
                    // call this function to save the file in the excel data 
                    bo.Export_To_ExcelSheet(query, file_name, column_names,
                        "Expenses Full Report");
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
            od.Title = "Choose Expensess Excel File";
            od.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (od.ShowDialog() == DialogResult.OK)
            {
                file_name = od.FileName;
                
                try
                {
                    bo.Import_From_Excel_Sheet_Expensses(file_name);
                }
                catch
                {
                    // call this function to handle the error alert 
                    bo.Handle_Alerts("Worng Input\nRequired The Excel Of Expensses Only",
                        Main_Functions.AlertType.error, 80);
                }
            }
        }
    }
}
