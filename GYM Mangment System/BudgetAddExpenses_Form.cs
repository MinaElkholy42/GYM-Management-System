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
    public partial class BudgetAddExpenses_Form : Form
    {
        // make object from the budget options class 
        BudgetOptions_Class bo;
        public BudgetAddExpenses_Form()
        {
            InitializeComponent();
            // initialize the object from the budget options class 
            bo = new BudgetOptions_Class();
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Enter_Button_Click(sender, e);
        }

        private void BudgetAddExpenses_Form_Load(object sender, EventArgs e)
        {
            // make the form animation using the animator 
            Form_Animation.SetAnimateWindow(this);
            // on the load make the focus and the select on the expenses text box 
            Expenses_TextBox.Focus();
            Expenses_TextBox.Select();
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

        private void Expenses_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (Expenses_TextBox.Text == "Enter The Expenses") // remove the place holder
                Expenses_TextBox.Text = string.Empty;
        }

        private void Expenses_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (Expenses_TextBox.Text.Trim(bo.tcs) == string.Empty) // put the place holder back 
                Expenses_TextBox.Text = "Enter The Expenses";
        }

        private void Text_TextBox_Enter(object sender, EventArgs e)
        {
            // if the place holder in the text box 
            if (Text_TextBox.Text == "Enter The Expenses Direction") // remove the place holder
                Text_TextBox.Text = string.Empty;
        }

        private void Text_TextBox_Leave(object sender, EventArgs e)
        {
            // if the text box is empty 
            if (Text_TextBox.Text.Trim(bo.tcs) == string.Empty) // put the place holder back 
                Text_TextBox.Text = "Enter The Expenses Direction";
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // take the data 
            string expenses = Expenses_TextBox.Text.Trim(bo.tcs);
            string text = Text_TextBox.Text.Trim(bo.tcs); 

            // check the empty Input
            if (expenses == "" || text == "" || expenses == "Enter The Expenses" || 
                text == "Enter The Expenses Direction")
            {
                // call this function to handle the alerts 
                bo.Handle_Alerts("Data InComplete\nRequired The Expenses Amount\nAnd the Reason Of It", 
                    Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // check the validation of the input 

            // Check the validation of the Entered Expenses 
            else if (!(Regex.IsMatch(expenses, @"^[0-9]+$")))
            {
                // Call This Function to handle the alert 
                bo.Handle_Alerts("Wrong Input\nThe Amount of Expenses\nMust Be A Number With Out Spaces",
                    Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // check the validation of the Entered Text
            else if (!(Regex.IsMatch(text, @"^[a-zA-Z ]+$")))
            {
                // call this function to handle the alerts 
                bo.Handle_Alerts("Wrong Input\nThe Reason Of The Expenses Is A Text\nNo Numbers" +
                    " Or Special Characters" , Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }
            
            // check the length of the text 
            else if (text.Length > 50)
            {
                // call this function to handle the alerts 
                bo.Handle_Alerts("Wrong Input\nThe Reason Of The Expenses Must Be\nLess Than 50 Characters"
                    , Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // this means all things are done so we will move to the add of the money according to the date

            // take the revenues amount 
            int expenses_amount = Convert.ToInt32(expenses);
            // get the current month 
            int month = DateTime.Now.Month;
            // get the current year 
            int year = DateTime.Now.Year;

            // call this function to add the Expenses to the demand table
            bo.Add_Expenses(month, year, expenses_amount);
            // call this function to add the Expenses and the text in the Expenses Table 
            bo.Insert_Expenses(month, year, expenses_amount, text);

            // back to the original 
            Expenses_TextBox.Text = string.Empty;
            Expenses_TextBox.Focus();
            Expenses_TextBox.Select();
            Text_TextBox.Text = "Enter The Expenses Direction";
        }
    }
}
