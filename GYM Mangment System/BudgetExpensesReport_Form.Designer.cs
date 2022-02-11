namespace GYM_Mangment_System
{
    partial class BudgetExpensesReport_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetExpensesReport_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Refresh_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Years_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Report_GridView = new System.Windows.Forms.DataGridView();
            this.ExpensesAmount_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpensesText_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Months_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Save_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Load_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_GridView)).BeginInit();
            this.SuspendLayout();
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
            this.Header_Panel.Size = new System.Drawing.Size(1257, 54);
            this.Header_Panel.TabIndex = 11;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(515, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(336, 48);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Expenses Full Report";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(8, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(303, 48);
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
            this.Down_Button.Location = new System.Drawing.Point(1135, 6);
            this.Down_Button.Name = "Down_Button";
            this.Down_Button.PressedState.Parent = this.Down_Button;
            this.Down_Button.Size = new System.Drawing.Size(61, 39);
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
            this.Close_Button.Location = new System.Drawing.Point(1192, 6);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.PressedState.Parent = this.Close_Button;
            this.Close_Button.Size = new System.Drawing.Size(61, 39);
            this.Close_Button.TabIndex = 3;
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
            // Refresh_Button
            // 
            this.Refresh_Button.Animated = true;
            this.Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_Button.BorderRadius = 40;
            this.Refresh_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Refresh_Button.CheckedState.Parent = this.Refresh_Button;
            this.Refresh_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_Button.CustomImages.Parent = this.Refresh_Button;
            this.Refresh_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Refresh_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Refresh_Button.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.ForeColor = System.Drawing.Color.White;
            this.Refresh_Button.HoverState.Parent = this.Refresh_Button;
            this.Refresh_Button.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.Image")));
            this.Refresh_Button.ImageSize = new System.Drawing.Size(28, 28);
            this.Refresh_Button.Location = new System.Drawing.Point(993, 505);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refresh_Button.PressedDepth = 60;
            this.Refresh_Button.ShadowDecoration.BorderRadius = 40;
            this.Refresh_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Refresh_Button.ShadowDecoration.Depth = 40;
            this.Refresh_Button.ShadowDecoration.Enabled = true;
            this.Refresh_Button.ShadowDecoration.Parent = this.Refresh_Button;
            this.Refresh_Button.Size = new System.Drawing.Size(232, 97);
            this.Refresh_Button.TabIndex = 18;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Years_ComboBox
            // 
            this.Years_ComboBox.Animated = true;
            this.Years_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Years_ComboBox.BorderColor = System.Drawing.Color.White;
            this.Years_ComboBox.BorderRadius = 15;
            this.Years_ComboBox.BorderThickness = 3;
            this.Years_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Years_ComboBox.DropDownHeight = 500;
            this.Years_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Years_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Years_ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.Years_ComboBox.FocusedState.Parent = this.Years_ComboBox;
            this.Years_ComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Years_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Years_ComboBox.FormattingEnabled = true;
            this.Years_ComboBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.Years_ComboBox.HoverState.Parent = this.Years_ComboBox;
            this.Years_ComboBox.IntegralHeight = false;
            this.Years_ComboBox.ItemHeight = 30;
            this.Years_ComboBox.ItemsAppearance.Parent = this.Years_ComboBox;
            this.Years_ComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.SeaGreen;
            this.Years_ComboBox.Location = new System.Drawing.Point(978, 228);
            this.Years_ComboBox.MaxDropDownItems = 15;
            this.Years_ComboBox.Name = "Years_ComboBox";
            this.Years_ComboBox.ShadowDecoration.Parent = this.Years_ComboBox;
            this.Years_ComboBox.Size = new System.Drawing.Size(231, 36);
            this.Years_ComboBox.TabIndex = 17;
            this.Years_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Years_ComboBox_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(969, 156);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(256, 48);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Choose The Year";
            // 
            // Report_GridView
            // 
            this.Report_GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Report_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Report_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Report_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpensesAmount_Column,
            this.ExpensesText_Column});
            this.Report_GridView.EnableHeadersVisualStyles = false;
            this.Report_GridView.Location = new System.Drawing.Point(16, 78);
            this.Report_GridView.Name = "Report_GridView";
            this.Report_GridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Report_GridView.RowHeadersVisible = false;
            this.Report_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Report_GridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Report_GridView.RowTemplate.Height = 26;
            this.Report_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_GridView.Size = new System.Drawing.Size(941, 768);
            this.Report_GridView.TabIndex = 16;
            // 
            // ExpensesAmount_Column
            // 
            this.ExpensesAmount_Column.HeaderText = "Expenses";
            this.ExpensesAmount_Column.Name = "ExpensesAmount_Column";
            this.ExpensesAmount_Column.ReadOnly = true;
            this.ExpensesAmount_Column.Width = 150;
            // 
            // ExpensesText_Column
            // 
            this.ExpensesText_Column.HeaderText = "Reason/Direction";
            this.ExpensesText_Column.Name = "ExpensesText_Column";
            this.ExpensesText_Column.ReadOnly = true;
            this.ExpensesText_Column.Width = 545;
            // 
            // Months_ComboBox
            // 
            this.Months_ComboBox.Animated = true;
            this.Months_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Months_ComboBox.BorderColor = System.Drawing.Color.White;
            this.Months_ComboBox.BorderRadius = 15;
            this.Months_ComboBox.BorderThickness = 3;
            this.Months_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Months_ComboBox.DropDownHeight = 500;
            this.Months_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Months_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Months_ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.Months_ComboBox.FocusedState.Parent = this.Months_ComboBox;
            this.Months_ComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Months_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Months_ComboBox.FormattingEnabled = true;
            this.Months_ComboBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.Months_ComboBox.HoverState.Parent = this.Months_ComboBox;
            this.Months_ComboBox.IntegralHeight = false;
            this.Months_ComboBox.ItemHeight = 30;
            this.Months_ComboBox.ItemsAppearance.Parent = this.Months_ComboBox;
            this.Months_ComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.SeaGreen;
            this.Months_ComboBox.Location = new System.Drawing.Point(978, 440);
            this.Months_ComboBox.MaxDropDownItems = 15;
            this.Months_ComboBox.Name = "Months_ComboBox";
            this.Months_ComboBox.ShadowDecoration.Parent = this.Months_ComboBox;
            this.Months_ComboBox.Size = new System.Drawing.Size(231, 36);
            this.Months_ComboBox.TabIndex = 20;
            this.Months_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Months_ComboBox_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(963, 362);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(280, 48);
            this.guna2HtmlLabel4.TabIndex = 19;
            this.guna2HtmlLabel4.Text = "Choose The Month";
            // 
            // Save_Button
            // 
            this.Save_Button.Animated = true;
            this.Save_Button.BackColor = System.Drawing.Color.Transparent;
            this.Save_Button.BorderRadius = 40;
            this.Save_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Save_Button.CheckedState.Parent = this.Save_Button;
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Button.CustomImages.Parent = this.Save_Button;
            this.Save_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Save_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Save_Button.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.HoverState.Parent = this.Save_Button;
            this.Save_Button.Image = ((System.Drawing.Image)(resources.GetObject("Save_Button.Image")));
            this.Save_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Save_Button.Location = new System.Drawing.Point(979, 623);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_Button.PressedDepth = 60;
            this.Save_Button.ShadowDecoration.BorderRadius = 40;
            this.Save_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Save_Button.ShadowDecoration.Depth = 40;
            this.Save_Button.ShadowDecoration.Enabled = true;
            this.Save_Button.ShadowDecoration.Parent = this.Save_Button;
            this.Save_Button.Size = new System.Drawing.Size(264, 97);
            this.Save_Button.TabIndex = 21;
            this.Save_Button.Text = "Export To Excel";
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Animated = true;
            this.Load_Button.BackColor = System.Drawing.Color.Transparent;
            this.Load_Button.BorderRadius = 40;
            this.Load_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Load_Button.CheckedState.Parent = this.Load_Button;
            this.Load_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_Button.CustomImages.Parent = this.Load_Button;
            this.Load_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Load_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Load_Button.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Button.ForeColor = System.Drawing.Color.White;
            this.Load_Button.HoverState.Parent = this.Load_Button;
            this.Load_Button.Image = ((System.Drawing.Image)(resources.GetObject("Load_Button.Image")));
            this.Load_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Load_Button.Location = new System.Drawing.Point(979, 753);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Load_Button.PressedDepth = 60;
            this.Load_Button.ShadowDecoration.BorderRadius = 40;
            this.Load_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Load_Button.ShadowDecoration.Depth = 40;
            this.Load_Button.ShadowDecoration.Enabled = true;
            this.Load_Button.ShadowDecoration.Parent = this.Load_Button;
            this.Load_Button.Size = new System.Drawing.Size(264, 97);
            this.Load_Button.TabIndex = 22;
            this.Load_Button.Text = "Import From Excel";
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // BudgetExpensesReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1257, 900);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Months_ComboBox);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Years_ComboBox);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Report_GridView);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetExpensesReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses Report";
            this.Load += new System.EventHandler(this.BudgetExpensesReport_Form_Load);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Report_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header_Panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton Down_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Close_Button;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Guna.UI2.WinForms.Guna2GradientTileButton Refresh_Button;
        private Guna.UI2.WinForms.Guna2ComboBox Years_ComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataGridView Report_GridView;
        private Guna.UI2.WinForms.Guna2ComboBox Months_ComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpensesAmount_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpensesText_Column;
        private Guna.UI2.WinForms.Guna2GradientTileButton Save_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton Load_Button;
    }
}