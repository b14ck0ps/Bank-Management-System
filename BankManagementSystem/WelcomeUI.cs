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
    public partial class WelcomeUI : Form
    {
        public WelcomeUI()
        {
            InitializeComponent();
        }

        private void AppCloseLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetStartedBtn_Click(object sender, EventArgs e)
        {
            UILogics.User = UILogics.UserType.Customer;
            this.Hide();
            new LoginUI().Show();
        }

        private void EmpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UILogics.User = UILogics.UserType.Employee;
            this.Hide();
            new LoginUI().Show();
        }

        private void GetStartedBtn_MouseHover(object sender, EventArgs e)
        {
            GetStartedBtn.Size = new Size(177, 67);
        }

        private void GetStartedBtn_MouseLeave(object sender, EventArgs e)
        {
            GetStartedBtn.Size = new Size(175, 65);
        }
    }
}
