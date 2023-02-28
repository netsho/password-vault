using pwdvault.Services;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwdvault.Forms
{
    public partial class SignInForm : Form
    {
        private string folderPath;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxUser.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxPwd.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxDb.Text) &&
                !String.IsNullOrWhiteSpace(folderPath)
                )
            {
                if (PasswordService.IsPasswordStrong(txtBoxPwd.Text))
                {
                    // Encrypt password and store it, success message and hide the form
                    MessageBox.Show("ok");
                    Close();
                }
                else
                {
                    MessageBox.Show("Password must be atleast 16 characters long and contain the following : " + Environment.NewLine +
                        "- Uppercase" + Environment.NewLine + "- Lowercase" + Environment.NewLine + "- Numbers" + Environment.NewLine + "- Symbols");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields and create the database.");

            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtBoxPwd.Text = PasswordService.GeneratePassword();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderPath = dialog.FileName;
                MessageBox.Show("You selected: " + Environment.NewLine + folderPath);
            }
        }
    }
}
