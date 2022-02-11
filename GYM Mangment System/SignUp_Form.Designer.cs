namespace GYM_Mangment_System
{
    partial class SignUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Form));
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Back_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimization_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Password_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ConfirmPassword_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SignUp_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Side_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            this.Main_Panel.SuspendLayout();
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
            this.Side_Panel.TabIndex = 0;
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
            // Panel_Drag
            // 
            this.Panel_Drag.Fixed = true;
            this.Panel_Drag.Horizontal = true;
            this.Panel_Drag.TargetControl = this.Header_Panel;
            this.Panel_Drag.Vertical = true;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Controls.Add(this.Back_Button);
            this.Header_Panel.Controls.Add(this.Minimization_Button);
            this.Header_Panel.Controls.Add(this.label1);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Location = new System.Drawing.Point(3, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(738, 67);
            this.Header_Panel.TabIndex = 5;
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Back_Button.ImageActive")));
            this.Back_Button.Location = new System.Drawing.Point(623, 16);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(42, 34);
            this.Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back_Button.TabIndex = 15;
            this.Back_Button.TabStop = false;
            this.Back_Button.Zoom = 10;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Minimization_Button
            // 
            this.Minimization_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Minimization_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.Image")));
            this.Minimization_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.ImageActive")));
            this.Minimization_Button.Location = new System.Drawing.Point(575, 16);
            this.Minimization_Button.Name = "Minimization_Button";
            this.Minimization_Button.Size = new System.Drawing.Size(42, 34);
            this.Minimization_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimization_Button.TabIndex = 2;
            this.Minimization_Button.TabStop = false;
            this.Minimization_Button.Zoom = 10;
            this.Minimization_Button.Click += new System.EventHandler(this.Minimization_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Join The Club";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Close_Button.ImageActive")));
            this.Close_Button.Location = new System.Drawing.Point(671, 16);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 34);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 1;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.ElipseRadius = 100;
            this.Form_Elipse.TargetControl = this;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_TextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Password_TextBox.ForeColor = System.Drawing.Color.White;
            this.Password_TextBox.HintForeColor = System.Drawing.Color.White;
            this.Password_TextBox.HintText = "";
            this.Password_TextBox.isPassword = true;
            this.Password_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Password_TextBox.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.Password_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Password_TextBox.LineThickness = 5;
            this.Password_TextBox.Location = new System.Drawing.Point(302, 347);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(431, 68);
            this.Password_TextBox.TabIndex = 2;
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_TextBox.OnValueChanged += new System.EventHandler(this.Password_TextBox_OnValueChanged);
            this.Password_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Password_TextBox.Leave += new System.EventHandler(this.Password_TextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name : ";
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_TextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UserName_TextBox.ForeColor = System.Drawing.Color.White;
            this.UserName_TextBox.HintForeColor = System.Drawing.Color.White;
            this.UserName_TextBox.HintText = "";
            this.UserName_TextBox.isPassword = false;
            this.UserName_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.UserName_TextBox.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.UserName_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.UserName_TextBox.LineThickness = 5;
            this.UserName_TextBox.Location = new System.Drawing.Point(302, 206);
            this.UserName_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(431, 68);
            this.UserName_TextBox.TabIndex = 1;
            this.UserName_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.UserName_TextBox.Leave += new System.EventHandler(this.UserName_TextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label4.Location = new System.Drawing.Point(4, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label3.Location = new System.Drawing.Point(4, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Name : ";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_TextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name_TextBox.ForeColor = System.Drawing.Color.White;
            this.Name_TextBox.HintForeColor = System.Drawing.Color.White;
            this.Name_TextBox.HintText = "";
            this.Name_TextBox.isPassword = false;
            this.Name_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Name_TextBox.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.Name_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Name_TextBox.LineThickness = 5;
            this.Name_TextBox.Location = new System.Drawing.Point(301, 101);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(431, 68);
            this.Name_TextBox.TabIndex = 0;
            this.Name_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Name_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Name_TextBox.Leave += new System.EventHandler(this.Name_TextBox_Leave);
            // 
            // ConfirmPassword_TextBox
            // 
            this.ConfirmPassword_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassword_TextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ConfirmPassword_TextBox.ForeColor = System.Drawing.Color.White;
            this.ConfirmPassword_TextBox.HintForeColor = System.Drawing.Color.White;
            this.ConfirmPassword_TextBox.HintText = "";
            this.ConfirmPassword_TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConfirmPassword_TextBox.isPassword = true;
            this.ConfirmPassword_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.ConfirmPassword_TextBox.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.ConfirmPassword_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.ConfirmPassword_TextBox.LineThickness = 5;
            this.ConfirmPassword_TextBox.Location = new System.Drawing.Point(301, 460);
            this.ConfirmPassword_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            this.ConfirmPassword_TextBox.Size = new System.Drawing.Size(431, 68);
            this.ConfirmPassword_TextBox.TabIndex = 3;
            this.ConfirmPassword_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ConfirmPassword_TextBox.OnValueChanged += new System.EventHandler(this.ConfirmPassword_TextBox_OnValueChanged);
            this.ConfirmPassword_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.ConfirmPassword_TextBox.Leave += new System.EventHandler(this.ConfirmPassword_TextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label5.Location = new System.Drawing.Point(4, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Pass : ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 59);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(735, 10);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.ActiveBorderThickness = 1;
            this.SignUp_Button.ActiveCornerRadius = 40;
            this.SignUp_Button.ActiveFillColor = System.Drawing.Color.Aqua;
            this.SignUp_Button.ActiveForecolor = System.Drawing.Color.Red;
            this.SignUp_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignUp_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SignUp_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUp_Button.BackgroundImage")));
            this.SignUp_Button.ButtonText = "Sign Up";
            this.SignUp_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_Button.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_Button.ForeColor = System.Drawing.Color.Red;
            this.SignUp_Button.IdleBorderThickness = 1;
            this.SignUp_Button.IdleCornerRadius = 40;
            this.SignUp_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.SignUp_Button.IdleForecolor = System.Drawing.Color.Red;
            this.SignUp_Button.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignUp_Button.Location = new System.Drawing.Point(190, 596);
            this.SignUp_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(340, 64);
            this.SignUp_Button.TabIndex = 4;
            this.SignUp_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            this.SignUp_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.SignUp_Button);
            this.Main_Panel.Controls.Add(this.bunifuSeparator1);
            this.Main_Panel.Controls.Add(this.Header_Panel);
            this.Main_Panel.Controls.Add(this.label5);
            this.Main_Panel.Controls.Add(this.ConfirmPassword_TextBox);
            this.Main_Panel.Controls.Add(this.Name_TextBox);
            this.Main_Panel.Controls.Add(this.label3);
            this.Main_Panel.Controls.Add(this.label4);
            this.Main_Panel.Controls.Add(this.UserName_TextBox);
            this.Main_Panel.Controls.Add(this.label2);
            this.Main_Panel.Controls.Add(this.Password_TextBox);
            this.Main_Panel.Location = new System.Drawing.Point(457, 4);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(741, 696);
            this.Main_Panel.TabIndex = 1;
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1195, 700);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Side_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private Bunifu.Framework.UI.BunifuDragControl Panel_Drag;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private System.Windows.Forms.Panel Header_Panel;
        private Bunifu.Framework.UI.BunifuImageButton Back_Button;
        private Bunifu.Framework.UI.BunifuImageButton Minimization_Button;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
        private System.Windows.Forms.Panel Main_Panel;
        private Bunifu.Framework.UI.BunifuThinButton2 SignUp_Button;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ConfirmPassword_TextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Name_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName_TextBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_TextBox;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
    }
}