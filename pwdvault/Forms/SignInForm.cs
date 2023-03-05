using pwdvault.Modeles;
using pwdvault.Services;
using Serilog;


namespace pwdvault.Forms
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxUser.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxPwd.Text) &&
                !errorProvider.HasErrors
                )
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    byte[] generatedKey = EncryptionService.GenerateKey(txtBoxPwd.Text);
                    // V2 : Store the key in HashiCorp Vault and encrypt database file
                    string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    string passwordVaultFolderPath = Path.Combine(appDataPath, "PasswordVault");
                    string keyFilePath = Path.Combine(passwordVaultFolderPath, "fileKey");
                    File.WriteAllBytes(keyFilePath, generatedKey);

                    /* --------------------- Create the database PasswordVault and the passwords table */
                    using (var context = new PasswordVaultContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                    }
                    Cursor = Cursors.Default;
                    MessageBox.Show("New account created successfully !\nPassword Vault database created successfully !", "Successful creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new MainForm().Show();
                    Close();
                }
                catch (Exception ex)
                {
                    Log.Logger.Error("\nSource : " + ex.Source + "\nMessage : " + ex.Message);
                }                
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtBoxPwd.Text = PasswordService.GeneratePassword();
        }

        private void txtBoxPwd_TextChanged(object sender, EventArgs e)
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
    }
}
