/*
Netsho - Sign up form. 
Copyright (C) 2023-2024 Netsho

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <https://www.gnu.org/licenses/>.
*/
using Microsoft.EntityFrameworkCore;
using pwdvault.Models;
using pwdvault.Services;
using pwdvault.Services.Exceptions;
using pwdvault.Controllers;
using Serilog;
using System.Drawing.Drawing2D;


namespace pwdvault.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private async void BtnSign_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxUser.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxPwd.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxCA.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxCertificate.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxKey.Text))
            {
                if (!errorProvider.HasErrors) return;
                var result = MessageBox.Show("The password does not meet the criteria. Are you sure you want to save it?", "Password criteria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;
                
                try
                {
                    Cursor = Cursors.WaitCursor;

                    /* --------------------- Create the new user while salting and hashing the user's password */
                    var salt = UserPasswordService.GenerateSalt();
                    var hash = UserPasswordService.GenerateHash(txtBoxPwd.Text, salt);
                    var user = new User(txtBoxUser.Text, hash, salt);

                    /*  -------------------- Creating database connection string */
                    LoginService.AddLoginDataConfig(txtBoxCA.Text, txtBoxCertificate.Text, txtBoxKey.Text);
                    if (!await LoginService.TestPgSqlConnection()) return;
                    /* --------------------- Add the user in database */
                    await using var context = new PasswordVaultContext();
                    await context.Database.MigrateAsync();
                    var userController = new UserController(context);
                    userController.CreateUser(user);

                    Cursor = Cursors.Default;
                    MessageBox.Show("New account successfully created!\nYou can now login to the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(
                        ex is UserException
                            ? ex.Message
                            : "An unexpected error occured. Please try again later or contact the administrator.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Please complete all the fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            txtBoxPwd.Text = PasswordService.GeneratePassword();
        }

        private void TxtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            if (!PasswordService.IsPasswordStrong(txtBoxPwd.Text))
            {
                errorProvider.SetError(txtBoxPwd, "Password should be at least 12 characters long and contain the following : " + Environment.NewLine +
                        "- Uppercase" + Environment.NewLine + "- Lowercase" + Environment.NewLine + "- Numbers" + Environment.NewLine + "- Symbols");
            }
            else
            {
                errorProvider.SetError(txtBoxPwd, string.Empty);
                errorProvider.Clear();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelBanner_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new(Color.FromArgb(34, 193, 195), 1);

            Rectangle rectangleArea = new(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new(rectangleArea, Color.FromArgb(34, 193, 195), Color.FromArgb(253, 187, 45), LinearGradientMode.Horizontal);
            graphics.FillRectangle(lgb, rectangleArea);
            graphics.DrawRectangle(pen, rectangleArea);
        }

        private void BtnFileDialogCA_Click(object sender, EventArgs e)
        {
            var openFileDialogCa = new OpenFileDialog
            {
                Filter = "CA files (*.crt)|*.crt|All files (*.*)|*.*"
            };

            if (openFileDialogCa.ShowDialog() == DialogResult.OK)
            {
                txtBoxCA.Text = openFileDialogCa.FileName;
            }
        }

        private void BtnFileDialogCert_Click(object sender, EventArgs e)
        {
            var openFileDialogCertificate = new OpenFileDialog
            {
                Filter = "Certificate files (*.crt)|*.crt|All files (*.*)|*.*"
            };

            if (openFileDialogCertificate.ShowDialog() == DialogResult.OK)
            {
                txtBoxCertificate.Text = openFileDialogCertificate.FileName;
            }
        }

        private void BtnFileDialogKey_Click(object sender, EventArgs e)
        {
            var openFileDialogKey = new OpenFileDialog
            {
                Filter = "Key files (*.key)|*.key|All files (*.*)|*.*"
            };

            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                txtBoxKey.Text = openFileDialogKey.FileName;
            }
        }
    }
}
