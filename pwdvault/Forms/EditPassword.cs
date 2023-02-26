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
    public partial class EditPassword : Form
    {
        public EditPassword()
        {
            InitializeComponent();
        }

        private void btnEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxPwd.PasswordChar = '*';
            txtBoxPwd.UseSystemPasswordChar = true;
        }

        private void btnEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPwd.PasswordChar = '\0';
            txtBoxPwd.UseSystemPasswordChar = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxApp.Text) ||
                String.IsNullOrWhiteSpace(txtBoxUser.Text) ||
                String.IsNullOrWhiteSpace(txtBoxPwd.Text) ||
                String.IsNullOrWhiteSpace(comBoxCat.Text))
            {
                MessageBox.Show("Please complete all fields.");
            }
            else
            {

            }
        }
    }
}
