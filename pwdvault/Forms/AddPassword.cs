using pwdvault.Modeles;
using pwdvault.Services;
using pwdvault.Controllers;
using Serilog;
using System.Text;

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

        private void BtnAdd_Click(object sender, EventArgs e)
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
                        AddPasswordDb();
                    }
                }
                else if (!errorProvider.HasErrors)
                {
                    AddPasswordDb();
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
        /// Encrypts the newly password, creates the corresponding object and saves it in the database, while saving the encryption key in vault.
        /// </summary>
        private void AddPasswordDb()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Encrypt password and store it, success message and hide the form
                var encryptionKey = EncryptionService.GenerateKey(txtBoxPwd.Text);
                var encryptedPassword = EncryptionService.EncryptPassword(txtBoxPwd.Text, encryptionKey);
                var str = Encoding.Default.GetString(encryptionKey);
                var appPassword = new AppPassword(comBoxCat.Text, txtBoxApp.Text, txtBoxUser.Text, encryptedPassword, PasswordService.GetIconName(txtBoxApp.Text)) { CreationTime = DateTime.Now, UpdateTime = DateTime.Now };

                var vaultController = VaultController.GetInstance();
                vaultController.StoreEncryptionKey(txtBoxApp.Text, txtBoxUser.Text, encryptionKey);

                using var context = new PasswordVaultContext();
                var passwordController = new PasswordController(context);
                passwordController.CreatePassword(appPassword);

                Cursor = Cursors.Default;
                MessageBox.Show($"{appPassword.AppName}'s password successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
