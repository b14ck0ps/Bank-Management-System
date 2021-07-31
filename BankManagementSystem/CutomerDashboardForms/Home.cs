using BankDatabaseAccess;
using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System;
using System.Data;
using System.Windows.Forms;
using static BankDatabaseAccess.DatabaseConnection;

namespace BankManagementSystem.Dashboard_Forms
{
    public partial class Home : Form
    {
        private readonly PersonModel customer;
        public Home(PersonModel customer)
        {
            this.customer = customer;
            InitializeComponent();
            UpdateUi();
            
        }
        private void UpdateUi()
        {
            DataTable data;
            data = new DataReader().GetSingleData(customer, UILogics.IsCustomer(), UILogics.IsEmployee());
            WelcomeLbl.Text = $"Welcome  { data.Rows[0][0] }";
            _FullnameLbl.Text = data.Rows[0][1].ToString();
            _NIDLbl.Text = data.Rows[0][4].ToString();
            _phoneLbl.Text = data.Rows[0][3].ToString();
            _addressLbl.Text = data.Rows[0][6].ToString();
            _eamilLbl.Text = data.Rows[0][2].ToString();
            _joinDateLbl.Text = data.Rows[0][7].ToString();
            BalanceLbl.Text = $"Current Balance : { data.Rows[0][5] } $";
        }

        private void EditLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FillTextBox();
            EditLnk.Visible = false;
        }
        private void UpdateBtn_Click(object sender, System.EventArgs e)
        {
            PersonModel personModel = new CustomerModel()
            {
                Username = customer.Username,
                Nid = NidTextbox.Text,
                Address = AddresstextBox.Text,
                Eamil = EmailtextBox.Text,
                Phone = PhoneTextBox.Text,
            };
            if (FormValidation())
            {
                Visibility(false);
                UpdatedDB(new CustomerOperation().Update(personModel));
                UpdateBtn.Visible = false;
                EditLnk.Visible = true;
                UpdateUi();
            }
            else
            {
                MessageBox.Show("Enter all the details");
            }
        }
        private void Visibility(bool @bool)
        {
            notChangeableLbl.Visible = @bool;
            NidTextbox.Visible = @bool;
            AddresstextBox.Visible = @bool;
            EmailtextBox.Visible = @bool;
            PhoneTextBox.Visible = @bool;
        }

        private void FillTextBox()
        {
            try
            {
                DataTable data;
                data = new DataReader().GetSingleData(customer, UILogics.IsCustomer(), UILogics.IsEmployee());
                EmailtextBox.Text = data.Rows[0][2].ToString();
                PhoneTextBox.Text = data.Rows[0][3].ToString();
                AddresstextBox.Text = data.Rows[0][6].ToString();
                NidTextbox.Text = data.Rows[0][4].ToString();
                Visibility(true);
                UpdateBtn.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        #region Form validation
        private  bool FormValidation()
        {
            bool output = true;
            if (string.IsNullOrEmpty(EmailtextBox.Text))
            {
                output = false;
            }
            if (string.IsNullOrEmpty(AddresstextBox.Text))
            {
                output = false;
            }
            if (string.IsNullOrEmpty(NidTextbox.Text))
            {
                output = false;
            }
            return output;
        }
        #endregion
        #region Message for Users
        private void UpdatedDB(int EffectedRow)
        {
           if (EffectedRow > 0)
                MessageBox.Show("Update Succesfull.");
            else
                MessageBox.Show("Something Went Wrong!");
        }
        #endregion
    }
}
