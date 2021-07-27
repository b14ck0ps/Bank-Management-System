using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankManagementSystem
{
    public partial class RegistrationUI : Form
    {
        public RegistrationUI()
        {
            InitializeComponent();
            ActiveControl = RegistrationBtn;
            if (UILogics.IsCustomer())
            {
                Text = "Registration For Customer Account";
            }
            if (UILogics.IsEmployee())
            {
                Text = "Registration For Employee Account";
            }
        }
        #region Place Holder logics
        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: UsernameTextbox, placeholder: "Enter a Username");
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: UsernameTextbox, placeholder: "Enter a Username");
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: PasswordTextbox, placeholder: "Enter a Password");
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: PasswordTextbox, placeholder: "Enter a Password");
        }

        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: EmailTextbox, placeholder: "Enter Your Email");
        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: EmailTextbox, placeholder: "Enter Your Email");
        }

        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: PhoneTextBox, placeholder: "Enter Your Phone");
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: PhoneTextBox, placeholder: "Enter Your Phone");
        }

        private void AddressTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: AddressTextbox, placeholder: "Enter Your Address");
        }

        private void AddressTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: AddressTextbox, placeholder: "Enter Your Address");
        }

        private void Nidtextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: Nidtextbox, placeholder: "Enter Your Nation ID no");
        }

        private void Nidtextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: Nidtextbox, placeholder: "Enter Your Nation ID no");
        }
        #endregion
        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            //TODO - Add registraion Logics
            //TODO - Save data into the data base
        }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Close();
            new LoginUI().Show();
        }
    }
}
