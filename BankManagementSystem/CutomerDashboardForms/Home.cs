using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System.Data;
using System.Windows.Forms;

namespace BankManagementSystem.Dashboard_Forms
{
    public partial class Home : Form
    {
        PersonModel customer;
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
            WelcomeLbl.Text = $"Welcome { data.Rows[0][0] }";
            NameLbl.Text = $"Username : { data.Rows[0][0] }";
            NidLbl.Text = $"NID       : { data.Rows[0][4] }";
            PhoneLbl.Text = $"Phone   : { data.Rows[0][3] }";
            AddressLbl.Text = $"Address   : { data.Rows[0][6] }";
            BalanceLbl.Text = $"Current Balance : { data.Rows[0][5] } Taka";
        }
    }
}
