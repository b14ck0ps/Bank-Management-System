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
        #region form load logic
        /// <summary>
        /// This method will load forms inside of the main panel
        /// </summary>
        /// <param name="Form">Enter the form you want to load</param>
        private void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }
        #endregion

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard_Forms.Home());
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard_Forms.Deposit());
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard_Forms.Withdraw());
        }
    }
}
