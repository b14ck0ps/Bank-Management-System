using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
            ActiveControl = LoginBtn;
            if (UILogics.IsCustomer())
            {
                Text = "Login As Customer";
            }
            if (UILogics.IsEmployee())
            {
                Text = "Log In as Employee";
            }
            
        }
        #region place holder logics
        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox:UsernameTextbox,placeholder: "Username");
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: UsernameTextbox, placeholder: "Username");
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: PasswordTextbox, placeholder: "Password");
        }
        
        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: PasswordTextbox, placeholder: "Password");
        }

        #endregion

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerDashBoard().Show();
        }

        private void LnkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrationUI().Show();
        }
    }
}
