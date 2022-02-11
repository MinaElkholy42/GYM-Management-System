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
using System.Data.SqlTypes;
using System.Data.SqlClient;
namespace GYM_Mangment_System
{
    public partial class temp_form : Form
    {
        Main_Functions mf;
        public temp_form()
        {
            InitializeComponent();
            mf = new Main_Functions(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string today = Date_Time_Picker.Value.ToString("dd-MM-yyyy");
            MessageBox.Show(today);
            Date_Time_Picker.Value = */

            // Date_Time_Picker.Value = DateTime.Now.AddDays(1);
        }
    }
}
