using BankDatabaseAccess.EntityModel;
using BankDatabaseAccess.DatabaseOperation;
using System;
using System.Windows.Forms;
using System.Data;

namespace BankManagementSystem
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
            ActiveControl = LoginBtn;
            if (UILogics.IsCustomer())
            {
                Text = "Login As Customer";
            }
            if (UILogics.IsEmployee())
            {
                Text = "Log In as Employee";
            }
            
        }
        #region place holder logics
        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox:UsernameTextbox,placeholder: "Username");
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: UsernameTextbox, placeholder: "Username");
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: PasswordTextbox, placeholder: "Password");
        }
        
        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: PasswordTextbox, placeholder: "Password");
        }

        #endregion

        private void LoginBtn_Click(object sender, EventArgs e)
        {
             DataTable data;
             string username, password;

            if (UILogics.IsCustomer())
            {
                
                PersonModel customerModel = new CustomerModel
                {
                    Username = UsernameTextbox.Text,
                    Password = PasswordTextbox.Text
                };
                try
                {
                     data = new DataReader().GetSingleData(customerModel, UILogics.IsCustomer(), UILogics.IsEmployee());
                     username = data.Rows[0][0].ToString();
                     password = data.Rows[0][8].ToString();
                    if (Authentication(username, password))
                    {
                        new CustomerDashBoard(customerModel).Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(error);
                }
                    
            }

            if (UILogics.IsEmployee())
            {
                PersonModel EmployeeModel = new EmployeeModel
                {
                    Username = UsernameTextbox.Text,
                    Password = PasswordTextbox.Text
                };
                try
                {
                    data = new DataReader().GetSingleData(EmployeeModel, UILogics.IsCustomer(), UILogics.IsEmployee());
                    username = data.Rows[0][0].ToString();
                    password = data.Rows[0][7].ToString();
                    if (Authentication(username, password))
                    {
                        new EmployeeDashBoard(EmployeeModel).Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(error);
                }
                 
                    
            }
            
        }

        private void LnkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrationUI().Show();
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            new WelcomeUI().Show();
        }

        private void HomeLbl_Click(object sender, EventArgs e)
        {
            this.Close();
            new WelcomeUI().Show();
        }

        private bool Authentication(string Username, string Password)
        {
            if (UsernameTextbox.Text == Username && PasswordTextbox.Text == Password)
                return true;
           else
                return false;
        }
        private readonly string error = "Username or password is not correct!";
    }
}
