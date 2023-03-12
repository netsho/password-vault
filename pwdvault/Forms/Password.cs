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
    public partial class Password : UserControl
    {
        private string appName;
        private string username;

        public string AppName
        {
            get { return appName; }
            set { appName = value; lbApp.Text = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; lbUser.Text = value; }
        }

        public Password(string appName, string username)
        {
            InitializeComponent();
            AppName = appName;
            Username = username;
        }

        private void Password_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.InactiveBorder;
        }

        private void Password_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new EditPassword(AppName).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure to delete {AppName} password?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }
    }
}
