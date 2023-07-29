using pwdvault.Modeles;
using pwdvault.Services;
using pwdvault.Controllers;
using Serilog;
using pwdvault.Services.Exceptions;

namespace pwdvault.Forms
{
    public partial class EditPassword : Form
    {
        private readonly AppPassword appPassword;
        public EditPassword(string appName, string username)
        {
            try
            {
                InitializeComponent();
                comBoxCat.DataSource = Enum.GetValues(typeof(Categories));
                lbTitle.Text = $"Edit {appName} password";
                using var context = new PasswordVaultContext();
                appPassword = new PasswordController(context).GetPassword(appName, username);
                txtBoxApp.Text = appPassword.AppName;
                txtBoxApp.ReadOnly = true;
                comBoxCat.Text = appPassword.AppCategory;
                txtBoxUser.Text = appPassword.UserName;
                txtBoxUser.ReadOnly = true;
                var vaultController = VaultController.GetInstance();
                txtBoxPwd.Text = EncryptionService.DecryptPassword(appPassword.Password, vaultController.GetEncryptionKey(appName, username));
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                throw new Exception(ex.Message);
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

        /// <summary>
        /// Encrypts the updated password and updates it on the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxApp.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxUser.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxPwd.Text) &&
                !String.IsNullOrWhiteSpace(comBoxCat.Text))
            {
                if (errorProvider.HasErrors)
                {
                    var result = MessageBox.Show("The password does not meet the criteria. Are you sure you want to save it?", "Password criteria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        EditPasswordDb();
                    }
                }
                else if (!errorProvider.HasErrors)
                {
                    EditPasswordDb();
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
                errorProvider.SetError(txtBoxPwd, "Password must be atleast 12 characters long and contain the following : " + Environment.NewLine +
                        "- Uppercase" + Environment.NewLine + "- Lowercase" + Environment.NewLine + "- Numbers" + Environment.NewLine + "- Symbols");
            }
            else
            {
                errorProvider.SetError(txtBoxPwd, String.Empty);
                errorProvider.Clear();
            }
        }

        /// <summary>
        /// Encrypts the newly password, gets the corresponding object and updates it in the database, while updating the encryption key in vault.
        /// </summary>
        private void EditPasswordDb()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var encryptionKey = EncryptionService.GenerateKey(txtBoxPwd.Text);
                var encryptedPassword = EncryptionService.EncryptPassword(txtBoxPwd.Text, encryptionKey);
                var appPasswordEdited = new AppPassword(comBoxCat.Text, appPassword.AppName, appPassword.UserName, encryptedPassword, appPassword.IconName)
                {
                    Id = appPassword.Id,
                    CreationTime = appPassword.CreationTime,
                    UpdateTime = DateTime.Now
                };

                using var context = new PasswordVaultContext();
                var passwordController = new PasswordController(context);
                passwordController.UpdatePassword(appPasswordEdited);

                var vaultController = VaultController.GetInstance();
                vaultController.UpdateEncryptionKey(appPassword.AppName, appPassword.UserName, encryptionKey);

                Cursor = Cursors.Default;
                MessageBox.Show($"{appPasswordEdited.AppName}'s password successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                Close();
            }
        }
    }
}
