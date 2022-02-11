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
    public partial class SearchOptions_Form : Form
    {
        // make object from the mainfunctions 
        Main_Functions mf;
        public SearchOptions_Form()
        {
            InitializeComponent();
            // make a new reference for the main functions object 
            mf = new Main_Functions();
        }

        private void SearchOptions_Form_Load(object sender, EventArgs e)
        {
            // set the tip for the full Report Button
            FullReportButton_Tip.SetToolTip(FullReprot_Button,
                "للمتمرنين الهامه بالتفاصيل الريبورتات عرض");
            // set the tip for the ID Card Search Button
            IDCardButton_Tip.SetToolTip(IDSearch_Button,
                "الكود بأستخدام المتمرن تفاصيل عرض");
            // set the tip for the Phone Number Search Button
            PhoneNumberButton_Tip.SetToolTip(PhoneSearch_Button,
                "الموبيل رقم بأستخدام المتمرن تفاصيل عرض");
        }

        private void FullReprot_Button_Click(object sender, EventArgs e)
        {
            // make two flags one to indicate the Enter Word form and the other for the main form
            bool is_open_mainform = false, is_open_wordform = false;
            // call this function one for the mainfrom and the other for the word form 
            mf.FormIsOpen("EnterReprotWord_Form", ref is_open_wordform);
            mf.FormIsOpen("ReportTrainees_Form", ref is_open_mainform);
            // if the word form is not opened and the main form is not opened 
            if (!is_open_mainform && !is_open_wordform)
            {
                // make object from the form we want to open 
                ReportTrainees_Form rt = new ReportTrainees_Form();
                // make object from the Enter Word Form and send the form we want to open
                EnterReprotWord_Form erw = new EnterReprotWord_Form(rt);
                // show the Enter Word form 
                erw.Show();
                // make the form on the top level
                erw.TopLevel = true;
            }
        }

        private void IDSearch_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("SearchIDCard_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                SearchIDCard_Form IF = new SearchIDCard_Form();
                // show the form we want to use 
                IF.Show();
                // make the new form on the top 
                IF.TopLevel = true;
            }
        }

        private void PhoneSearch_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("SearchPhoneNumber_Formcs", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                SearchPhoneNumber_Formcs PF = new SearchPhoneNumber_Formcs();
                // show the form we want to use 
                PF.Show();
                // make the new form on the top 
                PF.TopLevel = true;
            }
        }
    }
}
