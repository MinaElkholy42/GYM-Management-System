using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace GYM_Mangment_System
{
    public partial class BudgetAddRevenues_Form : Form
    {
        // make object from the budget options class 
        BudgetOptions_Class bo;
        public BudgetAddRevenues_Form()
        {
            InitializeComponent();
            // initialize the object from the budget options class 
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

        private void BudgetAddRevenues_Form_Load(object sender, EventArgs e)
        {
            // make the animation of the form using the form animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus on the revenues text box 
            Revenues_TextBox.Focus();
            Revenues_TextBox.Select();
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // in case the enter button is pressed 
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Enter_Button_Click(sender, e);
        }

        private void Revenues_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (Revenues_TextBox.Text == "Enter The Revenue") // remove the place holder
                Revenues_TextBox.Text = string.Empty;
        }

        private void Revenues_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (Revenues_TextBox.Text.Trim(bo.tcs) == string.Empty) // add the place holder
                Revenues_TextBox.Text = "Enter The Revenue";
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // first take the amount of money Entered 
            string money = Revenues_TextBox.Text.Trim(bo.tcs); 

            // check the empty input 
            if (money == "Enter The Revenue" || money == "")
            {
                // Call This Function to handle the alert 
                bo.Handle_Alerts("Data InComplete\nRequired The Amount Of Revenues",
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            // Check the validation of the Entered Revenues 
            else if (!(Regex.IsMatch(money, @"^[0-9]+$")))
            {
                // Call This Function to handle the alert 
                bo.Handle_Alerts("Wrong Input\nThe Amount of Reveues\nMust Be A Number With Out Spaces",
                    Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // this means all things are done so we will move to the add of the money according to the date

            // take the revenues amount 
            int revenues_amount = Convert.ToInt32(money);
            // get the current month 
            int month = DateTime.Now.Month;
            // get the current year 
            int year = DateTime.Now.Year;
            // call this function to add the revenues to the demand table
            bo.Add_Revenues(month, year, revenues_amount);

            // back to the original 
            Revenues_TextBox.Text = string.Empty;
            Revenues_TextBox.Focus();
            Revenues_TextBox.Select();
        }
    }
}
