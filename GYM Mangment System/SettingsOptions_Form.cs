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
    public partial class SettingsOptions_Form : Form
    {
        // make object from the mainfunctions 
        Main_Functions mf;
        public SettingsOptions_Form()
        {
            InitializeComponent();
            // make a new reference for the main functions object 
            mf = new Main_Functions();
        }

        private void SettingsOptions_Form_Load(object sender, EventArgs e)
        {
            // set the tip for the word button  
            WordButton_Tip.SetToolTip(WordSettings_Button, "للتقارير المرور كلمه تغير");
            // set the tip for the user name button 
            UserNameButton_Tip.SetToolTip(UserNameSetting_Button, "المستخدم اسم تغير");
            // set the tip for the password button 
            PasswordButton_Tip.SetToolTip(PasswordSetting_Button, "المرور كلمه تغير");
        }

        private void PasswordSetting_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("PasswordChange_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                PasswordChange_Form pc = new PasswordChange_Form();
                // show the form we want to use 
                pc.Show();
                // make the new form on the top 
                pc.TopLevel = true;
            }
        }

        private void WordSettings_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("ReportsWordChange_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                ReportsWordChange_Form rw = new ReportsWordChange_Form();
                // show the form we want to use 
                rw.Show();
                // make the new form on the top 
                rw.TopLevel = true;
            }
        }

        private void UserNameSetting_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("UserNameChange_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                UserNameChange_Form uc = new UserNameChange_Form();
                // show the form we want to use 
                uc.Show();
                // make the new form on the top 
                uc.TopLevel = true;
            }
        }
    }
}
