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
    public partial class LogUI : Form
    {
        public LogUI()
        {
            InitializeComponent();
            ActiveControl = LoginBtn;
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
            
        }

        private void LnkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrationUI().Show();
        }
    }
}
