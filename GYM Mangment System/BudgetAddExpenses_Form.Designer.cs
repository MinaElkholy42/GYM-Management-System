namespace GYM_Mangment_System
{
    partial class BudgetAddExpenses_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetAddExpenses_Form));
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Enter_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Expenses_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Text_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Header_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(204, 66);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(484, 48);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Add Amount Of Consume Of The GYM";
            this.guna2HtmlLabel3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // Enter_Button
            // 
            this.Enter_Button.Animated = true;
            this.Enter_Button.BorderRadius = 26;
            this.Enter_Button.CheckedState.Parent = this.Enter_Button;
            this.Enter_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter_Button.CustomImages.Parent = this.Enter_Button;
            this.Enter_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Enter_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.Enter_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Button.ForeColor = System.Drawing.Color.White;
            this.Enter_Button.HoverState.Parent = this.Enter_Button;
            this.Enter_Button.Location = new System.Drawing.Point(315, 302);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter_Button.PressedDepth = 60;
            this.Enter_Button.ShadowDecoration.Parent = this.Enter_Button;
            this.Enter_Button.Size = new System.Drawing.Size(234, 70);
            this.Enter_Button.TabIndex = 2;
            this.Enter_Button.Text = "Add The Amount";
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            this.Enter_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // Expenses_TextBox
            // 
            this.Expenses_TextBox.Animated = true;
            this.Expenses_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Expenses_TextBox.BorderRadius = 15;
            this.Expenses_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Expenses_TextBox.BorderThickness = 2;
            this.Expenses_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Expenses_TextBox.DefaultText = "Enter The Expenses";
            this.Expenses_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Expenses_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Expenses_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Expenses_TextBox.DisabledState.Parent = this.Expenses_TextBox;
            this.Expenses_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Expenses_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Expenses_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Expenses_TextBox.FocusedState.Parent = this.Expenses_TextBox;
            this.Expenses_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Expenses_TextBox.ForeColor = System.Drawing.Color.White;
            this.Expenses_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Expenses_TextBox.HoverState.Parent = this.Expenses_TextBox;
            this.Expenses_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Expenses_TextBox.IconLeft")));
            this.Expenses_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.Expenses_TextBox.Location = new System.Drawing.Point(202, 133);
            this.Expenses_TextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.Expenses_TextBox.Name = "Expenses_TextBox";
            this.Expenses_TextBox.PasswordChar = '\0';
            this.Expenses_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Expenses_TextBox.PlaceholderText = "";
            this.Expenses_TextBox.SelectedText = "";
            this.Expenses_TextBox.SelectionStart = 18;
            this.Expenses_TextBox.ShadowDecoration.Parent = this.Expenses_TextBox;
            this.Expenses_TextBox.Size = new System.Drawing.Size(484, 62);
            this.Expenses_TextBox.TabIndex = 0;
            this.Expenses_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Expenses_TextBox.Enter += new System.EventHandler(this.Expenses_TextBox_Enter);
            this.Expenses_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Expenses_TextBox.Leave += new System.EventHandler(this.Expenses_TextBox_Leave);
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
            this.Header_Panel.Location = new System.Drawing.Point(0, 1);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(860, 54);
            this.Header_Panel.TabIndex = 38;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(381, 5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(226, 48);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Add Expenses";
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
            this.Down_Button.Location = new System.Drawing.Point(749, 6);
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
            this.Close_Button.Location = new System.Drawing.Point(799, 6);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.PressedState.Parent = this.Close_Button;
            this.Close_Button.Size = new System.Drawing.Size(53, 39);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.UseTransparentBackground = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
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
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // Text_TextBox
            // 
            this.Text_TextBox.Animated = true;
            this.Text_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Text_TextBox.BorderRadius = 15;
            this.Text_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Text_TextBox.BorderThickness = 2;
            this.Text_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_TextBox.DefaultText = "Enter The Expenses Direction";
            this.Text_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Text_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_TextBox.DisabledState.Parent = this.Text_TextBox;
            this.Text_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Text_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Text_TextBox.FocusedState.Parent = this.Text_TextBox;
            this.Text_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Text_TextBox.ForeColor = System.Drawing.Color.White;
            this.Text_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Text_TextBox.HoverState.Parent = this.Text_TextBox;
            this.Text_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Text_TextBox.IconLeft")));
            this.Text_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.Text_TextBox.Location = new System.Drawing.Point(7, 218);
            this.Text_TextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.Text_TextBox.MaxLength = 50;
            this.Text_TextBox.Name = "Text_TextBox";
            this.Text_TextBox.PasswordChar = '\0';
            this.Text_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Text_TextBox.PlaceholderText = "";
            this.Text_TextBox.SelectedText = "";
            this.Text_TextBox.SelectionStart = 28;
            this.Text_TextBox.ShadowDecoration.Parent = this.Text_TextBox;
            this.Text_TextBox.Size = new System.Drawing.Size(845, 62);
            this.Text_TextBox.TabIndex = 1;
            this.Text_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_TextBox.Enter += new System.EventHandler(this.Text_TextBox_Enter);
            this.Text_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Text_TextBox.Leave += new System.EventHandler(this.Text_TextBox_Leave);
            // 
            // BudgetAddExpenses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(860, 400);
            this.Controls.Add(this.Text_TextBox);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.Expenses_TextBox);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetAddExpenses_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expenses";
            this.Load += new System.EventHandler(this.BudgetAddExpenses_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Header_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GradientButton Enter_Button;
        private Guna.UI2.WinForms.Guna2TextBox Expenses_TextBox;
        private System.Windows.Forms.Panel Header_Panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton Down_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Close_Button;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Guna.UI2.WinForms.Guna2TextBox Text_TextBox;
    }
}