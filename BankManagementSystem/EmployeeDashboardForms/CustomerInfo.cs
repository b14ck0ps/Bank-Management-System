using BankDatabaseAccess.DatabaseOperation;
using System.Windows.Forms;

namespace BankManagementSystem.EmployeeDashboardForms
{
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
            CustomerdataGridView.DataSource = new DataReader().GetAllData(customer: true);
            GridStyle();
        }
        private void GridStyle()
        {
            CustomerdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            CustomerdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            //[4] is Money coloumn and C2 is Money Format String
            CustomerdataGridView.Columns[4].DefaultCellStyle.Format = "C2";
            //[6] is Join Date coloumn and d is Standard Date Format String
            CustomerdataGridView.Columns[6].DefaultCellStyle.Format = "d";
        }
    }
}
