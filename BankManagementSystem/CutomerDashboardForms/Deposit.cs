using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem.Dashboard_Forms
{
    public partial class Deposit : Form
    {
        readonly PersonModel customer;
        public Deposit(PersonModel customer)
        {
            this.customer = customer;
            InitializeComponent();
            UpdateUI();
        }
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTextBox.Text, out decimal amount))
            {
                if (amount > 0)
                {
                    Confirmation(new CustomerOperation().UpdateBalance(customer,  GetBalance() + amount));
                    UpdateUI();
                    
                }
                else
                    MessageBox.Show(error);
            }
            else
                MessageBox.Show("Invalid Input");     
        }

        private void UpdateUI()
        {
            BalanceLbl.Text = $"Current Balance : { GetBalance().ToString("N", UILogics.SetPrecision(2)) } $";
            AmountTextBox.Text = PlaceHolderText;
            AmountTextBox.ForeColor = Color.DarkGray;
        }

        private void Confirmation(int EffectedRow)
        {
             if (EffectedRow > 0)
                MessageBox.Show("Deposit Succesfully.");
            else
                MessageBox.Show("Something Went Wrong!");
        }
        private decimal GetBalance()
        {
            DataTable data;
            data = new DataReader().GetSingleData(customer, UILogics.IsCustomer(), UILogics.IsEmployee());
            return (decimal)(data.Rows[0][5]);
        }
        #region place holder
        private void AmountTextBox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: AmountTextBox, placeholder: PlaceHolderText);
        }

        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: AmountTextBox, placeholder: PlaceHolderText);
        }
        #endregion
        #region Readonly Strings
        private readonly string error = "Invalid Amount.";
        private readonly string PlaceHolderText = "Enter Amount You want to deposit";
        #endregion

    }
}
