using BankDatabaseAccess.EntityModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class CustomerDashBoard : Form
    {
        private readonly PersonModel personModel;
        public CustomerDashBoard(PersonModel customer)
        {
            personModel = customer;
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
           UILogics.LoadForm(MainPanel,new Dashboard_Forms.Home(personModel));
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
