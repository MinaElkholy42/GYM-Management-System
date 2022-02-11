namespace GYM_Mangment_System
{
    partial class NewControls_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewControls_Form));
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.LogOut_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.manager_name = new System.Windows.Forms.Label();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Settings_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Budget_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Trainee_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Search_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Digital_Timer = new System.Windows.Forms.Timer(this.components);
            this.Time_Label = new System.Windows.Forms.Label();
            this.Seconds_Label = new System.Windows.Forms.Label();
            this.Day_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel.SuspendLayout();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Header_Panel.Controls.Add(this.LogOut_Button);
            this.Header_Panel.Controls.Add(this.Down_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Controls.Add(this.manager_name);
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1250, 54);
            this.Header_Panel.TabIndex = 1;
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.BackColor = System.Drawing.Color.Transparent;
            this.LogOut_Button.CheckedState.Parent = this.LogOut_Button;
            this.LogOut_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.HoverState.Image")));
            this.LogOut_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.LogOut_Button.HoverState.Parent = this.LogOut_Button;
            this.LogOut_Button.Image = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.Image")));
            this.LogOut_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.LogOut_Button.Location = new System.Drawing.Point(1096, 7);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.PressedState.Parent = this.LogOut_Button;
            this.LogOut_Button.Size = new System.Drawing.Size(53, 39);
            this.LogOut_Button.TabIndex = 7;
            this.LogOut_Button.UseTransparentBackground = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // Down_Button
            // 
            this.Down_Button.BackColor = System.Drawing.Color.Transparent;
            this.Down_Button.CheckedState.Parent = this.Down_Button;
            this.Down_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Down_Button.HoverState.Image")));
            this.Down_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Down_Button.HoverState.Parent = this.Down_Button;
            this.Down_Button.Image = ((System.Drawing.Image)(resources.GetObject("Down_Button.Image")));
            this.Down_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Down_Button.Location = new System.Drawing.Point(1142, 7);
            this.Down_Button.Name = "Down_Button";
            this.Down_Button.PressedState.Parent = this.Down_Button;
            this.Down_Button.Size = new System.Drawing.Size(53, 39);
            this.Down_Button.TabIndex = 6;
            this.Down_Button.UseTransparentBackground = true;
            this.Down_Button.Click += new System.EventHandler(this.Down_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.CheckedState.Parent = this.Close_Button;
            this.Close_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.HoverState.Image")));
            this.Close_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Close_Button.HoverState.Parent = this.Close_Button;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Close_Button.Location = new System.Drawing.Point(1192, 7);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.PressedState.Parent = this.Close_Button;
            this.Close_Button.Size = new System.Drawing.Size(53, 39);
            this.Close_Button.TabIndex = 5;
            this.Close_Button.UseTransparentBackground = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // manager_name
            // 
            this.manager_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manager_name.AutoSize = true;
            this.manager_name.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_name.ForeColor = System.Drawing.Color.White;
            this.manager_name.Location = new System.Drawing.Point(12, 2);
            this.manager_name.Name = "manager_name";
            this.manager_name.Size = new System.Drawing.Size(130, 46);
            this.manager_name.TabIndex = 4;
            this.manager_name.Text = "User : ";
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Side_Panel.Controls.Add(this.Settings_Button);
            this.Side_Panel.Controls.Add(this.Budget_Button);
            this.Side_Panel.Controls.Add(this.Trainee_Button);
            this.Side_Panel.Controls.Add(this.Search_Button);
            this.Side_Panel.Controls.Add(this.Logo_PictureBox);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(360, 485);
            this.Side_Panel.TabIndex = 2;
            // 
            // Settings_Button
            // 
            this.Settings_Button.Animated = true;
            this.Settings_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Settings_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Settings_Button.CheckedState.ForeColor = System.Drawing.Color.Silver;
            this.Settings_Button.CheckedState.Parent = this.Settings_Button;
            this.Settings_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_Button.CustomImages.Parent = this.Settings_Button;
            this.Settings_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Settings_Button.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Button.ForeColor = System.Drawing.Color.Silver;
            this.Settings_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Settings_Button.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Settings_Button.HoverState.Parent = this.Settings_Button;
            this.Settings_Button.Image = ((System.Drawing.Image)(resources.GetObject("Settings_Button.Image")));
            this.Settings_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings_Button.ImageSize = new System.Drawing.Size(36, 36);
            this.Settings_Button.Location = new System.Drawing.Point(3, 382);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Settings_Button.PressedDepth = 60;
            this.Settings_Button.ShadowDecoration.Parent = this.Settings_Button;
            this.Settings_Button.Size = new System.Drawing.Size(357, 66);
            this.Settings_Button.TabIndex = 11;
            this.Settings_Button.Text = "Account Settings";
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Budget_Button
            // 
            this.Budget_Button.Animated = true;
            this.Budget_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Budget_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Budget_Button.CheckedState.ForeColor = System.Drawing.Color.Silver;
            this.Budget_Button.CheckedState.Parent = this.Budget_Button;
            this.Budget_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Budget_Button.CustomImages.Parent = this.Budget_Button;
            this.Budget_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Budget_Button.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Budget_Button.ForeColor = System.Drawing.Color.Silver;
            this.Budget_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Budget_Button.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Budget_Button.HoverState.Parent = this.Budget_Button;
            this.Budget_Button.Image = ((System.Drawing.Image)(resources.GetObject("Budget_Button.Image")));
            this.Budget_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Budget_Button.ImageSize = new System.Drawing.Size(36, 36);
            this.Budget_Button.Location = new System.Drawing.Point(3, 310);
            this.Budget_Button.Name = "Budget_Button";
            this.Budget_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Budget_Button.PressedDepth = 60;
            this.Budget_Button.ShadowDecoration.Parent = this.Budget_Button;
            this.Budget_Button.Size = new System.Drawing.Size(357, 66);
            this.Budget_Button.TabIndex = 10;
            this.Budget_Button.Text = "GYM Budget";
            this.Budget_Button.Click += new System.EventHandler(this.Budget_Button_Click);
            // 
            // Trainee_Button
            // 
            this.Trainee_Button.Animated = true;
            this.Trainee_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Trainee_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Trainee_Button.CheckedState.ForeColor = System.Drawing.Color.Silver;
            this.Trainee_Button.CheckedState.Parent = this.Trainee_Button;
            this.Trainee_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trainee_Button.CustomImages.Parent = this.Trainee_Button;
            this.Trainee_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Trainee_Button.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainee_Button.ForeColor = System.Drawing.Color.Silver;
            this.Trainee_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Trainee_Button.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Trainee_Button.HoverState.Parent = this.Trainee_Button;
            this.Trainee_Button.Image = ((System.Drawing.Image)(resources.GetObject("Trainee_Button.Image")));
            this.Trainee_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Trainee_Button.ImageSize = new System.Drawing.Size(36, 36);
            this.Trainee_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Trainee_Button.Location = new System.Drawing.Point(3, 238);
            this.Trainee_Button.Name = "Trainee_Button";
            this.Trainee_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Trainee_Button.PressedDepth = 60;
            this.Trainee_Button.ShadowDecoration.Parent = this.Trainee_Button;
            this.Trainee_Button.Size = new System.Drawing.Size(357, 66);
            this.Trainee_Button.TabIndex = 9;
            this.Trainee_Button.Text = "Trainee Data";
            this.Trainee_Button.Click += new System.EventHandler(this.Trainee_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Animated = true;
            this.Search_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Search_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Search_Button.CheckedState.ForeColor = System.Drawing.Color.Silver;
            this.Search_Button.CheckedState.Parent = this.Search_Button;
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.CustomImages.Parent = this.Search_Button;
            this.Search_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Search_Button.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.ForeColor = System.Drawing.Color.Silver;
            this.Search_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Search_Button.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Search_Button.HoverState.Parent = this.Search_Button;
            this.Search_Button.Image = ((System.Drawing.Image)(resources.GetObject("Search_Button.Image")));
            this.Search_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Search_Button.ImageSize = new System.Drawing.Size(36, 36);
            this.Search_Button.Location = new System.Drawing.Point(3, 166);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Search_Button.PressedDepth = 60;
            this.Search_Button.ShadowDecoration.Parent = this.Search_Button;
            this.Search_Button.Size = new System.Drawing.Size(357, 66);
            this.Search_Button.TabIndex = 8;
            this.Search_Button.Text = "Search Options";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_PictureBox.Image")));
            this.Logo_PictureBox.Location = new System.Drawing.Point(27, 60);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(291, 85);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            this.Logo_PictureBox.Click += new System.EventHandler(this.Logo_PictureBox_Click);
            // 
            // Controls_Elipse
            // 
            this.Controls_Elipse.ElipseRadius = 30;
            this.Controls_Elipse.TargetControl = this;
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // Digital_Timer
            // 
            this.Digital_Timer.Tick += new System.EventHandler(this.Digital_Timer_Tick);
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.ForeColor = System.Drawing.Color.White;
            this.Time_Label.Location = new System.Drawing.Point(304, 10);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(309, 78);
            this.Time_Label.TabIndex = 4;
            this.Time_Label.Text = "22:22 ص";
            // 
            // Seconds_Label
            // 
            this.Seconds_Label.AutoSize = true;
            this.Seconds_Label.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Seconds_Label.Location = new System.Drawing.Point(592, 55);
            this.Seconds_Label.Name = "Seconds_Label";
            this.Seconds_Label.Size = new System.Drawing.Size(65, 43);
            this.Seconds_Label.TabIndex = 5;
            this.Seconds_Label.Text = "22";
            // 
            // Day_Label
            // 
            this.Day_Label.AutoSize = true;
            this.Day_Label.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day_Label.ForeColor = System.Drawing.Color.White;
            this.Day_Label.Location = new System.Drawing.Point(662, 297);
            this.Day_Label.Name = "Day_Label";
            this.Day_Label.Size = new System.Drawing.Size(182, 43);
            this.Day_Label.TabIndex = 6;
            this.Day_Label.Text = "Satuday";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.ForeColor = System.Drawing.Color.White;
            this.Date_Label.Location = new System.Drawing.Point(107, 297);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(348, 43);
            this.Date_Label.TabIndex = 7;
            this.Date_Label.Text = "January 25 2020";
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.Date_Label);
            this.Main_Panel.Controls.Add(this.Day_Label);
            this.Main_Panel.Controls.Add(this.Seconds_Label);
            this.Main_Panel.Controls.Add(this.Time_Label);
            this.Main_Panel.Location = new System.Drawing.Point(360, 54);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(888, 431);
            this.Main_Panel.TabIndex = 3;
            // 
            // NewControls_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1250, 485);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewControls_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewControls_Form_FormClosing);
            this.Load += new System.EventHandler(this.NewControls_Form_Load);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            this.Side_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label manager_name;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private System.Windows.Forms.Timer Digital_Timer;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label Day_Label;
        private System.Windows.Forms.Label Seconds_Label;
        private System.Windows.Forms.Label Time_Label;
        private Guna.UI2.WinForms.Guna2Button Search_Button;
        private Guna.UI2.WinForms.Guna2Button Settings_Button;
        private Guna.UI2.WinForms.Guna2Button Budget_Button;
        private Guna.UI2.WinForms.Guna2Button Trainee_Button;
        private Guna.UI2.WinForms.Guna2ImageButton LogOut_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Down_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Close_Button;
    }
}