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

                    /* --------------------- Create the new user while salting and hashing the user's password */
                    var salt = AccountPasswordSecurity.GenerateSalt();
                    var hash = AccountPasswordSecurity.GenerateHash(txtBoxPwd.Text, salt);
                    User user = new User(txtBoxUser.Text, hash, salt);
                    
                    /* --------------------- Create the database PasswordVault, the user and passwords table, insert the user into user table */
                    using (var context = new PasswordVaultContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                        UserService userService = new UserService(context);
                        userService.CreateUserAccount(user);
                    }
                    Cursor = Cursors.Default;
                    MessageBox.Show("New account created successfully !\nPassword Vault database created successfully !\nYou can login to the application now.", "Successful creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
