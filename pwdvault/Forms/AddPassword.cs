using pwdvault.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwdvault.Forms
{
    public partial class AddPassword : Form
    {
        public AddPassword()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtBoxPwd.Text = PasswordService.GeneratePassword();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtBoxApp.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxUser.Text) && 
                !String.IsNullOrWhiteSpace(txtBoxPwd.Text) && 
                !String.IsNullOrWhiteSpace(comBoxCat.Text)) 
            {
                if (PasswordService.IsPasswordStrong(txtBoxPwd.Text))
                {
                    // Encrypt password and store it, success message and hide the form
                    MessageBox.Show("ok");
                } else
                {
                    MessageBox.Show("Password must be atleast 16 characters long and contain the following : " + Environment.NewLine +
                        "- Uppercase" + Environment.NewLine + "- Lowercase" + Environment.NewLine + "- Numbers" + Environment.NewLine + "- Symbols");
                }
            } else
            {
                MessageBox.Show("Please complete all fields.");

            }
        }
    }
}
