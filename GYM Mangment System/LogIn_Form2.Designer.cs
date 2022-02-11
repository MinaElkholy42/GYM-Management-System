namespace GYM_Mangment_System
{
    partial class LogIn_Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form2));
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Header_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimization_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registration_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Recover_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LogIn_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Remember_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowPassword_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Password_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserName_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Header_Seprator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Header_Label = new System.Windows.Forms.Label();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            this.Side_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.ElipseRadius = 100;
            this.Form_Elipse.TargetControl = this;
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Controls.Add(this.Minimization_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Location = new System.Drawing.Point(455, 1);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.ShadowDecoration.Parent = this.Header_Panel;
            this.Header_Panel.Size = new System.Drawing.Size(742, 54);
            this.Header_Panel.TabIndex = 19;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(460, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "No Account ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(460, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Forget Your Data ?";
            // 
            // Registration_Button
            // 
            this.Registration_Button.Animated = true;
            this.Registration_Button.AutoRoundedCorners = true;
            this.Registration_Button.BorderRadius = 26;
            this.Registration_Button.CheckedState.Parent = this.Registration_Button;
            this.Registration_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration_Button.CustomImages.Parent = this.Registration_Button;
            this.Registration_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Registration_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Registration_Button.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Registration_Button.ForeColor = System.Drawing.Color.White;
            this.Registration_Button.HoverState.Parent = this.Registration_Button;
            this.Registration_Button.Location = new System.Drawing.Point(904, 496);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.PressedColor = System.Drawing.Color.Maroon;
            this.Registration_Button.PressedDepth = 150;
            this.Registration_Button.ShadowDecoration.BorderRadius = 26;
            this.Registration_Button.ShadowDecoration.Parent = this.Registration_Button;
            this.Registration_Button.Size = new System.Drawing.Size(283, 54);
            this.Registration_Button.TabIndex = 3;
            this.Registration_Button.Text = "Register Now";
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // Recover_Button
            // 
            this.Recover_Button.Animated = true;
            this.Recover_Button.AutoRoundedCorners = true;
            this.Recover_Button.BorderRadius = 26;
            this.Recover_Button.CheckedState.Parent = this.Recover_Button;
            this.Recover_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recover_Button.CustomImages.Parent = this.Recover_Button;
            this.Recover_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Recover_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Recover_Button.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Recover_Button.ForeColor = System.Drawing.Color.White;
            this.Recover_Button.HoverState.Parent = this.Recover_Button;
            this.Recover_Button.Location = new System.Drawing.Point(904, 586);
            this.Recover_Button.Name = "Recover_Button";
            this.Recover_Button.PressedColor = System.Drawing.Color.Maroon;
            this.Recover_Button.PressedDepth = 150;
            this.Recover_Button.ShadowDecoration.BorderRadius = 26;
            this.Recover_Button.ShadowDecoration.Parent = this.Recover_Button;
            this.Recover_Button.Size = new System.Drawing.Size(283, 54);
            this.Recover_Button.TabIndex = 4;
            this.Recover_Button.Text = "Recover Now";
            this.Recover_Button.Click += new System.EventHandler(this.Recover_Button_Click);
            // 
            // LogIn_Button
            // 
            this.LogIn_Button.Animated = true;
            this.LogIn_Button.AutoRoundedCorners = true;
            this.LogIn_Button.BorderRadius = 26;
            this.LogIn_Button.CheckedState.Parent = this.LogIn_Button;
            this.LogIn_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn_Button.CustomImages.Parent = this.LogIn_Button;
            this.LogIn_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.LogIn_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogIn_Button.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LogIn_Button.ForeColor = System.Drawing.Color.White;
            this.LogIn_Button.HoverState.Parent = this.LogIn_Button;
            this.LogIn_Button.Location = new System.Drawing.Point(546, 399);
            this.LogIn_Button.Name = "LogIn_Button";
            this.LogIn_Button.PressedColor = System.Drawing.Color.Maroon;
            this.LogIn_Button.PressedDepth = 150;
            this.LogIn_Button.ShadowDecoration.BorderRadius = 26;
            this.LogIn_Button.ShadowDecoration.Parent = this.LogIn_Button;
            this.LogIn_Button.Size = new System.Drawing.Size(554, 54);
            this.LogIn_Button.TabIndex = 2;
            this.LogIn_Button.Text = "Log In";
            this.LogIn_Button.Click += new System.EventHandler(this.LogIn_Button_Click);
            // 
            // Remember_Switch
            // 
            this.Remember_Switch.Animated = true;
            this.Remember_Switch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Remember_Switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Remember_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Remember_Switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Remember_Switch.CheckedState.Parent = this.Remember_Switch;
            this.Remember_Switch.Location = new System.Drawing.Point(618, 332);
            this.Remember_Switch.Name = "Remember_Switch";
            this.Remember_Switch.ShadowDecoration.Parent = this.Remember_Switch;
            this.Remember_Switch.Size = new System.Drawing.Size(57, 26);
            this.Remember_Switch.TabIndex = 6;
            this.Remember_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Remember_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Remember_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Remember_Switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Remember_Switch.UncheckedState.Parent = this.Remember_Switch;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label5.Location = new System.Drawing.Point(704, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Remeber Me";
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
            this.Side_Panel.TabIndex = 21;
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
            // ShowPassword_Button
            // 
            this.ShowPassword_Button.CheckedState.Parent = this.ShowPassword_Button;
            this.ShowPassword_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassword_Button.HoverState.Image")));
            this.ShowPassword_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.ShowPassword_Button.HoverState.Parent = this.ShowPassword_Button;
            this.ShowPassword_Button.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassword_Button.Image")));
            this.ShowPassword_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.ShowPassword_Button.Location = new System.Drawing.Point(1068, 214);
            this.ShowPassword_Button.Name = "ShowPassword_Button";
            this.ShowPassword_Button.PressedState.Parent = this.ShowPassword_Button;
            this.ShowPassword_Button.Size = new System.Drawing.Size(32, 50);
            this.ShowPassword_Button.TabIndex = 5;
            this.ShowPassword_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_Button_MouseDown);
            this.ShowPassword_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_Button_MouseUp);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Animated = true;
            this.Password_TextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Password_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Password_TextBox.BorderRadius = 15;
            this.Password_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Password_TextBox.BorderThickness = 2;
            this.Password_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_TextBox.DefaultText = "Enter The Password";
            this.Password_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Password_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Password_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Password_TextBox.DisabledState.Parent = this.Password_TextBox;
            this.Password_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Password_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Password_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Password_TextBox.FocusedState.Parent = this.Password_TextBox;
            this.Password_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Password_TextBox.ForeColor = System.Drawing.Color.White;
            this.Password_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Password_TextBox.HoverState.Parent = this.Password_TextBox;
            this.Password_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password_TextBox.IconLeft")));
            this.Password_TextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Password_TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Password_TextBox.Location = new System.Drawing.Point(546, 208);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '\0';
            this.Password_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password_TextBox.PlaceholderText = "";
            this.Password_TextBox.SelectedText = "";
            this.Password_TextBox.SelectionStart = 18;
            this.Password_TextBox.ShadowDecoration.Parent = this.Password_TextBox;
            this.Password_TextBox.Size = new System.Drawing.Size(515, 62);
            this.Password_TextBox.TabIndex = 1;
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_TextBox.Enter += new System.EventHandler(this.Password_TextBox_Enter);
            this.Password_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Password_TextBox.Leave += new System.EventHandler(this.Password_TextBox_Leave);
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Animated = true;
            this.UserName_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.UserName_TextBox.BorderRadius = 15;
            this.UserName_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.UserName_TextBox.BorderThickness = 2;
            this.UserName_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_TextBox.DefaultText = "Enter The UserName";
            this.UserName_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.UserName_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserName_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserName_TextBox.DisabledState.Parent = this.UserName_TextBox;
            this.UserName_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserName_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UserName_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.UserName_TextBox.FocusedState.Parent = this.UserName_TextBox;
            this.UserName_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UserName_TextBox.ForeColor = System.Drawing.Color.White;
            this.UserName_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.UserName_TextBox.HoverState.Parent = this.UserName_TextBox;
            this.UserName_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("UserName_TextBox.IconLeft")));
            this.UserName_TextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.UserName_TextBox.Location = new System.Drawing.Point(546, 107);
            this.UserName_TextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.PasswordChar = '\0';
            this.UserName_TextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.UserName_TextBox.PlaceholderText = "";
            this.UserName_TextBox.SelectedText = "";
            this.UserName_TextBox.SelectionStart = 18;
            this.UserName_TextBox.ShadowDecoration.Parent = this.UserName_TextBox;
            this.UserName_TextBox.Size = new System.Drawing.Size(515, 62);
            this.UserName_TextBox.TabIndex = 0;
            this.UserName_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName_TextBox.Enter += new System.EventHandler(this.UserName_TextBox_Enter);
            this.UserName_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.UserName_TextBox.Leave += new System.EventHandler(this.UserName_TextBox_Leave);
            // 
            // Header_Seprator
            // 
            this.Header_Seprator.BackColor = System.Drawing.Color.Transparent;
            this.Header_Seprator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Header_Seprator.LineThickness = 4;
            this.Header_Seprator.Location = new System.Drawing.Point(416, 54);
            this.Header_Seprator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Header_Seprator.Name = "Header_Seprator";
            this.Header_Seprator.Size = new System.Drawing.Size(778, 10);
            this.Header_Seprator.TabIndex = 20;
            this.Header_Seprator.Transparency = 255;
            this.Header_Seprator.Vertical = false;
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header_Label.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Header_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Header_Label.Location = new System.Drawing.Point(459, 9);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(342, 39);
            this.Header_Label.TabIndex = 7;
            this.Header_Label.Text = "Lion GYM System";
            // 
            // LogIn_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1195, 700);
            this.Controls.Add(this.Side_Panel);
            this.Controls.Add(this.Header_Label);
            this.Controls.Add(this.Header_Seprator);
            this.Controls.Add(this.ShowPassword_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Remember_Switch);
            this.Controls.Add(this.LogIn_Button);
            this.Controls.Add(this.Recover_Button);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn_Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            this.Side_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Guna.UI2.WinForms.Guna2TextBox UserName_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox Password_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton Registration_Button;
        private Guna.UI2.WinForms.Guna2GradientButton LogIn_Button;
        private Guna.UI2.WinForms.Guna2GradientButton Recover_Button;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Remember_Switch;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton ShowPassword_Button;
        private Guna.UI2.WinForms.Guna2Panel Header_Panel;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Header_Label;
        private Bunifu.Framework.UI.BunifuSeparator Header_Seprator;
        private Bunifu.Framework.UI.BunifuImageButton Minimization_Button;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
    }
}