using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public static class UILogics 
    {
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
    }
    

}
