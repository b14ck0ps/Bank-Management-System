using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Dashboard_Forms
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        #region place holder
        private void AmountTextBox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox:AmountTextBox, placeholder: "Enter Amount You want to deposit");
        }

        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: AmountTextBox, placeholder: "Enter Amount You want to deposit");
        }
        #endregion
    }
}
