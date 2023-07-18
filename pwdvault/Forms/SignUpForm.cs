using Microsoft.EntityFrameworkCore;
using pwdvault.Modeles;
using pwdvault.Services;
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
                !String.IsNullOrWhiteSpace(txtBoxPwd.Text) &&
                !errorProvider.HasErrors
                )
            {
                var dialogResult = new LoginDataForm(txtBoxUser.Text).ShowDialog();
                if(dialogResult == DialogResult.OK )
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;

                        /* --------------------- Create the new user while salting and hashing the user's password */
                        Log.Logger.Information("Generating salt for user's password...");
                        var salt = AccountPasswordSecurity.GenerateSalt();
                        Log.Logger.Information("Generating hash for user's password...");
                        var hash = AccountPasswordSecurity.GenerateHash(txtBoxPwd.Text, salt);
                        var user = new User(txtBoxUser.Text, hash, salt);

                        /* --------------------- Add the user in database */
                        using var context = new PasswordVaultContext();
                        context.Database.Migrate();
                        var userService = new UserService(context);
                        userService.CreateUserAccount(user);

                        Cursor = Cursors.Default;
                        MessageBox.Show("New account successfully created!\nYou can now login to the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                        Log.Logger.Error("\nSource : " + ex.Source + "\nMessage : " + ex.Message);
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
