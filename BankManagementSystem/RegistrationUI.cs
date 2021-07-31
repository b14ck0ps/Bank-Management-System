using BankDatabaseAccess;
using BankDatabaseAccess.DatabaseOperation;
using BankDatabaseAccess.EntityModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class RegistrationUI : Form
    {
        public RegistrationUI()
        {
            InitializeComponent();
            ActiveControl = RegistrationBtn;
            if (UILogics.IsCustomer())
            {
                Text = "Registration For Customer Account";
            }
            if (UILogics.IsEmployee())
            {
                Text = "Registration For Employee Account";
            }
        }
        #region Place Holder logics
        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: UsernameTextbox, placeholder: UsernamePlaceholder);
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: UsernameTextbox, placeholder: UsernamePlaceholder);
        }
        private void FullNametextBox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: FullNametextBox, placeholder: FullnamePlaceholder);
        }

        private void FullNametextBox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: FullNametextBox, placeholder: FullnamePlaceholder);
        }
        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: PasswordTextbox, placeholder: PasswordPlaceholder);
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: PasswordTextbox, placeholder: PasswordPlaceholder);
        }

        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: EmailTextbox, placeholder: EmailPlaceholder);
        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: EmailTextbox, placeholder: EmailPlaceholder);
        }

        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: PhoneTextBox, placeholder: PhonePlaceholder);
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: PhoneTextBox, placeholder: PhonePlaceholder);
        }

        private void AddressTextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: AddressTextbox, placeholder: AddressPlaceholder);
        }

        private void AddressTextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: AddressTextbox, placeholder: AddressPlaceholder);
        }

        private void Nidtextbox_Enter(object sender, EventArgs e)
        {
            UILogics.EnterUpdate(textBox: Nidtextbox, placeholder: NidPlaceholder);
        }

        private void Nidtextbox_Leave(object sender, EventArgs e)
        {
            UILogics.LeaveUpdate(textBox: Nidtextbox, placeholder: NidPlaceholder);
        }
        #endregion
        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            PersonModel User = new CustomerModel
            {
                Username = UsernameTextbox.Text,
                FullName = FullNametextBox.Text,
                Password = PasswordTextbox.Text,
                Eamil = EmailTextbox.Text,
                Phone = PhoneTextBox.Text,
                Nid = Nidtextbox.Text,
                Address = AddressTextbox.Text
            };
            if (ValidForm())
            {
                if (UILogics.IsEmployee())
                    UpdatedDB(new EmployeeOperations().Insert(User));
                if (UILogics.IsCustomer())
                    UpdatedDB(new CustomerOperation().Insert(User));
            }else
                MessageBox.Show("Please Enter all the details");
        }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Close();
            new LoginUI().Show();
        }
        #region Form validation logics
        private bool ValidForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(UsernameTextbox.Text) || UsernameTextbox.Text == UsernamePlaceholder)
            {
                UsernameTextbox.ForeColor = Color.OrangeRed;
                output = false;
            }
            if (string.IsNullOrEmpty(FullNametextBox.Text) || FullNametextBox.Text == FullnamePlaceholder)
            {
                FullNametextBox.ForeColor = Color.OrangeRed;
                output = false;
            }
            if (string.IsNullOrEmpty(PasswordTextbox.Text) || PasswordTextbox.Text == PasswordPlaceholder)
            {
                PasswordTextbox.ForeColor = Color.OrangeRed;
                output = false;
            }
            if (string.IsNullOrEmpty(EmailTextbox.Text) || EmailTextbox.Text == EmailPlaceholder)
            {
                EmailTextbox.ForeColor = Color.OrangeRed;
                output = false;
            }
            //optional
            //if (string.IsNullOrEmpty(PhoneTextBox.Text) || PhoneTextBox.Text == PhonePlaceholder)
            //{
            //    PhoneTextBox.ForeColor = Color.OrangeRed;
            //    output = false;
            //}
            if (string.IsNullOrEmpty(Nidtextbox.Text) || Nidtextbox.Text == NidPlaceholder)
            {
                Nidtextbox.ForeColor = Color.OrangeRed;
                output = false;
            }
            if (string.IsNullOrEmpty(AddressTextbox.Text) || AddressTextbox.Text == AddressPlaceholder)
            {
                AddressTextbox.ForeColor = Color.OrangeRed;
                output = false;
            }
            return output;
        }
        #endregion
        #region Message for Users
        private void UpdatedDB(int EffectedRow)
        {
            if (EffectedRow == (int)DatabaseConnection.Error.UsernameExist)
            {
                MessageBox.Show("Username Already Exist!");

            }
            else if (EffectedRow > 0)
            {
                MessageBox.Show("Account Created Succesfully.");
                this.Close();
                new LoginUI().Show();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
        #endregion
        #region placeholder strings
        private const string UsernamePlaceholder = "Enter a Username";
        private const string FullnamePlaceholder = "Enter Your Full Name";
        private const string PasswordPlaceholder = "Enter a Password";
        private const string EmailPlaceholder = "Enter Your Email";
        private const string PhonePlaceholder = "Enter Your Phone";
        private const string AddressPlaceholder = "Enter Your Address";
        private const string NidPlaceholder = "Enter Your Nation ID no";
        #endregion
    }
}
