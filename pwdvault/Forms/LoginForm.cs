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

namespace pwdvault.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUser.Text) || string.IsNullOrWhiteSpace(txtBoxPwd.Text))
            {
                MessageBox.Show("Please fill in username and password.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var loginDataForm = new LoginDataForm();
                var dialogResult = await Task.Run(() => loginDataForm.ShowDialog());
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;

                        using var context = new PasswordVaultContext();
                        var userController = new UserController(context);
                        var user = userController.GetUserByUsername(txtBoxUser.Text);
                        if (UserPasswordService.VerifyPassword(txtBoxPwd.Text, user.PasswordSalt, user.PasswordHash))
                        {
                            //new MainForm().Show();
                            //Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Invalid user's credentiels", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        if (ex is UserException)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                    }
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
            Pen pen = new(Color.FromArgb(0, 57, 115), 1);

            Rectangle rectangleArea = new(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new(rectangleArea, Color.FromArgb(0, 57, 115), Color.FromArgb(229, 229, 190), LinearGradientMode.Horizontal);
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
            if (checkBoxInfo.Checked)
            {
                StoreLoginData();
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/
    }
}
