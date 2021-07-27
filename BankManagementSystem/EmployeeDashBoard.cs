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
        public EmployeeDashBoard()
        {
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
            UILogics.LoadForm(MainPanel, new EmployeeDashboardForms.Home());
        }

        private void CustomerInfoBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.White;
            CustomerInfoBtn.BackColor = Color.WhiteSmoke;
            EditInfoBtn.BackColor = Color.White;
            UILogics.LoadForm(MainPanel, new EmployeeDashboardForms.CustomerInfo());
        }

        private void EditInfoBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.White;
            CustomerInfoBtn.BackColor = Color.White;
            EditInfoBtn.BackColor = Color.WhiteSmoke;
            UILogics.LoadForm(MainPanel, new EmployeeDashboardForms.EditInfo());
        }
    }
}
