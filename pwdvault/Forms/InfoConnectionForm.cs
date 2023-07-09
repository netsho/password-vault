using pwdvault.Modeles;
using pwdvault.Services;
using Serilog;

namespace pwdvault.Forms
{
    public partial class InfoConnectionForm : Form
    {
        private readonly string username;
        private readonly string password;

        public InfoConnectionForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxCertificate.Text) || String.IsNullOrWhiteSpace(txtBoxSecretId.Text))
            {
                MessageBox.Show("Please fill in database's certificate and vault's secret id.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    using var context = new PasswordVaultContext();
                    var userService = new UserService(context);
                    var userAccounts = userService.GetUserAccounts();
                    var userAccount = userAccounts[0];
                    if (username.Equals(userAccount.Username) &&
                        AccountPasswordSecurity.VerifyPassword(password, userAccount.PasswordSalt, userAccount.PasswordHash))
                    {
                        new MainForm().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Invalid user's credentiels", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor = Cursors.Default;
                    Log.Logger.Error("\nSource : " + ex.Source + "\nMessage : " + ex.Message);
                    Close();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
