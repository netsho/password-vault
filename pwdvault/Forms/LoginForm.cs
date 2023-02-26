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
    public partial class LoginForm : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            UserSuccessfullyAuthenticated = true;
            Close();
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
    }
}
