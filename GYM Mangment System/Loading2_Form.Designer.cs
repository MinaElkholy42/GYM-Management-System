namespace GYM_Mangment_System
{
    partial class Loading2_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading2_Form));
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Made_Label = new System.Windows.Forms.Label();
            this.Loading_Sign = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.Loading_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Phone_Label.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Phone_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Phone_Label.Location = new System.Drawing.Point(274, 475);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(654, 40);
            this.Phone_Label.TabIndex = 22;
            this.Phone_Label.Text = "Email : menalion99999@gmail.com";
            // 
            // Made_Label
            // 
            this.Made_Label.AutoSize = true;
            this.Made_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Made_Label.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Made_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Made_Label.Location = new System.Drawing.Point(411, 375);
            this.Made_Label.Name = "Made_Label";
            this.Made_Label.Size = new System.Drawing.Size(384, 40);
            this.Made_Label.TabIndex = 21;
            this.Made_Label.Text = "Made By : Mina Lion";
            // 
            // Loading_Sign
            // 
            this.Loading_Sign.AnimationSpeed = 80;
            this.Loading_Sign.AutoStart = true;
            this.Loading_Sign.CircleSize = 3F;
            this.Loading_Sign.Location = new System.Drawing.Point(543, 190);
            this.Loading_Sign.Name = "Loading_Sign";
            this.Loading_Sign.Size = new System.Drawing.Size(104, 104);
            this.Loading_Sign.TabIndex = 20;
            // 
            // Loading_Timer
            // 
            this.Loading_Timer.Interval = 500;
            this.Loading_Timer.Tick += new System.EventHandler(this.Loading_Timer_Tick);
            // 
            // Loading2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1195, 700);
            this.Controls.Add(this.Phone_Label);
            this.Controls.Add(this.Made_Label);
            this.Controls.Add(this.Loading_Sign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading2_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programme Access";
            this.Load += new System.EventHandler(this.Loading2_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.Label Made_Label;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator Loading_Sign;
        private System.Windows.Forms.Timer Loading_Timer;
    }
}