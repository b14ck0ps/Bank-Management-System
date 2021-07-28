using BankDatabaseAccess;
using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System.Data;
using System.Windows.Forms;

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
            data = new DataReader().GetData(customer, UILogics.IsCustomer(), UILogics.IsEmployee());
            WelcomeLbl.Text = $"Welcome  { data.Rows[0][0] }";
            _usenameLbl.Text = data.Rows[0][0].ToString();
            _NIDLbl.Text = data.Rows[0][4].ToString();
            _phoneLbl.Text = data.Rows[0][3].ToString();
            _addressLbl.Text = data.Rows[0][6].ToString();
            _eamilLbl.Text = data.Rows[0][2].ToString();
            BalanceLbl.Text = $"Current Balance : { data.Rows[0][5] } Taka";
        }

        private void EditLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visibility(true);
            EditLnk.Visible = false;
        }
        private void UpdateBtn_Click(object sender, System.EventArgs e)
        {
            Visibility(false);
            EditLnk.Visible = true;

            PersonModel personModel = new CustomerModel()
            {
                Username = customer.Username,
                Nid = NidTextbox.Text,
                Address = AddresstextBox.Text,
                Eamil = EmailtextBox.Text,
                Phone = PhoneTextBox.Text,
            };

            UpdatedDB(new CustomerOperation().Update(personModel));
            UpdateUi();
        }
        private void Visibility(bool @bool)
        {
            notChangeableLbl.Visible = @bool;
            NidTextbox.Visible = @bool;
            AddresstextBox.Visible = @bool;
            EmailtextBox.Visible = @bool;
            PhoneTextBox.Visible = @bool;
            UpdateBtn.Visible = @bool;
        }

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
