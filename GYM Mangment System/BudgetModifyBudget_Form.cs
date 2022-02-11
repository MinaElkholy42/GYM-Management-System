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
    public partial class BudgetModifyBudget_Form : Form
    {
        // make object from the budget options class 
        BudgetOptions_Class bo;
        // make this variable for the destination of the money 
        string destination;
        // make this variable for the operation of the money 
        string operation;
        public BudgetModifyBudget_Form()
        {
            InitializeComponent();
            // intialize the object from the budget options class 
            bo = new BudgetOptions_Class();
            // initialize the variabels of the operation and the destination 
            destination = operation = "";
        }

        private void BudgetModifyBudget_Form_Load(object sender, EventArgs e)
        {
            // on the load of the from make it with the animations using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the check on the revenues button 
            Reveues_Button.Checked = true;
            // make the check of the increament button 
            Increament_Button.Checked = true;
            // make the focus and the select on the money text box 
            Money_TextBox.Focus();
            Money_TextBox.Select();
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
                AddMoney_Button_Click(sender, e);
        }

        private void Money_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place hodler in the text box 
            if (Money_TextBox.Text == "Enter The Amount") // remove the place hodler from the text box 
                Money_TextBox.Text = string.Empty;
        }

        private void Money_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Money_TextBox.Text.Trim(bo.tcs) == string.Empty) // put the place hodler back 
                Money_TextBox.Text = "Enter The Amount";
        }

        private void Reveues_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the button is checked 
            if (Reveues_Button.Checked) // make the destination as the revenues 
                destination = "revenues";
        }

        private void Expenses_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the button is checked 
            if (Expenses_Button.Checked) // make the destination as the Expenses 
                destination = "expensses";
        }

        private void Increament_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the button is checked 
            if (Increament_Button.Checked) // make the Operation as the + Plus
                operation = "+";
        }

        private void Decreament_Button_CheckedChanged(object sender, EventArgs e)
        {
            // in case the button is checked 
            if (Decreament_Button.Checked) // make the Operation as the - Minus 
                operation = "-";
        }

        private void AddMoney_Button_Click(object sender, EventArgs e)
        {
            // take the input 
            string money = Money_TextBox.Text.Trim(bo.tcs); 

            // check the empty input 
            if (money == "" || money == "Enter The Amount")
            {
                // call this function to handle the alert 
                bo.Handle_Alerts("Data InComplete\nRequired The Amount Of Money", 
                    Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }
            
            // check the validation of the moeny 
            else if (!(Regex.IsMatch(money, @"^[0-9]+$")))
            {
                // call this function to handle the alert 
                bo.Handle_Alerts("Wrong Input\nThe Amount Of Money Must Be\nA Number Without Spaces",
                    Main_Functions.AlertType.error, 100);
                // exit the function 
                return;
            }

            // get the money as integer 
            int money_amount = Convert.ToInt32(money);
            // get the current month 
            int month = DateTime.Now.Month;
            // get the current year 
            int year = DateTime.Now.Year;

            // check the validation in case of decreament 
            if (Decreament_Button.Checked)
            {
                // in case the expenses money is checked 
                if (Expenses_Button.Checked && !(bo.Check_Expenses(money_amount, month, year)))
                {
                    // call this function to handle the alert 
                    bo.Handle_Alerts("Wrong Input\nThe Amount Of Entered Money is\nMore Than The " +
                        "Amount Of Expenses",
                        Main_Functions.AlertType.error, 100);
                    // exit the function 
                    return;
                }

                // in case the revenues money is checked 
                else if (Reveues_Button.Checked && !(bo.Check_Revenues(money_amount, month, year)))
                {
                    // call this function to handle the alert 
                    bo.Handle_Alerts("Wrong Input\nThe Amount Of Entered Money is\nMore Than The " +
                        "Amount Of Reveues",
                        Main_Functions.AlertType.error, 100);
                    // exit the function 
                    return;
                }
            }

            // all cases are handled now move to update the direction 
            bo.Update_Modification(month, year, operation, destination, money_amount);

            // back to original 
            Money_TextBox.Text = string.Empty;
            Money_TextBox.Focus();
            Money_TextBox.Select();
        }
    }
}
