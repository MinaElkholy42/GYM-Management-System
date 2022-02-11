namespace GYM_Mangment_System
{
    partial class UserNameChange_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNameChange_Form));
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Change_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NewUserName_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.OldUserName_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Header_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Animation
            // 
            this.Form_Animation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Form_Animation.Interval = 300;
            // 
            // Controls_Elipse
            // 
            this.Controls_Elipse.ElipseRadius = 30;
            this.Controls_Elipse.TargetControl = this;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Header_Panel.Controls.Add(this.guna2HtmlLabel2);
            this.Header_Panel.Controls.Add(this.guna2HtmlLabel1);
            this.Header_Panel.Controls.Add(this.Down_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Location = new System.Drawing.Point(1, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1100, 54);
            this.Header_Panel.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(444, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(376, 48);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Change Account User Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(7, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(265, 48);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Lion GYM System";
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
            this.Down_Button.Location = new System.Drawing.Point(993, 6);
            this.Down_Button.Name = "Down_Button";
            this.Down_Button.PressedState.Parent = this.Down_Button;
            this.Down_Button.Size = new System.Drawing.Size(53, 39);
            this.Down_Button.TabIndex = 1;
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
            this.Close_Button.Location = new System.Drawing.Point(1043, 6);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.PressedState.Parent = this.Close_Button;
            this.Close_Button.Size = new System.Drawing.Size(53, 39);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.UseTransparentBackground = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(251, 126);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(703, 10);
            this.bunifuSeparator1.TabIndex = 51;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label7.Location = new System.Drawing.Point(244, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(689, 41);
            this.label7.TabIndex = 50;
            this.label7.Text = "Must Be With Out Any Special Characters Only :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(244, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 41);
            this.label2.TabIndex = 45;
            this.label2.Text = "Must Begin With Alphabet Letter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 40);
            this.label1.TabIndex = 44;
            this.label1.Text = "Instructions For the User Name Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(244, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 41);
            this.label5.TabIndex = 54;
            this.label5.Text = "3- Under Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(244, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 41);
            this.label4.TabIndex = 53;
            this.label4.Text = "2- Digits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(244, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 41);
            this.label3.TabIndex = 52;
            this.label3.Text = "1- Alphabet Letters";
            // 
            // Change_Button
            // 
            this.Change_Button.Animated = true;
            this.Change_Button.BorderRadius = 26;
            this.Change_Button.CheckedState.Parent = this.Change_Button;
            this.Change_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change_Button.CustomImages.Parent = this.Change_Button;
            this.Change_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Change_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.Change_Button.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Button.ForeColor = System.Drawing.Color.White;
            this.Change_Button.HoverState.Parent = this.Change_Button;
            this.Change_Button.Location = new System.Drawing.Point(246, 794);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Change_Button.PressedDepth = 60;
            this.Change_Button.ShadowDecoration.Parent = this.Change_Button;
            this.Change_Button.Size = new System.Drawing.Size(575, 67);
            this.Change_Button.TabIndex = 57;
            this.Change_Button.Text = "Change Account User Name";
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // NewUserName_TextBox
            // 
            this.NewUserName_TextBox.Animated = true;
            this.NewUserName_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.NewUserName_TextBox.BorderRadius = 15;
            this.NewUserName_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.NewUserName_TextBox.BorderThickness = 2;
            this.NewUserName_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewUserName_TextBox.DefaultText = "Enter The New UserName";
            this.NewUserName_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.NewUserName_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NewUserName_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NewUserName_TextBox.DisabledState.Parent = this.NewUserName_TextBox;
            this.NewUserName_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NewUserName_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.NewUserName_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.NewUserName_TextBox.FocusedState.Parent = this.NewUserName_TextBox;
            this.NewUserName_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NewUserName_TextBox.ForeColor = System.Drawing.Color.White;
            this.NewUserName_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.NewUserName_TextBox.HoverState.Parent = this.NewUserName_TextBox;
            this.NewUserName_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("NewUserName_TextBox.IconLeft")));
            this.NewUserName_TextBox.IconLeftSize = new System.Drawing.Size(40, 40);
            this.NewUserName_TextBox.Location = new System.Drawing.Point(251, 696);
            this.NewUserName_TextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.NewUserName_TextBox.Name = "NewUserName_TextBox";
            this.NewUserName_TextBox.PasswordChar = '\0';
            this.NewUserName_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NewUserName_TextBox.PlaceholderText = "";
            this.NewUserName_TextBox.SelectedText = "";
            this.NewUserName_TextBox.SelectionStart = 22;
            this.NewUserName_TextBox.ShadowDecoration.Parent = this.NewUserName_TextBox;
            this.NewUserName_TextBox.Size = new System.Drawing.Size(570, 62);
            this.NewUserName_TextBox.TabIndex = 56;
            this.NewUserName_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewUserName_TextBox.Enter += new System.EventHandler(this.NewUserName_TextBox_Enter);
            this.NewUserName_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.NewUserName_TextBox.Leave += new System.EventHandler(this.NewUserName_TextBox_Leave);
            // 
            // OldUserName_TextBox
            // 
            this.OldUserName_TextBox.Animated = true;
            this.OldUserName_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.OldUserName_TextBox.BorderRadius = 15;
            this.OldUserName_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.OldUserName_TextBox.BorderThickness = 2;
            this.OldUserName_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OldUserName_TextBox.DefaultText = "Enter The Old UserName";
            this.OldUserName_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.OldUserName_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OldUserName_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OldUserName_TextBox.DisabledState.Parent = this.OldUserName_TextBox;
            this.OldUserName_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OldUserName_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.OldUserName_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.OldUserName_TextBox.FocusedState.Parent = this.OldUserName_TextBox;
            this.OldUserName_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OldUserName_TextBox.ForeColor = System.Drawing.Color.White;
            this.OldUserName_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.OldUserName_TextBox.HoverState.Parent = this.OldUserName_TextBox;
            this.OldUserName_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("OldUserName_TextBox.IconLeft")));
            this.OldUserName_TextBox.IconLeftSize = new System.Drawing.Size(40, 40);
            this.OldUserName_TextBox.Location = new System.Drawing.Point(251, 594);
            this.OldUserName_TextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.OldUserName_TextBox.Name = "OldUserName_TextBox";
            this.OldUserName_TextBox.PasswordChar = '\0';
            this.OldUserName_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.OldUserName_TextBox.PlaceholderText = "";
            this.OldUserName_TextBox.SelectedText = "";
            this.OldUserName_TextBox.SelectionStart = 22;
            this.OldUserName_TextBox.ShadowDecoration.Parent = this.OldUserName_TextBox;
            this.OldUserName_TextBox.Size = new System.Drawing.Size(570, 62);
            this.OldUserName_TextBox.TabIndex = 55;
            this.OldUserName_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OldUserName_TextBox.Enter += new System.EventHandler(this.OldUserName_TextBox_Enter);
            this.OldUserName_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.OldUserName_TextBox.Leave += new System.EventHandler(this.OldUserName_TextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label6.Location = new System.Drawing.Point(244, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 41);
            this.label6.TabIndex = 58;
            this.label6.Text = "Must Be With No Spaces";
            // 
            // UserNameChange_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1100, 900);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.NewUserName_TextBox);
            this.Controls.Add(this.OldUserName_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserNameChange_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Account UserName";
            this.Load += new System.EventHandler(this.UserNameChange_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Header_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private System.Windows.Forms.Panel Header_Panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton Down_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Close_Button;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton Change_Button;
        private Guna.UI2.WinForms.Guna2TextBox NewUserName_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox OldUserName_TextBox;
        private System.Windows.Forms.Label label6;
    }
}