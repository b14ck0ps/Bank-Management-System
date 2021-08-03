
namespace BankManagementSystem.Dashboard_Forms
{
    partial class Tansfer
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
            this.TransferBtn = new System.Windows.Forms.Button();
            this.TransferUsernameTextBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this._eamilLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this._FullnameLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DisplayPicture = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).BeginInit();
            this.infoPanel.SuspendLayout();
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
            this.AmountTextBox.Location = new System.Drawing.Point(40, 226);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(247, 33);
            this.AmountTextBox.TabIndex = 10;
            this.AmountTextBox.Text = "Transfer Amount";
            this.AmountTextBox.Visible = false;
            this.AmountTextBox.Enter += new System.EventHandler(this.AmountTextBox_Enter);
            this.AmountTextBox.Leave += new System.EventHandler(this.AmountTextBox_Leave);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransferBtn.BackColor = System.Drawing.Color.White;
            this.TransferBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransferBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.TransferBtn.Location = new System.Drawing.Point(40, 278);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(122, 37);
            this.TransferBtn.TabIndex = 11;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = false;
            this.TransferBtn.Visible = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // TransferUsernameTextBox
            // 
            this.TransferUsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransferUsernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.TransferUsernameTextBox.Location = new System.Drawing.Point(40, 75);
            this.TransferUsernameTextBox.Name = "TransferUsernameTextBox";
            this.TransferUsernameTextBox.Size = new System.Drawing.Size(247, 33);
            this.TransferUsernameTextBox.TabIndex = 12;
            this.TransferUsernameTextBox.Text = "Transfer Account Username";
            this.TransferUsernameTextBox.Enter += new System.EventHandler(this.TransferUsernameTextBox_Enter);
            this.TransferUsernameTextBox.Leave += new System.EventHandler(this.TransferUsernameTextBox_Leave);
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLbl.Location = new System.Drawing.Point(1, 6);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(106, 25);
            this.NameLbl.TabIndex = 17;
            this.NameLbl.Text = "Full Name : ";
            // 
            // _eamilLbl
            // 
            this._eamilLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._eamilLbl.AutoSize = true;
            this._eamilLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._eamilLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._eamilLbl.Location = new System.Drawing.Point(113, 50);
            this._eamilLbl.Name = "_eamilLbl";
            this._eamilLbl.Size = new System.Drawing.Size(79, 25);
            this._eamilLbl.TabIndex = 20;
            this._eamilLbl.Text = "<email>";
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLbl.Location = new System.Drawing.Point(3, 50);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(104, 25);
            this.emailLbl.TabIndex = 19;
            this.emailLbl.Text = "Email        : ";
            // 
            // _FullnameLbl
            // 
            this._FullnameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._FullnameLbl.AutoSize = true;
            this._FullnameLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._FullnameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._FullnameLbl.Location = new System.Drawing.Point(104, 6);
            this._FullnameLbl.Name = "_FullnameLbl";
            this._FullnameLbl.Size = new System.Drawing.Size(116, 25);
            this._FullnameLbl.TabIndex = 18;
            this._FullnameLbl.Text = "<Full Name>";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.BackColor = System.Drawing.Color.White;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SearchBtn.Location = new System.Drawing.Point(293, 72);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(81, 37);
            this.SearchBtn.TabIndex = 23;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DisplayPicture
            // 
            this.DisplayPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayPicture.Image = global::BankManagementSystem.Properties.Resources.dpHolder;
            this.DisplayPicture.Location = new System.Drawing.Point(554, 115);
            this.DisplayPicture.Name = "DisplayPicture";
            this.DisplayPicture.Size = new System.Drawing.Size(100, 107);
            this.DisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayPicture.TabIndex = 25;
            this.DisplayPicture.TabStop = false;
            this.DisplayPicture.Visible = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this._FullnameLbl);
            this.infoPanel.Controls.Add(this.emailLbl);
            this.infoPanel.Controls.Add(this._eamilLbl);
            this.infoPanel.Controls.Add(this.NameLbl);
            this.infoPanel.Location = new System.Drawing.Point(40, 126);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(491, 89);
            this.infoPanel.TabIndex = 26;
            this.infoPanel.Visible = false;
            // 
            // Tansfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 390);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.DisplayPicture);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.TransferUsernameTextBox);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.BalanceLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tansfer";
            this.ShowIcon = false;
            this.Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceLbl;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.TextBox TransferUsernameTextBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label _eamilLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label _FullnameLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.PictureBox DisplayPicture;
        private System.Windows.Forms.Panel infoPanel;
    }
}