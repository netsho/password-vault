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
using pwdvault.Modeles;
using pwdvault.Services;
using pwdvault.Services.Exceptions;
using pwdvault.Controllers;
using Serilog;


namespace pwdvault.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxUser.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxPwd.Text))
            {
                if (errorProvider.HasErrors)
                {
                    var result = MessageBox.Show("The password does not meet the criteria. Are you sure you want to save it?", "Password criteria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var dialogResult = new LoginDataForm().ShowDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            try
                            {
                                Cursor = Cursors.WaitCursor;

                                /* --------------------- Create the new user while salting and hashing the user's password */
                                var salt = UserPasswordService.GenerateSalt();
                                var hash = UserPasswordService.GenerateHash(txtBoxPwd.Text, salt);
                                var user = new User(txtBoxUser.Text, hash, salt);

                                /* --------------------- Add the user in database */
                                using var context = new PasswordVaultContext();
                                context.Database.Migrate();
                                var userController = new UserController(context);
                                userController.CreateUser(user);

                                Cursor = Cursors.Default;
                                MessageBox.Show("New account successfully created!\nYou can now login to the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
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
                                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                            }
                        }
                    }
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

        private void TxtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            if (!PasswordService.IsPasswordStrong(txtBoxPwd.Text))
            {
                errorProvider.SetError(txtBoxPwd, "Password must be atleast 16 characters long and contain the following : " + Environment.NewLine +
                        "- Uppercase" + Environment.NewLine + "- Lowercase" + Environment.NewLine + "- Numbers" + Environment.NewLine + "- Symbols");
            }
            else
            {
                errorProvider.SetError(txtBoxPwd, String.Empty);
                errorProvider.Clear();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
