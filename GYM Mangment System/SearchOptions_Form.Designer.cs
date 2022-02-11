namespace GYM_Mangment_System
{
    partial class SearchOptions_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOptions_Form));
            this.Header_Label = new System.Windows.Forms.Label();
            this.PhoneSearch_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.IDSearch_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.FullReprot_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FullReportButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.IDCardButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.PhoneNumberButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.SuspendLayout();
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Header_Label.Location = new System.Drawing.Point(177, 9);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(560, 36);
            this.Header_Label.TabIndex = 6;
            this.Header_Label.Text = "Search the Trainee Details and Reports";
            // 
            // PhoneSearch_Button
            // 
            this.PhoneSearch_Button.Animated = true;
            this.PhoneSearch_Button.BorderRadius = 40;
            this.PhoneSearch_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.PhoneSearch_Button.CheckedState.Parent = this.PhoneSearch_Button;
            this.PhoneSearch_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneSearch_Button.CustomImages.Parent = this.PhoneSearch_Button;
            this.PhoneSearch_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PhoneSearch_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.PhoneSearch_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneSearch_Button.ForeColor = System.Drawing.Color.White;
            this.PhoneSearch_Button.HoverState.Parent = this.PhoneSearch_Button;
            this.PhoneSearch_Button.Image = ((System.Drawing.Image)(resources.GetObject("PhoneSearch_Button.Image")));
            this.PhoneSearch_Button.ImageSize = new System.Drawing.Size(45, 40);
            this.PhoneSearch_Button.Location = new System.Drawing.Point(12, 274);
            this.PhoneSearch_Button.Name = "PhoneSearch_Button";
            this.PhoneSearch_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.PhoneSearch_Button.PressedDepth = 60;
            this.PhoneSearch_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhoneSearch_Button.ShadowDecoration.Parent = this.PhoneSearch_Button;
            this.PhoneSearch_Button.Size = new System.Drawing.Size(271, 117);
            this.PhoneSearch_Button.TabIndex = 1;
            this.PhoneSearch_Button.Text = "Phone Number Search";
            this.PhoneSearch_Button.Click += new System.EventHandler(this.PhoneSearch_Button_Click);
            // 
            // IDSearch_Button
            // 
            this.IDSearch_Button.Animated = true;
            this.IDSearch_Button.BorderRadius = 40;
            this.IDSearch_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.IDSearch_Button.CheckedState.Parent = this.IDSearch_Button;
            this.IDSearch_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IDSearch_Button.CustomImages.Parent = this.IDSearch_Button;
            this.IDSearch_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.IDSearch_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.IDSearch_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSearch_Button.ForeColor = System.Drawing.Color.White;
            this.IDSearch_Button.HoverState.Parent = this.IDSearch_Button;
            this.IDSearch_Button.Image = ((System.Drawing.Image)(resources.GetObject("IDSearch_Button.Image")));
            this.IDSearch_Button.ImageSize = new System.Drawing.Size(45, 40);
            this.IDSearch_Button.Location = new System.Drawing.Point(605, 274);
            this.IDSearch_Button.Name = "IDSearch_Button";
            this.IDSearch_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.IDSearch_Button.PressedDepth = 60;
            this.IDSearch_Button.ShadowDecoration.Parent = this.IDSearch_Button;
            this.IDSearch_Button.Size = new System.Drawing.Size(271, 117);
            this.IDSearch_Button.TabIndex = 0;
            this.IDSearch_Button.Text = "ID Card Search";
            this.IDSearch_Button.Click += new System.EventHandler(this.IDSearch_Button_Click);
            // 
            // FullReprot_Button
            // 
            this.FullReprot_Button.Animated = true;
            this.FullReprot_Button.BorderRadius = 40;
            this.FullReprot_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.FullReprot_Button.CheckedState.Parent = this.FullReprot_Button;
            this.FullReprot_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullReprot_Button.CustomImages.Parent = this.FullReprot_Button;
            this.FullReprot_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.FullReprot_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.FullReprot_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullReprot_Button.ForeColor = System.Drawing.Color.White;
            this.FullReprot_Button.HoverState.Parent = this.FullReprot_Button;
            this.FullReprot_Button.Image = ((System.Drawing.Image)(resources.GetObject("FullReprot_Button.Image")));
            this.FullReprot_Button.ImageSize = new System.Drawing.Size(45, 40);
            this.FullReprot_Button.Location = new System.Drawing.Point(315, 133);
            this.FullReprot_Button.Name = "FullReprot_Button";
            this.FullReprot_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.FullReprot_Button.PressedDepth = 60;
            this.FullReprot_Button.ShadowDecoration.Parent = this.FullReprot_Button;
            this.FullReprot_Button.Size = new System.Drawing.Size(271, 117);
            this.FullReprot_Button.TabIndex = 7;
            this.FullReprot_Button.Text = "Get Trainees Report";
            this.FullReprot_Button.Click += new System.EventHandler(this.FullReprot_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(257, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Using One Of These Options";
            // 
            // FullReportButton_Tip
            // 
            this.FullReportButton_Tip.AllowLinksHandling = true;
            this.FullReportButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.FullReportButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FullReportButton_Tip.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FullReportButton_Tip.ForeColor = System.Drawing.Color.White;
            this.FullReportButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.FullReportButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullReportButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FullReportButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.FullReportButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // IDCardButton_Tip
            // 
            this.IDCardButton_Tip.AllowLinksHandling = true;
            this.IDCardButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.IDCardButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IDCardButton_Tip.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IDCardButton_Tip.ForeColor = System.Drawing.Color.White;
            this.IDCardButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.IDCardButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCardButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IDCardButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.IDCardButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // PhoneNumberButton_Tip
            // 
            this.PhoneNumberButton_Tip.AllowLinksHandling = true;
            this.PhoneNumberButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PhoneNumberButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhoneNumberButton_Tip.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhoneNumberButton_Tip.ForeColor = System.Drawing.Color.White;
            this.PhoneNumberButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.PhoneNumberButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PhoneNumberButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.PhoneNumberButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // SearchOptions_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(888, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullReprot_Button);
            this.Controls.Add(this.Header_Label);
            this.Controls.Add(this.PhoneSearch_Button);
            this.Controls.Add(this.IDSearch_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchOptions_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainees Search Options";
            this.Load += new System.EventHandler(this.SearchOptions_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton IDSearch_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton PhoneSearch_Button;
        private System.Windows.Forms.Label Header_Label;
        private Guna.UI2.WinForms.Guna2GradientTileButton FullReprot_Button;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip FullReportButton_Tip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip IDCardButton_Tip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip PhoneNumberButton_Tip;
    }
}