using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace BankManagementSystem.EmployeeDashboardForms
{
    public partial class EditInfo : Form
    {
        private readonly PersonModel customer = new CustomerModel();
        public EditInfo()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            customer.Username = UsernameTextbox.Text;
            FillTextBox();
            
        }

        private void ReadOnlyMode(bool @bool)
        {
            
            EmailTextbox.ReadOnly = @bool;
            PhoneTextBox.ReadOnly = @bool;
            AddressTextbox.ReadOnly = @bool;
            Nidtextbox.ReadOnly = @bool;
        }

        private void FillTextBox()
        {
            try
            {
                DataTable data;
                data = new DataReader().GetSingleData(customer, customer: true, employee: false);
                EmailTextbox.Text = data.Rows[0][2].ToString();
                PhoneTextBox.Text = data.Rows[0][3].ToString();
                AddressTextbox.Text = data.Rows[0][6].ToString();
                Nidtextbox.Text = data.Rows[0][4].ToString();
                BalanceTextBox.Text = ((decimal)(data.Rows[0][5])).ToString("N", UILogics.SetPrecision(2)) + " $";
                ReadOnlyMode(false);
            }
            catch (Exception)
            {
                MessageBox.Show(error);
            }
        
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            customer.Eamil = EmailTextbox.Text.ToLower();
            customer.Phone = PhoneTextBox.Text;
            customer.Nid = Nidtextbox.Text;
            customer.Address = AddressTextbox.Text;
            if (FormValidation())
            {
                if (new EmployeeOperations().Update(customer) > 0)
                {
                    MessageBox.Show($" {customer.Username} INFO Updated");
                    ; ClearFilds();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            else
            {
                MessageBox.Show("Enter All the information");
            }
        
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (new EmployeeOperations().Delete(customer) > 0)
            {
                ClearFilds();
                MessageBox.Show("User Deleted");
            }
            else
            {
                MessageBox.Show(error);
            }  
        }

        private void ClearFilds()
        {
            ReadOnlyMode(true);
            UsernameTextbox.Text = null;
            EmailTextbox.Text = null;
            PhoneTextBox.Text = null;
            AddressTextbox.Text = null;
            Nidtextbox.Text = null;
            BalanceTextBox.Text = null;
        }
        #region Form validation Logics
        private bool FormValidation()
        {
            bool output = true;
            if (string.IsNullOrEmpty(UsernameTextbox.Text))
            {
                output = false;
            }
            if (string.IsNullOrEmpty(EmailTextbox.Text))
            {
                output = false;
            }
            if (string.IsNullOrEmpty(AddressTextbox.Text))
            {
                output = false;
            }
            if (string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                customer.Phone = "N/A";
            }
                if (string.IsNullOrEmpty(Nidtextbox.Text))
            {
                output = false;
            }
            return output;
        }
        #endregion
        private const string error = "Invalid Username";
    }
}
