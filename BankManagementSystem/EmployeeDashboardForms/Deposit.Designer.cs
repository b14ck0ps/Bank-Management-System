
namespace BankManagementSystem.EmployeeDashboardForms
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
            this._joinDateLbl = new System.Windows.Forms.Label();
            this.JoinDateLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NidLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this._eamilLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this._phoneLbl = new System.Windows.Forms.Label();
            this._addressLbl = new System.Windows.Forms.Label();
            this._NIDLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this._FullnameLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CardPicture = new System.Windows.Forms.PictureBox();
            this.DisplayPicture = new System.Windows.Forms.PictureBox();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.BalanceLbl.Location = new System.Drawing.Point(341, 85);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(250, 25);
            this.BalanceLbl.TabIndex = 27;
            this.BalanceLbl.Text = "Current Balance :  <balance>";
            this.BalanceLbl.Visible = false;
            // 
            // _joinDateLbl
            // 
            this._joinDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._joinDateLbl.AutoSize = true;
            this._joinDateLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._joinDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._joinDateLbl.Location = new System.Drawing.Point(124, 210);
            this._joinDateLbl.Name = "_joinDateLbl";
            this._joinDateLbl.Size = new System.Drawing.Size(103, 25);
            this._joinDateLbl.TabIndex = 23;
            this._joinDateLbl.Text = "<Joindate>";
            this._joinDateLbl.Visible = false;
            // 
            // JoinDateLbl
            // 
            this.JoinDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JoinDateLbl.AutoSize = true;
            this.JoinDateLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JoinDateLbl.Location = new System.Drawing.Point(17, 210);
            this.JoinDateLbl.Name = "JoinDateLbl";
            this.JoinDateLbl.Size = new System.Drawing.Size(100, 25);
            this.JoinDateLbl.TabIndex = 22;
            this.JoinDateLbl.Text = "Join Date  :";
            this.JoinDateLbl.Visible = false;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.DescriptionLbl.Location = new System.Drawing.Point(23, 85);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(158, 25);
            this.DescriptionLbl.TabIndex = 23;
            this.DescriptionLbl.Text = "User information : ";
            this.DescriptionLbl.Visible = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this._joinDateLbl);
            this.infoPanel.Controls.Add(this.JoinDateLbl);
            this.infoPanel.Controls.Add(this.NameLbl);
            this.infoPanel.Controls.Add(this.NidLbl);
            this.infoPanel.Controls.Add(this.AddressLbl);
            this.infoPanel.Controls.Add(this._eamilLbl);
            this.infoPanel.Controls.Add(this.emailLbl);
            this.infoPanel.Controls.Add(this._phoneLbl);
            this.infoPanel.Controls.Add(this._addressLbl);
            this.infoPanel.Controls.Add(this._NIDLbl);
            this.infoPanel.Controls.Add(this.PhoneLbl);
            this.infoPanel.Controls.Add(this._FullnameLbl);
            this.infoPanel.Location = new System.Drawing.Point(28, 113);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(543, 248);
            this.infoPanel.TabIndex = 25;
            this.infoPanel.Visible = false;
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLbl.Location = new System.Drawing.Point(21, 16);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(106, 25);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Full Name : ";
            this.NameLbl.Visible = false;
            // 
            // NidLbl
            // 
            this.NidLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NidLbl.AutoSize = true;
            this.NidLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NidLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NidLbl.Location = new System.Drawing.Point(21, 49);
            this.NidLbl.Name = "NidLbl";
            this.NidLbl.Size = new System.Drawing.Size(106, 25);
            this.NidLbl.TabIndex = 3;
            this.NidLbl.Text = "NID           : ";
            this.NidLbl.Visible = false;
            // 
            // AddressLbl
            // 
            this.AddressLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddressLbl.Location = new System.Drawing.Point(19, 91);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(105, 25);
            this.AddressLbl.TabIndex = 4;
            this.AddressLbl.Text = "Address    : ";
            this.AddressLbl.Visible = false;
            // 
            // _eamilLbl
            // 
            this._eamilLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._eamilLbl.AutoSize = true;
            this._eamilLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._eamilLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._eamilLbl.Location = new System.Drawing.Point(124, 135);
            this._eamilLbl.Name = "_eamilLbl";
            this._eamilLbl.Size = new System.Drawing.Size(79, 25);
            this._eamilLbl.TabIndex = 16;
            this._eamilLbl.Text = "<email>";
            this._eamilLbl.Visible = false;
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLbl.Location = new System.Drawing.Point(19, 135);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(104, 25);
            this.emailLbl.TabIndex = 15;
            this.emailLbl.Text = "Email        : ";
            this.emailLbl.Visible = false;
            // 
            // _phoneLbl
            // 
            this._phoneLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._phoneLbl.AutoSize = true;
            this._phoneLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._phoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._phoneLbl.Location = new System.Drawing.Point(124, 174);
            this._phoneLbl.Name = "_phoneLbl";
            this._phoneLbl.Size = new System.Drawing.Size(88, 25);
            this._phoneLbl.TabIndex = 14;
            this._phoneLbl.Text = "<phone>";
            this._phoneLbl.Visible = false;
            // 
            // _addressLbl
            // 
            this._addressLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._addressLbl.AutoSize = true;
            this._addressLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._addressLbl.Location = new System.Drawing.Point(124, 91);
            this._addressLbl.Name = "_addressLbl";
            this._addressLbl.Size = new System.Drawing.Size(97, 25);
            this._addressLbl.TabIndex = 13;
            this._addressLbl.Text = "<address>";
            this._addressLbl.Visible = false;
            // 
            // _NIDLbl
            // 
            this._NIDLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._NIDLbl.AutoSize = true;
            this._NIDLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._NIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._NIDLbl.Location = new System.Drawing.Point(124, 49);
            this._NIDLbl.Name = "_NIDLbl";
            this._NIDLbl.Size = new System.Drawing.Size(61, 25);
            this._NIDLbl.TabIndex = 12;
            this._NIDLbl.Text = "<nid>";
            this._NIDLbl.Visible = false;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PhoneLbl.Location = new System.Drawing.Point(21, 174);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(102, 25);
            this.PhoneLbl.TabIndex = 5;
            this.PhoneLbl.Text = "Phone      : ";
            this.PhoneLbl.Visible = false;
            // 
            // _FullnameLbl
            // 
            this._FullnameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._FullnameLbl.AutoSize = true;
            this._FullnameLbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._FullnameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._FullnameLbl.Location = new System.Drawing.Point(124, 16);
            this._FullnameLbl.Name = "_FullnameLbl";
            this._FullnameLbl.Size = new System.Drawing.Size(116, 25);
            this._FullnameLbl.TabIndex = 11;
            this._FullnameLbl.Text = "<Full Name>";
            this._FullnameLbl.Visible = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.BackColor = System.Drawing.Color.White;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SearchBtn.Location = new System.Drawing.Point(222, 33);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(81, 37);
            this.SearchBtn.TabIndex = 22;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameTextBox.Location = new System.Drawing.Point(12, 34);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(204, 33);
            this.UsernameTextBox.TabIndex = 21;
            this.UsernameTextBox.Text = "Customer Username";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // DepositBtn
            // 
            this.DepositBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepositBtn.BackColor = System.Drawing.Color.White;
            this.DepositBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.DepositBtn.Location = new System.Drawing.Point(556, 30);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(122, 37);
            this.DepositBtn.TabIndex = 20;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.AmountTextBox.Location = new System.Drawing.Point(346, 33);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(204, 33);
            this.AmountTextBox.TabIndex = 19;
            this.AmountTextBox.Text = "Enter Deposit Amount";
            this.AmountTextBox.Enter += new System.EventHandler(this.AmountTextBox_Enter);
            this.AmountTextBox.Leave += new System.EventHandler(this.AmountTextBox_Leave);
            // 
            // CardPicture
            // 
            this.CardPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardPicture.Image = global::BankManagementSystem.Properties.Resources.cardHolder;
            this.CardPicture.Location = new System.Drawing.Point(577, 232);
            this.CardPicture.Name = "CardPicture";
            this.CardPicture.Size = new System.Drawing.Size(100, 114);
            this.CardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardPicture.TabIndex = 26;
            this.CardPicture.TabStop = false;
            this.CardPicture.Visible = false;
            // 
            // DisplayPicture
            // 
            this.DisplayPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayPicture.Image = global::BankManagementSystem.Properties.Resources.dpHolder;
            this.DisplayPicture.Location = new System.Drawing.Point(577, 113);
            this.DisplayPicture.Name = "DisplayPicture";
            this.DisplayPicture.Size = new System.Drawing.Size(100, 107);
            this.DisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayPicture.TabIndex = 24;
            this.DisplayPicture.TabStop = false;
            this.DisplayPicture.Visible = false;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 390);
            this.Controls.Add(this.BalanceLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.CardPicture);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.DisplayPicture);
            this.Controls.Add(this.AmountTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Deposit";
            this.ShowIcon = false;
            this.Text = "Deposit";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceLbl;
        private System.Windows.Forms.Label _joinDateLbl;
        private System.Windows.Forms.Label JoinDateLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label NidLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label _eamilLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label _phoneLbl;
        private System.Windows.Forms.Label _addressLbl;
        private System.Windows.Forms.Label _NIDLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label _FullnameLbl;
        private System.Windows.Forms.PictureBox CardPicture;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.PictureBox DisplayPicture;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}