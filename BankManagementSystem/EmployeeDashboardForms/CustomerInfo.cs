using BankDatabaseAccess.DatabaseOperation;
using System.Windows.Forms;

namespace BankManagementSystem.EmployeeDashboardForms
{
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
            CustomerdataGridView.DataSource = new DataReader().GetAllData(true);
        }
    }
}
