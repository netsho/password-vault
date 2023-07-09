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
            if (String.IsNullOrWhiteSpace(txtBoxCA.Text) ||
                String.IsNullOrWhiteSpace(txtBoxCertificate.Text) ||
                String.IsNullOrWhiteSpace(txtBoxKey.Text) ||
                String.IsNullOrWhiteSpace(txtBoxSecretId.Text))
            {
                MessageBox.Show("Please complete all fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void BtnFileDialog_Click(object sender, EventArgs e)
        {
            var openFileDialogCertificate = new OpenFileDialog
            {
                Filter = "Certificates (*.crt)|(*.crt) | All files (*.*)|(*.*)"
            };

            if (openFileDialogCertificate.ShowDialog() == DialogResult.OK)
            {
                txtBoxCA.Text = openFileDialogCertificate.FileName;
            }
        }

        private void BtnFileDialogCert_Click(object sender, EventArgs e)
        {

        }

        private void BtnFileDialogKey_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxInfo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxInfo.CheckState == CheckState.Checked)
            {

            }
        }
    }
}
