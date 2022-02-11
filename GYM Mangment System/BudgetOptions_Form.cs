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
    public partial class BudgetOptions_Form : Form
    {
        // make object form the main functions class
        Main_Functions mf;
        public BudgetOptions_Form()
        {
            InitializeComponent();
            // intialize the object from the main functions class
            mf = new Main_Functions();
        }

        private void BudgetOptions_Form_Load(object sender, EventArgs e)
        {
            // make the pop up note for the add revenues button 
            AddRevenues_Tip.SetToolTip(AddRevenuse_Button, "المالى العائد إضافه");
            // make the pop up note for the modify Budget button
            ModifyBudge_Tip.SetToolTip(ModifyBudget_Button, "الميزانيه مدخلات تعديل");
            // make the pop up note for the Full Report button
            FullReport_Tip.SetToolTip(FullReport_Button, "الميزانيه تقرير عرض");
            // make the pop up note for the add exepenses button
            AddExpenses_Tip.SetToolTip(AddExpenses_Button, "المستهلكه القيمه إضافه");
            // make the pop up note for the add exepenses reprot button
            ExpenssesReprot_Tip.SetToolTip(ExpenssesReprot_Button, "الاستهلاك تقرير عرض");
        }

        private void AddRevenuse_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("BudgetAddRevenues_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                BudgetAddRevenues_Form BA = new BudgetAddRevenues_Form();
                // show the form we want to use 
                BA.Show();
                // make the new form on the top 
                BA.TopLevel = true;
            }
        }

        private void ModifyBudget_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("BudgetModifyBudget_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                BudgetModifyBudget_Form BM = new BudgetModifyBudget_Form();
                // show the form we want to use 
                BM.Show();
                // make the new form on the top 
                BM.TopLevel = true;
            }
        }

        private void FullReport_Button_Click(object sender, EventArgs e)
        {
            // make two flags one to indicate the Enter Word form and the other for the main form
            bool is_open_mainform = false, is_open_wordform = false;
            // call this function one for the mainfrom and the other for the word form 
            mf.FormIsOpen("EnterReprotWord_Form", ref is_open_wordform);
            mf.FormIsOpen("BudgetFullReport_Form", ref is_open_mainform);
            // if the word form is not opened and the main form is not opened 
            if (!is_open_mainform && !is_open_wordform)
            {
                // make object from the form we want to open 
                BudgetFullReport_Form rt = new BudgetFullReport_Form();
                // make object from the Enter Word Form and send the form we want to open
                EnterReprotWord_Form erw = new EnterReprotWord_Form(rt);
                // show the Enter Word form 
                erw.Show();
                // make the form on the top level
                erw.TopLevel = true;
            }
        }

        private void AddExpenses_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("BudgetAddExpenses_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                BudgetAddExpenses_Form BA = new BudgetAddExpenses_Form();
                // show the form we want to use 
                BA.Show();
                // make the new form on the top 
                BA.TopLevel = true;
            }
        }

        private void ExpenssesReprot_Button_Click(object sender, EventArgs e)
        {
            // make two flags one to indicate the Enter Word form and the other for the main form
            bool is_open_mainform = false, is_open_wordform = false;
            // call this function one for the mainfrom and the other for the word form 
            mf.FormIsOpen("EnterReprotWord_Form", ref is_open_wordform);
            mf.FormIsOpen("BudgetExpensesReport_Form", ref is_open_mainform);
            // if the word form is not opened and the main form is not opened 
            if (!is_open_mainform && !is_open_wordform)
            {
                // make object from the form we want to open 
                BudgetExpensesReport_Form rt = new BudgetExpensesReport_Form();
                // make object from the Enter Word Form and send the form we want to open
                EnterReprotWord_Form erw = new EnterReprotWord_Form(rt);
                // show the Enter Word form 
                erw.Show();
                // make the form on the top level
                erw.TopLevel = true;
            }
        }
    }
}
