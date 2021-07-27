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
    public partial class CustomerDashBoard : Form
    {
        public CustomerDashBoard()
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
        private void HomeBtn_Click(object sender, EventArgs e)
        {
           HomeBtn.BackColor = Color.WhiteSmoke;
           DepositBtn.BackColor = Color.White;
           WithdrawBtn.BackColor = Color.White;
           UILogics.LoadForm(MainPanel,new Dashboard_Forms.Home());
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.White;
            DepositBtn.BackColor = Color.WhiteSmoke;
            WithdrawBtn.BackColor = Color.White;
            UILogics.LoadForm(MainPanel, new Dashboard_Forms.Deposit());
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.White;
            DepositBtn.BackColor = Color.White;
            WithdrawBtn.BackColor = Color.WhiteSmoke;
            UILogics.LoadForm(MainPanel, new Dashboard_Forms.Withdraw());
        }
    }
}
