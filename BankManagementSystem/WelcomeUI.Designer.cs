
namespace BankManagementSystem
{
    partial class WelcomeUI
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
            this.GetStartedBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.EmpLink = new System.Windows.Forms.LinkLabel();
            this.AppCloseLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetStartedBtn
            // 
            this.GetStartedBtn.BackgroundImage = global::BankManagementSystem.Properties.Resources.getStarted;
            this.GetStartedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetStartedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetStartedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetStartedBtn.ForeColor = System.Drawing.Color.Transparent;
            this.GetStartedBtn.Location = new System.Drawing.Point(147, 131);
            this.GetStartedBtn.Name = "GetStartedBtn";
            this.GetStartedBtn.Size = new System.Drawing.Size(164, 74);
            this.GetStartedBtn.TabIndex = 0;
            this.GetStartedBtn.UseVisualStyleBackColor = true;
            this.GetStartedBtn.Click += new System.EventHandler(this.GetStartedBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagementSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(236, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.WelcomeLbl.Location = new System.Drawing.Point(43, 54);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(203, 45);
            this.WelcomeLbl.TabIndex = 2;
            this.WelcomeLbl.Text = "Welcome  to";
            // 
            // EmpLink
            // 
            this.EmpLink.AutoSize = true;
            this.EmpLink.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLink.LinkColor = System.Drawing.Color.Green;
            this.EmpLink.Location = new System.Drawing.Point(191, 217);
            this.EmpLink.Name = "EmpLink";
            this.EmpLink.Size = new System.Drawing.Size(69, 17);
            this.EmpLink.TabIndex = 3;
            this.EmpLink.TabStop = true;
            this.EmpLink.Text = "Employee?";
            this.EmpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmpLink_LinkClicked);
            // 
            // AppCloseLbl
            // 
            this.AppCloseLbl.AutoSize = true;
            this.AppCloseLbl.BackColor = System.Drawing.Color.Transparent;
            this.AppCloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppCloseLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppCloseLbl.ForeColor = System.Drawing.Color.DimGray;
            this.AppCloseLbl.Location = new System.Drawing.Point(453, 9);
            this.AppCloseLbl.Name = "AppCloseLbl";
            this.AppCloseLbl.Size = new System.Drawing.Size(16, 17);
            this.AppCloseLbl.TabIndex = 4;
            this.AppCloseLbl.Text = "X";
            this.AppCloseLbl.Click += new System.EventHandler(this.AppCloseLbl_Click);
            // 
            // WelcomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 243);
            this.Controls.Add(this.AppCloseLbl);
            this.Controls.Add(this.EmpLink);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GetStartedBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WelcomeUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetStartedBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.LinkLabel EmpLink;
        private System.Windows.Forms.Label AppCloseLbl;
    }
}