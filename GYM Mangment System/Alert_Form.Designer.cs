namespace GYM_Mangment_System
{
    partial class Alert_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert_Form));
            this.Alert_Eclipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Show_Timer = new System.Windows.Forms.Timer(this.components);
            this.Close_Timer = new System.Windows.Forms.Timer(this.components);
            this.Message_Label = new System.Windows.Forms.Label();
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Icon_PictureBox = new System.Windows.Forms.PictureBox();
            this.Alert_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Alert_Eclipse
            // 
            this.Alert_Eclipse.ElipseRadius = 45;
            this.Alert_Eclipse.TargetControl = this;
            // 
            // Show_Timer
            // 
            this.Show_Timer.Tick += new System.EventHandler(this.Show_Timer_Tick);
            // 
            // Close_Timer
            // 
            this.Close_Timer.Tick += new System.EventHandler(this.Close_Timer_Tick);
            // 
            // Message_Label
            // 
            this.Message_Label.AutoSize = true;
            this.Message_Label.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_Label.ForeColor = System.Drawing.Color.White;
            this.Message_Label.Location = new System.Drawing.Point(66, 17);
            this.Message_Label.Name = "Message_Label";
            this.Message_Label.Size = new System.Drawing.Size(136, 34);
            this.Message_Label.TabIndex = 3;
            this.Message_Label.Text = "Message";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.SeaGreen;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = null;
            this.Close_Button.Location = new System.Drawing.Point(557, 15);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(37, 33);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 2;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Icon_PictureBox
            // 
            this.Icon_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Icon_PictureBox.Image")));
            this.Icon_PictureBox.Location = new System.Drawing.Point(13, 18);
            this.Icon_PictureBox.Name = "Icon_PictureBox";
            this.Icon_PictureBox.Size = new System.Drawing.Size(47, 41);
            this.Icon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_PictureBox.TabIndex = 0;
            this.Icon_PictureBox.TabStop = false;
            // 
            // Alert_Drag
            // 
            this.Alert_Drag.Fixed = true;
            this.Alert_Drag.Horizontal = true;
            this.Alert_Drag.TargetControl = this;
            this.Alert_Drag.Vertical = true;
            // 
            // Alert_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(610, 120);
            this.Controls.Add(this.Message_Label);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Icon_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alert_Form";
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Icon_PictureBox;
        private Bunifu.Framework.UI.BunifuElipse Alert_Eclipse;
        private System.Windows.Forms.Timer Show_Timer;
        private System.Windows.Forms.Timer Close_Timer;
        private System.Windows.Forms.Label Message_Label;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
        private Bunifu.Framework.UI.BunifuDragControl Alert_Drag;
    }
}