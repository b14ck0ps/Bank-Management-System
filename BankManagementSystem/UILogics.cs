using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public static class UILogics 
    {
        public static UserType User;
        public static PasswordError passwordError;
        
        public enum UserType
        {
            Employee,
            Customer    
        }

        public enum PasswordError
        {
            NUllPassword,
            LessThenEightChar,
            NoUpperCaseChar
        }
        public static bool IsCustomer()
        {
            if (User == UserType.Customer)
                   return true;           
            return false;
        }
        public static bool IsEmployee()
        {
            if (User == UserType.Employee)
                return true;
            return false;
        }

        /// <summary>
        /// Using for place holder When enter to make the field empty
        /// </summary>
        /// <param name="textBox">Enter the textBox component (name)</param>
        /// <param name="placeholder">Enter tetxBox component TEXT string</param>
        public static void EnterUpdate(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Using for place holder after leave empty to change it back to "Placeholder" string
        /// </summary>
        /// <param name="textBox">Enter the textBox component (name)</param>
        /// <param name="placeholder">Enter tetxBox component TEXT string</param>
        public static void LeaveUpdate(TextBox textBox, string placeholder)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.DarkGray;
            }
        }
        /// <summary>
        /// This method load form inside a panel
        /// </summary>
        /// <param name="panel">Enter the panel you want to load the form</param>
        /// <param name="form">Enter the form you want to load inside the panel</param>
        public static void LoadForm(Panel panel,Form form)
        {
            if (panel.Controls.Count > 0) { 
                panel.Controls.RemoveAt(0); }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }
        /// <summary>
        /// This method Change decimal value precision
        /// </summary>
        /// <param name="n">Number Digit you want after . </param>
        /// <returns>NumberFormatInfo object. It should be use inside  ToString() to properly work</returns>
        public  static NumberFormatInfo SetPrecision(int n)
        {
            return new NumberFormatInfo
            {
                NumberDecimalDigits = n
            };
        }
        /// <summary>
        /// Check if user input is atleast 8 char long and atleast contain one Uppercase Char
        /// </summary>
        /// <param name="password">string</param>
        /// <returns>true if input is atleast 8 char long and atleast contain one Uppercase Char</returns>
        public static bool PasswordChekcer(TextBox password)
        {
            //bool output = true;
            if (string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please Enter Password");
                return false;
            }
            if (password.Text.Length <= 8)
            {
                MessageBox.Show("Please Enter More Than 8 Charecter Password");
                return false;
            }
            if (!Regex.Match(password.Text, @"[A-Z]+", RegexOptions.ECMAScript).Success)
            {
                MessageBox.Show("Please Enter At least One Upercase Charecter Password");
                return false;
            }
            return true;
        }
    }
}
