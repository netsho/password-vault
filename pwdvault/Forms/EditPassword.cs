/*
Netsho - Edit password form. 
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
using pwdvault.Controllers;
using Serilog;
using pwdvault.Services.Exceptions;

namespace pwdvault.Forms
{
    public partial class EditPassword : Form
    {
        private readonly AppPassword _appPassword;
        public EditPassword(string appName, string username)
        {
            try
            {
                InitializeComponent();
                comBoxCat.DataSource = Enum.GetValues(typeof(Categories));
                lbTitle.Text = $"Edit {appName} password";
                using var context = new PasswordVaultContext();
                _appPassword = new PasswordController(context).GetPassword(appName, username);
                txtBoxApp.ReadOnly = true;
                txtBoxApp.Text = _appPassword.AppName;
                comBoxCat.Text = _appPassword.AppCategory;
                txtBoxUser.ReadOnly = true;
                txtBoxUser.Text = _appPassword.UserName;
                var vaultController = VaultController.GetInstance();
                txtBoxPwd.Text = EncryptionService.DecryptPassword(_appPassword.Password, vaultController.GetEncryptionKey(appName, username), _appPassword.Bytes);
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                throw new InvalidOperationException(ex.Message);
            }

        }

        /// <summary>
        /// Encrypts the updated password and updates it on the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxApp.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxUser.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxPwd.Text) &&
                !string.IsNullOrWhiteSpace(comBoxCat.Text))
            {
                switch (errorProvider.HasErrors)
                {
                    case true:
                    {
                        var result = MessageBox.Show("The password does not meet the criteria. Are you sure you want to save it?", "Password criteria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            await EditPasswordDb();
                        }

                        break;
                    }
                    case false:
                        await EditPasswordDb();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            txtBoxPwd.Text = PasswordService.GeneratePassword();
        }

        /// <summary>
        /// If the password is not strong enough, an error is shown to the user with the password's criteria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Encrypts the new password, gets the corresponding object and updates it in the database, while updating the encryption key in vault.
        /// </summary>
        private async Task EditPasswordDb()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var encryptionKey = EncryptionService.GenerateKey(txtBoxPwd.Text);
                var encryptedPassword = EncryptionService.EncryptPassword(txtBoxPwd.Text, encryptionKey, out byte[] bytes);
                var appPasswordEdited = new AppPassword(comBoxCat.Text, _appPassword.AppName, _appPassword.UserName, encryptedPassword, _appPassword.IconName, bytes)
                {
                    Id = _appPassword.Id,
                    CreationTime = _appPassword.CreationTime,
                    UpdateTime = DateTime.Now
                };

                await using var context = new PasswordVaultContext();
                var passwordController = new PasswordController(context);
                passwordController.UpdatePassword(appPasswordEdited);

                var vaultController = VaultController.GetInstance();
                await vaultController.UpdateEncryptionKey(_appPassword.AppName, _appPassword.UserName, encryptionKey);

                Cursor = Cursors.Default;
                MessageBox.Show($"{appPasswordEdited.AppName}'s password successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(
                    ex is PasswordException or ArgumentException
                        ? ex.Message
                        : "An unexpected error occured. Please check the log file or refer to the logs for more details.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                Close();
            }
        }
    }
}
