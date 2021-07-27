﻿
namespace BankManagementSystem
{
    partial class EmployeeDashBoard
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
            this.HomeBtn = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.White;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.HomeBtn.Location = new System.Drawing.Point(367, 37);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(122, 55);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            //this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.Color.White;
            this.DepositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.DepositBtn.Location = new System.Drawing.Point(556, 37);
            this.DepositBtn.Name = "CustomerInfoBtn";
            this.DepositBtn.Size = new System.Drawing.Size(122, 55);
            this.DepositBtn.TabIndex = 2;
            this.DepositBtn.Text = "Customer Info";
            this.DepositBtn.UseVisualStyleBackColor = false;
            //this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.WithdrawBtn.Location = new System.Drawing.Point(745, 37);
            this.WithdrawBtn.Name = "EditInfoBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(122, 55);
            this.WithdrawBtn.TabIndex = 3;
            this.WithdrawBtn.Text = "Edit Info";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            //this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.LogoutBtn.Location = new System.Drawing.Point(12, 484);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(122, 55);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            //this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.Image = global::BankManagementSystem.Properties.Resources.Logo;
            this.LogopictureBox.Location = new System.Drawing.Point(3, 0);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(298, 127);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogopictureBox.TabIndex = 0;
            this.LogopictureBox.TabStop = false;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.LogopictureBox);
            this.NavigationPanel.Controls.Add(this.DepositBtn);
            this.NavigationPanel.Controls.Add(this.HomeBtn);
            this.NavigationPanel.Controls.Add(this.WithdrawBtn);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(934, 130);
            this.NavigationPanel.TabIndex = 7;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 477);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(934, 74);
            this.BottomPanel.TabIndex = 8;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 130);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(934, 347);
            this.MainPanel.TabIndex = 9;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 551);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel MainPanel;
    }
}