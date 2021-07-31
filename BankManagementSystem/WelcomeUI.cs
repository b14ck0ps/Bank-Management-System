using System;
using System.Diagnostics;
using System.Drawing;
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

        private void GitBtn_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo("https://github.com/b14ck0ps/Bank-Management-System"));
    }
}
