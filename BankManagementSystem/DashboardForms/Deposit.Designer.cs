﻿
namespace BankManagementSystem.Dashboard_Forms
{
    partial class Deposit
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
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.BalanceLbl.Location = new System.Drawing.Point(428, 25);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(250, 25);
            this.BalanceLbl.TabIndex = 9;
            this.BalanceLbl.Text = "Current Balance :  <balance>";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.AmountTextBox.Location = new System.Drawing.Point(165, 163);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(380, 33);
            this.AmountTextBox.TabIndex = 10;
            this.AmountTextBox.Text = "Enter Amount You want to deposit";
            this.AmountTextBox.Enter += new System.EventHandler(this.AmountTextBox_Enter);
            this.AmountTextBox.Leave += new System.EventHandler(this.AmountTextBox_Leave);
            // 
            // DepositBtn
            // 
            this.DepositBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepositBtn.BackColor = System.Drawing.Color.White;
            this.DepositBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.DepositBtn.Location = new System.Drawing.Point(277, 214);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(122, 37);
            this.DepositBtn.TabIndex = 11;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 390);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.BalanceLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Deposit";
            this.ShowIcon = false;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceLbl;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button DepositBtn;
    }
}