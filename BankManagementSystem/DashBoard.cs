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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginUI().Show(); 
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
           UILogics.LoadForm(MainPanel,new Dashboard_Forms.Home());
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            UILogics.LoadForm(MainPanel, new Dashboard_Forms.Deposit());
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            UILogics.LoadForm(MainPanel, new Dashboard_Forms.Withdraw());
        }
    }
}
