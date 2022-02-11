using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace GYM_Mangment_System
{
    public partial class Loading_Form : Form
    {
        // make the class for the loading form 
        Loading_Class lc;

        public Loading_Form()
        {
            InitializeComponent();
            // make the reference for the object 
            lc = new Loading_Class();
        }

        private void Media_Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // if the media player video reach the end of the video then 
            if (Media_Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // hide the current form 
                this.Hide();
                // make object from the next form
                Loading2_Form lf = new Loading2_Form();
                // show the next form 
                lf.Show();
            }
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {

            // make the window state in the full screen mode 
            this.WindowState = FormWindowState.Maximized;
            // call this fucntion to handle the budget of the year 
            lc.handle_budget();

            // assign the name of the video file 
            string video_name = "Lion_3.mp4";
            // check if the video exists or not 
            if (!File.Exists(video_name)) // in case the file not exists so make it in the base directory
            {

                // make a file stream of the array or bytes of the video s
                Stream video_file = new FileStream(video_name, FileMode.Create);
                // make the binary reader to the directory of the stream 
                BinaryWriter video_binaryreader = new BinaryWriter(video_file);
                // write to the directory of the resources video with the binary reader
                video_binaryreader.Write(Properties.Resources.Lion_3);
                // close the stream of the video 
                video_file.Close();
                // close the binary reader
                video_binaryreader.Close();
            }

            // make the path of the media player using the url property
            Media_Player.URL = video_name;
            // play the video using the ctl controls
            Media_Player.Ctlcontrols.play();
        }
    }
}
