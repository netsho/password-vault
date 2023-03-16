using pwdvault.Modeles;
using pwdvault.Services;
using Serilog;

namespace pwdvault.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxUser.Text) || String.IsNullOrWhiteSpace(txtBoxPwd.Text))
            {
                MessageBox.Show("Please fill in username and password.", "Incomplete login form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    using (var context = new PasswordVaultContext())
                    {
                        UserService userService = new UserService(context);
                        List<User> userAccounts = userService.GetUserAccounts();
                        User userAccount = userAccounts[0];
                        if (txtBoxUser.Text.Equals(userAccount.Username) &&
                            AccountPasswordSecurity.VerifyPassword(txtBoxPwd.Text, userAccount.PasswordSalt, userAccount.PasswordHash))
                        {
                            new MainForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("The username and/or password is incorrect.", "Username/Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Cursor = Cursors.Default;
                    }
                }
                catch (Exception ex)
                {
                    Log.Logger.Error("\nSource : " + ex.Source + "\nMessage : " + ex.Message);
                }
            }
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new SignInForm().Show();
        }
    }
}
