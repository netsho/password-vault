using pwdvault.Modeles;
using pwdvault.Services;
using pwdvault.Services.Exceptions;
using pwdvault.Controllers;
using Serilog;

namespace pwdvault.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxUser.Text) || String.IsNullOrWhiteSpace(txtBoxPwd.Text))
            {
                MessageBox.Show("Please fill in username and password.", "Incomplete form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var dialogResult = new LoginDataForm(txtBoxUser.Text).ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;

                        using var context = new PasswordVaultContext();
                        var userController = new UserController(context);
                        var user = userController.GetUserByUsername(txtBoxUser.Text);
                        if (txtBoxUser.Text.Equals(user.Username) &&
                            UserPasswordSecurity.VerifyPassword(txtBoxPwd.Text, user.PasswordSalt, user.PasswordHash))
                        {
                            new MainForm().Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Invalid user's credentiels", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Cursor = Cursors.Default;
                    }
                    catch (UserException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                        Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                        Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                    }

                } 
                else
                {
                    Show();
                }
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

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();
        }
    }
}
