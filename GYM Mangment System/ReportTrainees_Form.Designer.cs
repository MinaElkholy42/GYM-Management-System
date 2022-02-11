namespace GYM_Mangment_System
{
    partial class ReportTrainees_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTrainees_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FullTrainees_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.InPorgressTrainees_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.FinishedTrainees_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.AllTraineesButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.InProgressTraineesButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.FinishedTraineesButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.Report_GridView = new System.Windows.Forms.DataGridView();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
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
            this.Header_Panel.Location = new System.Drawing.Point(1, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1257, 54);
            this.Header_Panel.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(534, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(446, 45);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Trainees Full Report";
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
            this.Close_Button.TabIndex = 0;
            this.Close_Button.UseTransparentBackground = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Form_Animation
            // 
            this.Form_Animation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Form_Animation.Interval = 300;
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // Controls_Elipse
            // 
            this.Controls_Elipse.ElipseRadius = 30;
            this.Controls_Elipse.TargetControl = this;
            // 
            // FullTrainees_Button
            // 
            this.FullTrainees_Button.Animated = true;
            this.FullTrainees_Button.BorderRadius = 40;
            this.FullTrainees_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.FullTrainees_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.FullTrainees_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.FullTrainees_Button.CheckedState.FillColor2 = System.Drawing.Color.Silver;
            this.FullTrainees_Button.CheckedState.Parent = this.FullTrainees_Button;
            this.FullTrainees_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullTrainees_Button.CustomImages.Parent = this.FullTrainees_Button;
            this.FullTrainees_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.FullTrainees_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.FullTrainees_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullTrainees_Button.ForeColor = System.Drawing.Color.White;
            this.FullTrainees_Button.HoverState.Parent = this.FullTrainees_Button;
            this.FullTrainees_Button.Image = ((System.Drawing.Image)(resources.GetObject("FullTrainees_Button.Image")));
            this.FullTrainees_Button.ImageSize = new System.Drawing.Size(70, 40);
            this.FullTrainees_Button.Location = new System.Drawing.Point(14, 194);
            this.FullTrainees_Button.Name = "FullTrainees_Button";
            this.FullTrainees_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.FullTrainees_Button.PressedDepth = 60;
            this.FullTrainees_Button.ShadowDecoration.Parent = this.FullTrainees_Button;
            this.FullTrainees_Button.Size = new System.Drawing.Size(310, 108);
            this.FullTrainees_Button.TabIndex = 4;
            this.FullTrainees_Button.Text = "All Trainees";
            this.FullTrainees_Button.CheckedChanged += new System.EventHandler(this.FullTrainees_Button_CheckedChanged);
            this.FullTrainees_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // InPorgressTrainees_Button
            // 
            this.InPorgressTrainees_Button.Animated = true;
            this.InPorgressTrainees_Button.BorderRadius = 40;
            this.InPorgressTrainees_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.InPorgressTrainees_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.InPorgressTrainees_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.InPorgressTrainees_Button.CheckedState.FillColor2 = System.Drawing.Color.Lime;
            this.InPorgressTrainees_Button.CheckedState.Parent = this.InPorgressTrainees_Button;
            this.InPorgressTrainees_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InPorgressTrainees_Button.CustomImages.Parent = this.InPorgressTrainees_Button;
            this.InPorgressTrainees_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.InPorgressTrainees_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.InPorgressTrainees_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InPorgressTrainees_Button.ForeColor = System.Drawing.Color.White;
            this.InPorgressTrainees_Button.HoverState.Parent = this.InPorgressTrainees_Button;
            this.InPorgressTrainees_Button.Image = ((System.Drawing.Image)(resources.GetObject("InPorgressTrainees_Button.Image")));
            this.InPorgressTrainees_Button.ImageSize = new System.Drawing.Size(70, 40);
            this.InPorgressTrainees_Button.Location = new System.Drawing.Point(488, 194);
            this.InPorgressTrainees_Button.Name = "InPorgressTrainees_Button";
            this.InPorgressTrainees_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.InPorgressTrainees_Button.PressedDepth = 60;
            this.InPorgressTrainees_Button.ShadowDecoration.Parent = this.InPorgressTrainees_Button;
            this.InPorgressTrainees_Button.Size = new System.Drawing.Size(310, 108);
            this.InPorgressTrainees_Button.TabIndex = 5;
            this.InPorgressTrainees_Button.Text = "In Porgress Trainees";
            this.InPorgressTrainees_Button.CheckedChanged += new System.EventHandler(this.InPorgressTrainees_Button_CheckedChanged);
            this.InPorgressTrainees_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // FinishedTrainees_Button
            // 
            this.FinishedTrainees_Button.Animated = true;
            this.FinishedTrainees_Button.BorderRadius = 40;
            this.FinishedTrainees_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.FinishedTrainees_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.FinishedTrainees_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.FinishedTrainees_Button.CheckedState.FillColor2 = System.Drawing.Color.Red;
            this.FinishedTrainees_Button.CheckedState.Parent = this.FinishedTrainees_Button;
            this.FinishedTrainees_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinishedTrainees_Button.CustomImages.Parent = this.FinishedTrainees_Button;
            this.FinishedTrainees_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.FinishedTrainees_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.FinishedTrainees_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishedTrainees_Button.ForeColor = System.Drawing.Color.White;
            this.FinishedTrainees_Button.HoverState.Parent = this.FinishedTrainees_Button;
            this.FinishedTrainees_Button.Image = ((System.Drawing.Image)(resources.GetObject("FinishedTrainees_Button.Image")));
            this.FinishedTrainees_Button.ImageSize = new System.Drawing.Size(50, 40);
            this.FinishedTrainees_Button.Location = new System.Drawing.Point(934, 194);
            this.FinishedTrainees_Button.Name = "FinishedTrainees_Button";
            this.FinishedTrainees_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.FinishedTrainees_Button.PressedDepth = 60;
            this.FinishedTrainees_Button.ShadowDecoration.Parent = this.FinishedTrainees_Button;
            this.FinishedTrainees_Button.Size = new System.Drawing.Size(310, 108);
            this.FinishedTrainees_Button.TabIndex = 6;
            this.FinishedTrainees_Button.Text = "Finished Trainees";
            this.FinishedTrainees_Button.CheckedChanged += new System.EventHandler(this.FinishedTrainees_Button_CheckedChanged);
            this.FinishedTrainees_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // AllTraineesButton_Tip
            // 
            this.AllTraineesButton_Tip.AllowLinksHandling = true;
            this.AllTraineesButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AllTraineesButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllTraineesButton_Tip.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllTraineesButton_Tip.ForeColor = System.Drawing.Color.White;
            this.AllTraineesButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.AllTraineesButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTraineesButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AllTraineesButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AllTraineesButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // InProgressTraineesButton_Tip
            // 
            this.InProgressTraineesButton_Tip.AllowLinksHandling = true;
            this.InProgressTraineesButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.InProgressTraineesButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InProgressTraineesButton_Tip.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InProgressTraineesButton_Tip.ForeColor = System.Drawing.Color.White;
            this.InProgressTraineesButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.InProgressTraineesButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InProgressTraineesButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.InProgressTraineesButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InProgressTraineesButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // FinishedTraineesButton_Tip
            // 
            this.FinishedTraineesButton_Tip.AllowLinksHandling = true;
            this.FinishedTraineesButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.FinishedTraineesButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinishedTraineesButton_Tip.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FinishedTraineesButton_Tip.ForeColor = System.Drawing.Color.White;
            this.FinishedTraineesButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.FinishedTraineesButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishedTraineesButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FinishedTraineesButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.FinishedTraineesButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // Report_GridView
            // 
            this.Report_GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Report_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Report_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Report_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Column,
            this.Code_Column,
            this.Payment_Column,
            this.PaymentDate_Column,
            this.FinishedDate_Column});
            this.Report_GridView.EnableHeadersVisualStyles = false;
            this.Report_GridView.Location = new System.Drawing.Point(1, 329);
            this.Report_GridView.Name = "Report_GridView";
            this.Report_GridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Report_GridView.RowHeadersVisible = false;
            this.Report_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Report_GridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Report_GridView.RowTemplate.Height = 26;
            this.Report_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_GridView.Size = new System.Drawing.Size(1253, 538);
            this.Report_GridView.TabIndex = 7;
            this.Report_GridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // Name_Column
            // 
            this.Name_Column.HeaderText = "Trainee Name";
            this.Name_Column.Name = "Name_Column";
            this.Name_Column.ReadOnly = true;
            this.Name_Column.Width = 230;
            // 
            // Code_Column
            // 
            this.Code_Column.HeaderText = "BarCode ID";
            this.Code_Column.Name = "Code_Column";
            this.Code_Column.ReadOnly = true;
            this.Code_Column.Width = 180;
            // 
            // Payment_Column
            // 
            this.Payment_Column.HeaderText = "Payment";
            this.Payment_Column.Name = "Payment_Column";
            this.Payment_Column.ReadOnly = true;
            this.Payment_Column.Width = 115;
            // 
            // PaymentDate_Column
            // 
            this.PaymentDate_Column.HeaderText = "Payment Date";
            this.PaymentDate_Column.Name = "PaymentDate_Column";
            this.PaymentDate_Column.ReadOnly = true;
            this.PaymentDate_Column.Width = 210;
            // 
            // FinishedDate_Column
            // 
            this.FinishedDate_Column.HeaderText = "Finished Date";
            this.FinishedDate_Column.Name = "FinishedDate_Column";
            this.FinishedDate_Column.ReadOnly = true;
            this.FinishedDate_Column.Width = 200;
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
            this.Refresh_Button.Location = new System.Drawing.Point(145, 75);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refresh_Button.PressedDepth = 60;
            this.Refresh_Button.ShadowDecoration.BorderRadius = 40;
            this.Refresh_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Refresh_Button.ShadowDecoration.Depth = 40;
            this.Refresh_Button.ShadowDecoration.Enabled = true;
            this.Refresh_Button.ShadowDecoration.Parent = this.Refresh_Button;
            this.Refresh_Button.Size = new System.Drawing.Size(232, 97);
            this.Refresh_Button.TabIndex = 15;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            this.Refresh_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
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
            this.Save_Button.Location = new System.Drawing.Point(502, 75);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_Button.PressedDepth = 60;
            this.Save_Button.ShadowDecoration.BorderRadius = 40;
            this.Save_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Save_Button.ShadowDecoration.Depth = 40;
            this.Save_Button.ShadowDecoration.Enabled = true;
            this.Save_Button.ShadowDecoration.Parent = this.Save_Button;
            this.Save_Button.Size = new System.Drawing.Size(264, 97);
            this.Save_Button.TabIndex = 22;
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
            this.Load_Button.Location = new System.Drawing.Point(884, 75);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Load_Button.PressedDepth = 60;
            this.Load_Button.ShadowDecoration.BorderRadius = 40;
            this.Load_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Load_Button.ShadowDecoration.Depth = 40;
            this.Load_Button.ShadowDecoration.Enabled = true;
            this.Load_Button.ShadowDecoration.Parent = this.Load_Button;
            this.Load_Button.Size = new System.Drawing.Size(264, 97);
            this.Load_Button.TabIndex = 23;
            this.Load_Button.Text = "Import From Excel";
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // ReportTrainees_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1257, 900);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Report_GridView);
            this.Controls.Add(this.FinishedTrainees_Button);
            this.Controls.Add(this.InPorgressTrainees_Button);
            this.Controls.Add(this.FullTrainees_Button);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportTrainees_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainees Report";
            this.Load += new System.EventHandler(this.ReportTrainees_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
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
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private Guna.UI2.WinForms.Guna2GradientTileButton FinishedTrainees_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton InPorgressTrainees_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton FullTrainees_Button;
        private Guna.UI2.WinForms.Guna2HtmlToolTip AllTraineesButton_Tip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip InProgressTraineesButton_Tip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip FinishedTraineesButton_Tip;
        private System.Windows.Forms.DataGridView Report_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedDate_Column;
        private Guna.UI2.WinForms.Guna2GradientTileButton Refresh_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton Save_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton Load_Button;
    }
}