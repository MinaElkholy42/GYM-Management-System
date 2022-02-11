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
    public partial class TraineeOptions_Form : Form
    {
        // make object form the main functions class
        Main_Functions mf;
        public TraineeOptions_Form()
        {
            InitializeComponent();
            // intialize the object from the main functions class
            mf = new Main_Functions();
        }

        private void TraineeOptions_Form_Load(object sender, EventArgs e)
        {
            // set the Add button tip 
            AddButton_Tip.SetToolTip(InsertTrainee_Button, "جديد متمرن إضافه");
            // set the Renewal button tip 
            RenewalButton_Tip.SetToolTip(RenewalTrainee_Button, "متمرن إشتراك تجديد");
            // set the Delete button tip 
            DeleteButton_Tip.SetToolTip(DeleteTrainee_Button, "متمرن مسح");
            // set the Update button tip 
            UpdateButton_Tip.SetToolTip(UpdateTrainee_Button, "متمرن معلومات تعديل");
        }

        private void InsertTrainee_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("TraineeInsert_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                TraineeInsert_Form TI = new TraineeInsert_Form();
                // show the form we want to use 
                TI.Show();
                // make the new form on the top 
                TI.TopLevel = true;
            }
        }

        private void RenewalTrainee_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("TraineeRenewal_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                TraineeRenewal_Form TR = new TraineeRenewal_Form();
                // show the form we want to use 
                TR.Show();
                // make the new form on the top 
                TR.TopLevel = true;
            }
        }

        private void DeleteTrainee_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("TraineeDelete_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                TraineeDelete_Form TD = new TraineeDelete_Form();
                // show the form we want to use 
                TD.Show();
                // make the new form on the top 
                TD.TopLevel = true;
            }
        }

        private void UpdateTrainee_Button_Click(object sender, EventArgs e)
        {
            // make this flag to indicate weather the form is opened or not 
            bool is_open = false;
            // call this function to check if the form is opened or not 
            mf.FormIsOpen("TraineeUpdate_Form", ref is_open);
            // in case the form is not open 
            if (!is_open)
            {
                // make object form the form we want to open 
                TraineeUpdate_Form TU = new TraineeUpdate_Form();
                // show the form we want to use 
                TU.Show();
                // make the new form on the top 
                TU.TopLevel = true;
            }
        }
    }
}
