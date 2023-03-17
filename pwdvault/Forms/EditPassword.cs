using pwdvault.Modeles;
using pwdvault.Services;
using Serilog;

namespace pwdvault.Forms
{
    public partial class EditPassword : Form
    {
        UserPassword userPassword;
        public EditPassword(string AppName, string Username)
        {
            InitializeComponent();
            comBoxCat.DataSource = Enum.GetValues(typeof(Categories));
            lbTitle.Text = $"Edit {AppName} password";
            using PasswordVaultContext context = new PasswordVaultContext();
            UserPasswordService userPasswordService = new(context);
            userPassword = userPasswordService.GetUserPassword(AppName, Username);
            txtBoxApp.Text = userPassword.AppName;
            txtBoxApp.ReadOnly = true;
            comBoxCat.Text = userPassword.AppCategory;
            txtBoxUser.Text = userPassword.UserName;
            txtBoxUser.ReadOnly = true;
            txtBoxPwd.Text = EncryptionService.DecryptPassword(userPassword.Password, EncryptionService.GetKeyFromFile());
        }

        private void btnEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxPwd.PasswordChar = '*';
            txtBoxPwd.UseSystemPasswordChar = true;
        }

        private void btnEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPwd.PasswordChar = '\0';
            txtBoxPwd.UseSystemPasswordChar = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxApp.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxUser.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxPwd.Text) &&
                !String.IsNullOrWhiteSpace(comBoxCat.Text) &&
                !errorProvider.HasErrors
                )
            {
                // Encrypt password and store it, success message and hide the form
                try
                {
                    Cursor = Cursors.WaitCursor;
                    byte[] encryptedPassword = EncryptionService.EncryptPassword(txtBoxPwd.Text, EncryptionService.GetKeyFromFile());
                    UserPassword userPasswordEdited = new UserPassword(comBoxCat.Text, encryptedPassword)
                    {
                        Id = userPassword.Id,
                        AppName = userPassword.AppName,
                        UserName = userPassword.UserName,
                        IconName = userPassword.IconName,
                        CreationTime = userPassword.CreationTime,
                        UpdateTime = DateTime.Now
                    };
                    using (var context = new PasswordVaultContext())
                    {
                        UserPasswordService userPasswordService = new(context);
                        userPasswordService.UpdateUserPassword(userPasswordEdited);
                    }
                    Cursor = Cursors.Default;
                    DialogResult result = MessageBox.Show($"{userPasswordEdited.AppName} password has been updated !", "Succes update password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Close();
                    }

                }
                catch (Exception ex)
                {
                    Log.Logger.Error("\nSource : " + ex.Source + "\nMessage : " + ex.Message);
                }
                Close();
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
                errorProvider.SetError(txtBoxPwd, "Password must be atleast 12 characters long and contain the following : " + Environment.NewLine +
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
