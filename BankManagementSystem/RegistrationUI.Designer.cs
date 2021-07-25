
namespace BankManagementSystem
{
    partial class RegistrationUI
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
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.LnkLogin = new System.Windows.Forms.LinkLabel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.Nidtextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.UsernameTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameTextbox.Location = new System.Drawing.Point(51, 188);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(286, 32);
            this.UsernameTextbox.TabIndex = 0;
            this.UsernameTextbox.Text = "Enter a Username";
            this.UsernameTextbox.Enter += new System.EventHandler(this.UsernameTextbox_Enter);
            this.UsernameTextbox.Leave += new System.EventHandler(this.UsernameTextbox_Leave);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PasswordTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTextbox.Location = new System.Drawing.Point(51, 239);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(286, 32);
            this.PasswordTextbox.TabIndex = 1;
            this.PasswordTextbox.Text = "Enter a Password";
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationBtn.Location = new System.Drawing.Point(126, 488);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(109, 39);
            this.RegistrationBtn.TabIndex = 2;
            this.RegistrationBtn.Text = "Sign Up";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // LnkLogin
            // 
            this.LnkLogin.AutoSize = true;
            this.LnkLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLogin.Location = new System.Drawing.Point(96, 568);
            this.LnkLogin.Name = "LnkLogin";
            this.LnkLogin.Size = new System.Drawing.Size(170, 17);
            this.LnkLogin.TabIndex = 4;
            this.LnkLogin.TabStop = true;
            this.LnkLogin.Text = "Already Have An Account?";
            this.LnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLogin_LinkClicked);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::BankManagementSystem.Properties.Resources.Logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(42, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(305, 158);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 3;
            this.LogoPictureBox.TabStop = false;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.EmailTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.EmailTextbox.Location = new System.Drawing.Point(51, 287);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(286, 32);
            this.EmailTextbox.TabIndex = 5;
            this.EmailTextbox.Text = "Enter Your Email";
            this.EmailTextbox.Enter += new System.EventHandler(this.EmailTextbox_Enter);
            this.EmailTextbox.Leave += new System.EventHandler(this.EmailTextbox_Leave);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PhoneTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.PhoneTextBox.Location = new System.Drawing.Point(51, 336);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(286, 32);
            this.PhoneTextBox.TabIndex = 6;
            this.PhoneTextBox.Text = "Enter Your Phone";
            this.PhoneTextBox.Enter += new System.EventHandler(this.PhoneTextBox_Enter);
            this.PhoneTextBox.Leave += new System.EventHandler(this.PhoneTextBox_Leave);
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.AddressTextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.AddressTextbox.Location = new System.Drawing.Point(51, 383);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(286, 32);
            this.AddressTextbox.TabIndex = 7;
            this.AddressTextbox.Text = "Enter Your Address";
            this.AddressTextbox.Enter += new System.EventHandler(this.AddressTextbox_Enter);
            this.AddressTextbox.Leave += new System.EventHandler(this.AddressTextbox_Leave);
            // 
            // Nidtextbox
            // 
            this.Nidtextbox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Nidtextbox.ForeColor = System.Drawing.Color.DarkGray;
            this.Nidtextbox.Location = new System.Drawing.Point(51, 432);
            this.Nidtextbox.Name = "Nidtextbox";
            this.Nidtextbox.Size = new System.Drawing.Size(286, 32);
            this.Nidtextbox.TabIndex = 8;
            this.Nidtextbox.Text = "Enter Your Nation ID no";
            this.Nidtextbox.Enter += new System.EventHandler(this.Nidtextbox_Enter);
            this.Nidtextbox.Leave += new System.EventHandler(this.Nidtextbox_Leave);
            // 
            // RegistrationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 605);
            this.Controls.Add(this.Nidtextbox);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.LnkLogin);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.LinkLabel LnkLogin;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.TextBox Nidtextbox;
    }
}

