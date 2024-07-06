/*
Netsho - Login form. 
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
using pwdvault.Models;
using pwdvault.Services;
using pwdvault.Services.Exceptions;
using pwdvault.Controllers;
using Serilog;
using System.Drawing.Drawing2D;
using System.Configuration;

namespace pwdvault.Forms
{
    public partial class LoginForm : Form
    {
        private readonly string _loginDataPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault"), "LoginData.json");

        public LoginForm()
        {
            InitializeComponent();
            if (!File.Exists(_loginDataPath)) return;
            var loginData = LoginService.RetrieveLoginData();
            txtBoxCA.Text = loginData.CaFilePath;
            txtBoxCertificate.Text = loginData.CertificateFilePath;
            txtBoxKey.Text = loginData.KeyFilePath;
            txtBoxSecretId.Text = loginData.SecretId;
            Height -= splitCollapsing.Panel1.Height;
            splitCollapsing.Panel1Collapsed = true;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUser.Text) || string.IsNullOrWhiteSpace(txtBoxPwd.Text))
            {
                MessageBox.Show("Please fill in username and password.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtBoxCA.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCertificate.Text) ||
                string.IsNullOrWhiteSpace(txtBoxKey.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSecretId.Text))
            {
                MessageBox.Show("Please complete all additional login information fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    LoginService.AddLoginDataConfig(txtBoxCA.Text, txtBoxCertificate.Text, txtBoxKey.Text);

                    var vaultServerUri = ConfigurationManager.AppSettings["VaultServerUri"];
                    var roleId = ConfigurationManager.AppSettings["RoleID"];
                    var secretPath = ConfigurationManager.AppSettings["SecretPath"];
                    if (string.IsNullOrWhiteSpace(vaultServerUri) || string.IsNullOrWhiteSpace(secretPath) ||
                        string.IsNullOrWhiteSpace(roleId))
                    {
                        MessageBox.Show("The configuration file doesn't contain either the vault server URI, role ID or secret path. Please check the file before logging in.", "Invalid configuration file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        VaultController.GetInstance(roleId, txtBoxSecretId.Text, vaultServerUri, secretPath);

                        if (await LoginService.TestPgSqlConnection())
                        {
                            await using var context = new PasswordVaultContext();
                            var userController = new UserController(context);
                            var user = userController.GetUserByUsername(txtBoxUser.Text);
                            if (UserPasswordService.VerifyPassword(txtBoxPwd.Text, user.PasswordSalt, user.PasswordHash))
                            {
                                new MainForm().Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Invalid user's credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            Cursor = Cursors.Default;
                        }
                        else
                        {
                            MessageBox.Show("Failed to connect to the database. Please check your network connection and ensure that your SSL certificates are valid and correctly installed.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cursor = Cursors.Default;
                        }
                    }
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
        }

        private void BtnEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxPwd.PasswordChar = '*';
            txtBoxPwd.UseSystemPasswordChar = true;
        }

        private void BtnEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPwd.PasswordChar = '\0';
            txtBoxPwd.UseSystemPasswordChar = false;
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

        private void LinkLbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUpForm().Show();
        }

        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------ Additional login information events -------------------------------------------------------------------*/
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

        private void CheckBoxInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxInfo.Checked) return;
            if (!string.IsNullOrWhiteSpace(txtBoxCA.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxCertificate.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxKey.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxSecretId.Text))
            {
                LoginService.StoreLoginData(txtBoxCA.Text, txtBoxCertificate.Text, txtBoxKey.Text,
                    txtBoxSecretId.Text);
            }
            else
            {
                MessageBox.Show("Please complete all additional login information fields before saving.",
                    "Incomplete login data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLoginData_Click(object sender, EventArgs e)
        {
            switch (splitCollapsing.Panel1Collapsed)
            {
                case false:
                    Height -= splitCollapsing.Panel1.Height;
                    splitCollapsing.Panel1Collapsed = true;
                    break;
                case true:
                    splitCollapsing.Panel1Collapsed = false;
                    Height += splitCollapsing.Panel1.Height;
                    break;
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/
    }
}
