using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem.Dashboard_Forms
{
    public partial class Tansfer : Form
    {
        private readonly PersonModel customer_Sender;
        private readonly PersonModel customer_Reciver = new CustomerModel();
        public Tansfer(PersonModel customer)
        {
            customer_Sender = customer;
            InitializeComponent();
            UpdateUI();
            TransferUsernameTextBox.Location = new Point(115, 176);
            SearchBtn.Location = new Point(368, 173);
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTextBox.Text, out decimal amount))
            {
                if (amount > 0 && amount <= GetBalance(customer_Sender))
                {
                    Confirmation(new CustomerOperation().UpdateBalance(customer_Sender,  GetBalance(customer_Sender) - amount),
                    new CustomerOperation().UpdateBalance(customer_Reciver, GetBalance(customer_Reciver) + amount));
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
            BalanceLbl.Text = $"Current Balance : { GetBalance(customer_Sender).ToString("N", UILogics.SetPrecision(2)) } $";
            AmountTextBox.Text = AmountBoxPlaceHolderText;
            AmountTextBox.ForeColor = Color.DarkGray;
        }
        private void UpdateReciverInfo()
        {
            try
            {
                DataTable data;
                data = new DataReader().GetSingleData(customer_Reciver, UILogics.IsCustomer(), UILogics.IsEmployee());
                _FullnameLbl.Text = data.Rows[0][1].ToString();
                _eamilLbl.Text = data.Rows[0][2].ToString();

                infoPanel.Visible = true;
                DisplayPicture.Visible = true;
                AmountTextBox.Visible = true;
                TransferBtn.Visible = true;

                TransferUsernameTextBox.Location = new Point(165, 63);
                SearchBtn.Location = new Point(418, 60);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void Confirmation(int SenderRow , int ReciverRow)
        {
             if (SenderRow > 0 && ReciverRow > 0)
                MessageBox.Show("Transfer Succesful.");
            else
                MessageBox.Show("Something Went Wrong!");
        }
        private decimal GetBalance(PersonModel customer)
        {
            DataTable data;
            data = new DataReader().GetSingleData(customer, UILogics.IsCustomer(), UILogics.IsEmployee());
            return (decimal)(data.Rows[0][5]);
        }
        #region place holder
        private void AmountTextBox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: AmountTextBox, placeholder: AmountBoxPlaceHolderText);
        }

        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: AmountTextBox, placeholder: AmountBoxPlaceHolderText);
        }
        private void TransferUsernameTextBox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: TransferUsernameTextBox, placeholder: TransferUserBoxPlaceHolderText);
        }

        private void TransferUsernameTextBox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: TransferUsernameTextBox, placeholder: TransferUserBoxPlaceHolderText);
        }
        #endregion
        #region Readonly Strings
        private readonly string error = "Invalid Amount.";
        private readonly string AmountBoxPlaceHolderText = "Transfer Amount";
        private readonly string TransferUserBoxPlaceHolderText = "Transfer Account Username";
        #endregion

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            customer_Reciver.Username = TransferUsernameTextBox.Text;
            UpdateReciverInfo();
        }
    }
}
