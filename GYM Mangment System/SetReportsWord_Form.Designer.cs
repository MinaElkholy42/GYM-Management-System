namespace GYM_Mangment_System
{
    partial class SetReportsWord_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetReportsWord_Form));
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Header_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Header_Label = new System.Windows.Forms.Label();
            this.Minimization_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header_Seprator = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowWord_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Word_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Confirm_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label8 = new System.Windows.Forms.Label();
            this.Side_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Side_Panel.BackgroundImage")));
            this.Side_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Side_Panel.Controls.Add(this.panel1);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(457, 700);
            this.Side_Panel.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(164, 668);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 29);
            this.panel1.TabIndex = 1;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.ElipseRadius = 100;
            this.Form_Elipse.TargetControl = this;
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Controls.Add(this.Header_Label);
            this.Header_Panel.Controls.Add(this.Minimization_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Location = new System.Drawing.Point(455, 1);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.ShadowDecoration.Parent = this.Header_Panel;
            this.Header_Panel.Size = new System.Drawing.Size(742, 54);
            this.Header_Panel.TabIndex = 23;
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header_Label.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Header_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Header_Label.Location = new System.Drawing.Point(4, 8);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(342, 39);
            this.Header_Label.TabIndex = 8;
            this.Header_Label.Text = "Lion GYM System";
            // 
            // Minimization_Button
            // 
            this.Minimization_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Minimization_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.Image")));
            this.Minimization_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.ImageActive")));
            this.Minimization_Button.Location = new System.Drawing.Point(622, 10);
            this.Minimization_Button.Name = "Minimization_Button";
            this.Minimization_Button.Size = new System.Drawing.Size(42, 34);
            this.Minimization_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimization_Button.TabIndex = 4;
            this.Minimization_Button.TabStop = false;
            this.Minimization_Button.Zoom = 10;
            this.Minimization_Button.Click += new System.EventHandler(this.Minimization_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Close_Button.ImageActive")));
            this.Close_Button.Location = new System.Drawing.Point(670, 10);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 34);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 3;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Header_Seprator
            // 
            this.Header_Seprator.BackColor = System.Drawing.Color.Transparent;
            this.Header_Seprator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Header_Seprator.LineThickness = 4;
            this.Header_Seprator.Location = new System.Drawing.Point(458, 54);
            this.Header_Seprator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Header_Seprator.Name = "Header_Seprator";
            this.Header_Seprator.Size = new System.Drawing.Size(736, 10);
            this.Header_Seprator.TabIndex = 24;
            this.Header_Seprator.Transparency = 255;
            this.Header_Seprator.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(521, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "Instructions For the Word Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(615, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 41);
            this.label2.TabIndex = 26;
            this.label2.Text = "Must Contain At Least One :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(463, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 41);
            this.label3.TabIndex = 27;
            this.label3.Text = "1- Capital Letter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(463, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 41);
            this.label4.TabIndex = 28;
            this.label4.Text = "2- Small Letter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(463, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 41);
            this.label5.TabIndex = 29;
            this.label5.Text = "3- Digit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(463, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 41);
            this.label6.TabIndex = 30;
            this.label6.Text = "4- Special Character";
            // 
            // ShowWord_Button
            // 
            this.ShowWord_Button.CheckedState.Parent = this.ShowWord_Button;
            this.ShowWord_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("ShowWord_Button.HoverState.Image")));
            this.ShowWord_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.ShowWord_Button.HoverState.Parent = this.ShowWord_Button;
            this.ShowWord_Button.Image = ((System.Drawing.Image)(resources.GetObject("ShowWord_Button.Image")));
            this.ShowWord_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.ShowWord_Button.Location = new System.Drawing.Point(1069, 551);
            this.ShowWord_Button.Name = "ShowWord_Button";
            this.ShowWord_Button.PressedState.Parent = this.ShowWord_Button;
            this.ShowWord_Button.Size = new System.Drawing.Size(32, 50);
            this.ShowWord_Button.TabIndex = 32;
            this.ShowWord_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowWord_Button_MouseDown);
            this.ShowWord_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowWord_Button_MouseUp);
            // 
            // Word_TextBox
            // 
            this.Word_TextBox.Animated = true;
            this.Word_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Word_TextBox.BorderRadius = 15;
            this.Word_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Word_TextBox.BorderThickness = 2;
            this.Word_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Word_TextBox.DefaultText = "Enter The Word";
            this.Word_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Word_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Word_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Word_TextBox.DisabledState.Parent = this.Word_TextBox;
            this.Word_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Word_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Word_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Word_TextBox.FocusedState.Parent = this.Word_TextBox;
            this.Word_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Word_TextBox.ForeColor = System.Drawing.Color.White;
            this.Word_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Word_TextBox.HoverState.Parent = this.Word_TextBox;
            this.Word_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Word_TextBox.IconLeft")));
            this.Word_TextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Word_TextBox.Location = new System.Drawing.Point(547, 545);
            this.Word_TextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.Word_TextBox.Name = "Word_TextBox";
            this.Word_TextBox.PasswordChar = '\0';
            this.Word_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Word_TextBox.PlaceholderText = "";
            this.Word_TextBox.SelectedText = "";
            this.Word_TextBox.SelectionStart = 14;
            this.Word_TextBox.ShadowDecoration.Parent = this.Word_TextBox;
            this.Word_TextBox.Size = new System.Drawing.Size(515, 62);
            this.Word_TextBox.TabIndex = 31;
            this.Word_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Word_TextBox.Enter += new System.EventHandler(this.Word_TextBox_Enter);
            this.Word_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Word_TextBox.Leave += new System.EventHandler(this.Word_TextBox_Leave);
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Animated = true;
            this.Confirm_Button.AutoRoundedCorners = true;
            this.Confirm_Button.BorderRadius = 32;
            this.Confirm_Button.CheckedState.Parent = this.Confirm_Button;
            this.Confirm_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_Button.CustomImages.Parent = this.Confirm_Button;
            this.Confirm_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Confirm_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirm_Button.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Confirm_Button.ForeColor = System.Drawing.Color.White;
            this.Confirm_Button.HoverState.Parent = this.Confirm_Button;
            this.Confirm_Button.Location = new System.Drawing.Point(547, 623);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.PressedColor = System.Drawing.Color.Maroon;
            this.Confirm_Button.PressedDepth = 150;
            this.Confirm_Button.ShadowDecoration.BorderRadius = 26;
            this.Confirm_Button.ShadowDecoration.Parent = this.Confirm_Button;
            this.Confirm_Button.Size = new System.Drawing.Size(554, 67);
            this.Confirm_Button.TabIndex = 33;
            this.Confirm_Button.Text = "Confirm Word";
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label7.Location = new System.Drawing.Point(548, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(539, 41);
            this.label7.TabIndex = 34;
            this.label7.Text = "Must Be 8 Characters Length Or More";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(528, 125);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(605, 10);
            this.bunifuSeparator1.TabIndex = 35;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label8.Location = new System.Drawing.Point(626, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(358, 41);
            this.label8.TabIndex = 60;
            this.label8.Text = "Must Be With No Spaces";
            // 
            // SetReportsWord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1195, 700);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.ShowWord_Button);
            this.Controls.Add(this.Word_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header_Seprator);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetReportsWord_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Reports Word";
            this.Load += new System.EventHandler(this.SetReportsWord_Form_Load);
            this.Side_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Guna.UI2.WinForms.Guna2Panel Header_Panel;
        private Bunifu.Framework.UI.BunifuImageButton Minimization_Button;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
        private System.Windows.Forms.Label Header_Label;
        private Bunifu.Framework.UI.BunifuSeparator Header_Seprator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton ShowWord_Button;
        private Guna.UI2.WinForms.Guna2TextBox Word_TextBox;
        private Guna.UI2.WinForms.Guna2GradientButton Confirm_Button;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label8;
    }
}