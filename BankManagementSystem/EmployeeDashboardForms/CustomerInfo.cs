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
            // TODO - Fix Balance precision. Only two digit after balance
            // TODO - Fix Account Create Date. Only date will be enough.Time is not needed 
            CustomerdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            CustomerdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
    }
}
