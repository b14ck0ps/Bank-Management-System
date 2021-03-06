using BankDatabaseAccess.EntityModel;
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
    public partial class EmployeeDashBoard : Form
    {
        private readonly PersonModel personModel;
        public EmployeeDashBoard(PersonModel personModel)
        {
            this.personModel = personModel;
            InitializeComponent();
            Load += DashBoard_Shown;
        }

        private void DashBoard_Shown(object sender, EventArgs e)
        {
            HomeBtn.PerformClick();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginUI().Show();
        }
        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.WhiteSmoke;
            CustomerInfoBtn.BackColor = Color.White;
            EditInfoBtn.BackColor = Color.White;
            DepositBtn.BackColor = Color.White;
            DeleteLnkVisible(true);
            UILogics.LoadForm(MainPanel, new EmployeeDashboardForms.Home(personModel));
        }

        private void CustomerInfoBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.White;
            CustomerInfoBtn.BackColor = Color.WhiteSmoke;
            EditInfoBtn.BackColor = Color.White;
            DepositBtn.BackColor = Color.White;
            DeleteLnkVisible(false);
            UILogics.LoadForm(MainPanel, new EmployeeDashboardForms.CustomerInfo());
        }

        private void EditInfoBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.White;
            CustomerInfoBtn.BackColor = Color.White;
            EditInfoBtn.BackColor = Color.WhiteSmoke;
            DepositBtn.BackColor = Color.White;
            DeleteLnkVisible(false);
            UILogics.LoadForm(MainPanel, new EmployeeDashboardForms.EditInfo());
        }

        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new LoginUI().Show();
        }

        private void DeleteLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UILogics.DeleteWarning(personModel))
            {
                Close();
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.White;
            CustomerInfoBtn.BackColor = Color.White;
            EditInfoBtn.BackColor = Color.White;
            DepositBtn.BackColor = Color.WhiteSmoke;
            DeleteLnkVisible(false);
            UILogics.LoadForm(MainPanel, new EmployeeDashboardForms.Deposit());
        }
        private void DeleteLnkVisible(bool @bool)
        {
            DeleteLnk.Visible = @bool;
            DeleteAccountLbl.Visible = @bool;
        }
    }
}
