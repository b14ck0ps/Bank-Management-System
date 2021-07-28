
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
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.AppCloseLbl = new System.Windows.Forms.Label();
            this.EmpLink = new System.Windows.Forms.LinkLabel();
            this.LogoPicure = new System.Windows.Forms.PictureBox();
            this.GetStartedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicure)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.WelcomeLbl.Location = new System.Drawing.Point(54, 45);
            this.WelcomeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(203, 45);
            this.WelcomeLbl.TabIndex = 3;
            this.WelcomeLbl.Text = "Welcome  to";
            // 
            // AppCloseLbl
            // 
            this.AppCloseLbl.AutoSize = true;
            this.AppCloseLbl.BackColor = System.Drawing.Color.Transparent;
            this.AppCloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppCloseLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppCloseLbl.ForeColor = System.Drawing.Color.DimGray;
            this.AppCloseLbl.Location = new System.Drawing.Point(468, 0);
            this.AppCloseLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AppCloseLbl.Name = "AppCloseLbl";
            this.AppCloseLbl.Size = new System.Drawing.Size(16, 17);
            this.AppCloseLbl.TabIndex = 5;
            this.AppCloseLbl.Text = "X";
            this.AppCloseLbl.Click += new System.EventHandler(this.AppCloseLbl_Click);
            // 
            // EmpLink
            // 
            this.EmpLink.AutoSize = true;
            this.EmpLink.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLink.LinkColor = System.Drawing.Color.Green;
            this.EmpLink.Location = new System.Drawing.Point(188, 234);
            this.EmpLink.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmpLink.Name = "EmpLink";
            this.EmpLink.Size = new System.Drawing.Size(69, 17);
            this.EmpLink.TabIndex = 6;
            this.EmpLink.TabStop = true;
            this.EmpLink.Text = "Employee?";
            this.EmpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmpLink_LinkClicked);
            // 
            // LogoPicure
            // 
            this.LogoPicure.Image = global::BankManagementSystem.Properties.Resources.Logo;
            this.LogoPicure.Location = new System.Drawing.Point(248, 30);
            this.LogoPicure.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LogoPicure.Name = "LogoPicure";
            this.LogoPicure.Size = new System.Drawing.Size(171, 86);
            this.LogoPicure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicure.TabIndex = 7;
            this.LogoPicure.TabStop = false;
            // 
            // GetStartedBtn
            // 
            this.GetStartedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetStartedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetStartedBtn.ForeColor = System.Drawing.Color.Transparent;
            this.GetStartedBtn.Image = global::BankManagementSystem.Properties.Resources.getStarted_;
            this.GetStartedBtn.Location = new System.Drawing.Point(140, 160);
            this.GetStartedBtn.Name = "GetStartedBtn";
            this.GetStartedBtn.Size = new System.Drawing.Size(175, 65);
            this.GetStartedBtn.TabIndex = 8;
            this.GetStartedBtn.UseVisualStyleBackColor = true;
            this.GetStartedBtn.Click += new System.EventHandler(this.GetStartedBtn_Click);
            this.GetStartedBtn.MouseLeave += new System.EventHandler(this.GetStartedBtn_MouseLeave);
            this.GetStartedBtn.MouseHover += new System.EventHandler(this.GetStartedBtn_MouseHover);
            // 
            // WelcomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 260);
            this.Controls.Add(this.GetStartedBtn);
            this.Controls.Add(this.LogoPicure);
            this.Controls.Add(this.EmpLink);
            this.Controls.Add(this.AppCloseLbl);
            this.Controls.Add(this.WelcomeLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WelcomeUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label AppCloseLbl;
        private System.Windows.Forms.LinkLabel EmpLink;
        private System.Windows.Forms.PictureBox LogoPicure;
        private System.Windows.Forms.Button GetStartedBtn;
    }
}