namespace GYM_Mangment_System
{
    partial class temp_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Date_Time_Picker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date_Time_Picker
            // 
            this.Date_Time_Picker.BackColor = System.Drawing.Color.Transparent;
            this.Date_Time_Picker.BaseColor = System.Drawing.Color.SteelBlue;
            this.Date_Time_Picker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Date_Time_Picker.BorderSize = 0;
            this.Date_Time_Picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Date_Time_Picker.CustomFormat = null;
            this.Date_Time_Picker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Date_Time_Picker.FocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Date_Time_Picker.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Date_Time_Picker.ForeColor = System.Drawing.Color.White;
            this.Date_Time_Picker.Location = new System.Drawing.Point(430, 143);
            this.Date_Time_Picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_Time_Picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_Time_Picker.Name = "Date_Time_Picker";
            this.Date_Time_Picker.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.Date_Time_Picker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Date_Time_Picker.OnHoverForeColor = System.Drawing.Color.White;
            this.Date_Time_Picker.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Date_Time_Picker.OnPressedDepth = 60;
            this.Date_Time_Picker.Radius = 15;
            this.Date_Time_Picker.Size = new System.Drawing.Size(524, 62);
            this.Date_Time_Picker.TabIndex = 31;
            this.Date_Time_Picker.Text = "Friday, January 14, 2022";
            this.Date_Time_Picker.Value = new System.DateTime(2022, 1, 14, 21, 45, 29, 52);
            // 
            // temp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 372);
            this.Controls.Add(this.Date_Time_Picker);
            this.Controls.Add(this.button1);
            this.Name = "temp_form";
            this.Text = "temp_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaDateTimePicker Date_Time_Picker;
    }
}