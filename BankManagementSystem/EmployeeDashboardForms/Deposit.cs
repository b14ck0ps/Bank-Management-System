using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System.Data;
using System.Windows.Forms;

namespace BankManagementSystem.EmployeeDashboardForms
{
    public partial class Deposit : Form
    {
        private readonly PersonModel customer = new CustomerModel();
        public Deposit()
        {
            InitializeComponent();
        }
        private void UpdateUi()
        {
            try
            {
                DataTable data;
                data = new DataReader().GetSingleData(customer, customer: true, employee: false);
                _FullnameLbl.Text = data.Rows[0][1].ToString();
                _NIDLbl.Text = data.Rows[0][4].ToString();
                _phoneLbl.Text = data.Rows[0][3].ToString();
                _addressLbl.Text = data.Rows[0][6].ToString();
                _eamilLbl.Text = data.Rows[0][2].ToString();
                _joinDateLbl.Text = data.Rows[0][7].ToString();
                BalanceLbl.Text = $"Current Balance : { ((decimal)(data.Rows[0][5])).ToString("N", UILogics.SetPrecision(2)) } $";
                VisibleInfo(true);
            }
            catch (System.Exception)
            {

                MessageBox.Show(error);
            }
            
        }

        private void SearchBtn_Click(object sender, System.EventArgs e)
        {
            customer.Username = UsernameTextBox.Text;
            UpdateUi();
        }
        private void VisibleInfo(bool @bool)
        {
            DescriptionLbl.Visible = @bool;
            infoPanel.Visible = @bool;
            BalanceLbl.Visible = @bool;
            DisplayPicture.Visible = @bool;
            CardPicture.Visible = @bool;
            _FullnameLbl.Visible = @bool;
            NameLbl.Visible = @bool;
            _NIDLbl.Visible = @bool;
            NidLbl.Visible = @bool;
            _addressLbl.Visible = @bool;
            AddressLbl.Visible = @bool;
            _eamilLbl.Visible = @bool;  
            emailLbl.Visible = @bool;
            _phoneLbl.Visible = @bool;
            PhoneLbl.Visible = @bool;
            _joinDateLbl.Visible = @bool;
            JoinDateLbl.Visible = @bool;
        }
        private const string error = "Invalid User";
        private const string UsernamePlaceHolder = "Customer Username";
        private const string DipositPlaceHolder = "Enter Deposit Amount";
        #region place holder logic
        private void UsernameTextBox_Enter(object sender, System.EventArgs e)
        {
            UILogics.EnterUpdate(UsernameTextBox, UsernamePlaceHolder);
        }

        private void UsernameTextBox_Leave(object sender, System.EventArgs e)
        {
            UILogics.LeaveUpdate(UsernameTextBox, UsernamePlaceHolder);
        }

        private void AmountTextBox_Enter(object sender, System.EventArgs e)
        {
            UILogics.EnterUpdate(AmountTextBox, DipositPlaceHolder);
        }

        private void AmountTextBox_Leave(object sender, System.EventArgs e)
        {
            UILogics.LeaveUpdate(AmountTextBox, DipositPlaceHolder);
        }
        #endregion

        private void DepositBtn_Click(object sender, System.EventArgs e)
        {
            if (decimal.TryParse(AmountTextBox.Text, out decimal amount))
            {
                if (amount > 0)
                {
                    Confirmation(new CustomerOperation().UpdateBalance(customer, GetBalance() + amount));
                    AmountTextBox.Clear();
                    UpdateUi();
                }
                else
                    MessageBox.Show(error);
            }
            else
                MessageBox.Show("Invalid Input");
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
            data = new DataReader().GetSingleData(customer, customer: true, employee:false);
            return (decimal)(data.Rows[0][5]);
        }
    }
}
