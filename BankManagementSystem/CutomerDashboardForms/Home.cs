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
            WelcomeLbl.Text = $"Welcome  { data.Rows[0][0] }";
            _usenameLbl.Text = data.Rows[0][0].ToString();
            _NIDLbl.Text = data.Rows[0][4].ToString();
            _phoneLbl.Text = data.Rows[0][3].ToString();
            _addressLbl.Text = data.Rows[0][6].ToString();
            _eamilLbl.Text = data.Rows[0][2].ToString();
            BalanceLbl.Text = $"Current Balance : { data.Rows[0][5] } Taka";
        }

    }
}
