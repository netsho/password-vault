﻿using pwdvault.Modeles;
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
                        var userManager = new UserManager(context);
                        var users = userManager.GetUsers();
                        var user = users[0];
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                        Log.Logger.Error("\nSource : " + ex.Source + "\nMessage : " + ex.Message);
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
