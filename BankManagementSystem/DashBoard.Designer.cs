
namespace BankManagementSystem
{
    partial class DashBoard
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
            this.CardpictureBox = new System.Windows.Forms.PictureBox();
            this.ProfilepictureBox = new System.Windows.Forms.PictureBox();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CardpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.White;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.HomeBtn.Location = new System.Drawing.Point(453, 68);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(122, 55);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.Color.White;
            this.DepositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.DepositBtn.Location = new System.Drawing.Point(616, 68);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(122, 55);
            this.DepositBtn.TabIndex = 2;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.WithdrawBtn.Location = new System.Drawing.Point(777, 68);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(122, 55);
            this.WithdrawBtn.TabIndex = 3;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.LogoutBtn.Location = new System.Drawing.Point(86, 484);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(122, 55);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CardpictureBox
            // 
            this.CardpictureBox.Image = global::BankManagementSystem.Properties.Resources.cardHolder;
            this.CardpictureBox.Location = new System.Drawing.Point(708, 352);
            this.CardpictureBox.Name = "CardpictureBox";
            this.CardpictureBox.Size = new System.Drawing.Size(191, 177);
            this.CardpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardpictureBox.TabIndex = 6;
            this.CardpictureBox.TabStop = false;
            // 
            // ProfilepictureBox
            // 
            this.ProfilepictureBox.Image = global::BankManagementSystem.Properties.Resources.dpHolder;
            this.ProfilepictureBox.Location = new System.Drawing.Point(708, 159);
            this.ProfilepictureBox.Name = "ProfilepictureBox";
            this.ProfilepictureBox.Size = new System.Drawing.Size(191, 193);
            this.ProfilepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilepictureBox.TabIndex = 5;
            this.ProfilepictureBox.TabStop = false;
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.Image = global::BankManagementSystem.Properties.Resources.Logo;
            this.LogopictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(298, 135);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogopictureBox.TabIndex = 0;
            this.LogopictureBox.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 551);
            this.Controls.Add(this.CardpictureBox);
            this.Controls.Add(this.ProfilepictureBox);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.LogopictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.CardpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.PictureBox ProfilepictureBox;
        private System.Windows.Forms.PictureBox CardpictureBox;
    }
}