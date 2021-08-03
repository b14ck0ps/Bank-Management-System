using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace BankManagementSystem.EmployeeDashboardForms
{
    public partial class Home : Form
    {
        private readonly PersonModel employee;
        public Home(PersonModel employee)
        {
            this.employee = employee;
            InitializeComponent();
            UpdateUi();

        }

        private void EditLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FillTextBox();
            EditLnk.Visible = false;
            UpdateBtn.Visible = true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            employee.Username = employee.Username;
            employee.Nid = NidTextbox.Text;
            employee.Address = AddresstextBox.Text;
            employee.Eamil = EmailtextBox.Text.ToLower();
            employee.Phone = PhoneTextBox.Text;
            if (FormValidation())
            {
                Visibility(false);
                UpdatedDB(new EmployeeOperations().SelfUpdate(employee));
                UpdateUi();
                UpdateBtn.Visible = false;
                EditLnk.Visible = true;
            }
            else
            {
                MessageBox.Show("Enter Full all informations");
            }
            
        }

        private void UpdateUi()
        {
            DataTable data;
            data = new DataReader().GetSingleData(employee, UILogics.IsCustomer(), UILogics.IsEmployee());
            WelcomeLbl.Text = $"Welcome  { data.Rows[0][0] }";
            SalaryLbl.Text = $"Salary : { data.Rows[0][5] } $";
            _FullnameLbl.Text = data.Rows[0][1].ToString();
            _NIDLbl.Text = data.Rows[0][4].ToString();
            _phoneLbl.Text = data.Rows[0][3].ToString();
            _addressLbl.Text = data.Rows[0][6].ToString();
            _eamilLbl.Text = data.Rows[0][2].ToString();
        }
        private void FillTextBox()
        {
            try
            {
                DataTable data;
                data = new DataReader().GetSingleData(employee, UILogics.IsCustomer(), UILogics.IsEmployee());
                EmailtextBox.Text = data.Rows[0][2].ToString();
                PhoneTextBox.Text = data.Rows[0][3].ToString();
                AddresstextBox.Text = data.Rows[0][6].ToString();
                NidTextbox.Text = data.Rows[0][4].ToString();
                Visibility(true);
            }
            catch (Exception)
            {
                throw;
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
        #region Form validation
        private bool FormValidation()
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
            if (string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                employee.Phone = "N/A";
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
