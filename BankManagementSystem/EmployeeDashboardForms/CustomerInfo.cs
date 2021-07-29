using BankDatabaseAccess.DatabaseOperation;
using System.Windows.Forms;

namespace BankManagementSystem.EmployeeDashboardForms
{
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
            GridStyle();
            CustomerdataGridView.DataSource = new DataReader().GetAllData(customer: true);
        }
        private void GridStyle()
        {
            CustomerdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            CustomerdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
    }
}
