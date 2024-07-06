/*
Netsho - Add password form. 
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
    public partial class AddPassword : Form
    {
        public AddPassword()
        {
            InitializeComponent();
            comBoxCat.DataSource = Enum.GetValues(typeof(Categories));
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            txtBoxPwd.Text = PasswordService.GeneratePassword();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
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
                            await AddPasswordDb();
                        }

                        break;
                    }
                    case false:
                        await AddPasswordDb();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        /// Encrypts the new password, creates the corresponding object and saves it in the database, while saving the encryption key in vault.
        /// </summary>
        private async Task AddPasswordDb()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Encrypt password and store it, display success message and hide the form
                var encryptionKey = EncryptionService.GenerateKey(txtBoxPwd.Text);
                var encryptedPassword = EncryptionService.EncryptPassword(txtBoxPwd.Text, encryptionKey, out byte[] bytes);
                var appPassword = new AppPassword(comBoxCat.Text, txtBoxApp.Text, txtBoxUser.Text, encryptedPassword, PasswordService.GetIconName(txtBoxApp.Text), bytes) { CreationTime = DateTime.Now, UpdateTime = DateTime.Now };

                await using var context = new PasswordVaultContext();
                var passwordController = new PasswordController(context);
                passwordController.CreatePassword(appPassword);

                var vaultController = VaultController.GetInstance();
                await vaultController.StoreEncryptionKey(txtBoxApp.Text, txtBoxUser.Text, encryptionKey);

                Cursor = Cursors.Default;
                MessageBox.Show($"{appPassword.AppName}'s password successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(
                    ex is PasswordException or ArgumentException
                        ? ex.Message
                        : "An unexpected error occured. Please try again later or refer to the logs for more details.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                Close();
            }
        }
    }
}
