/*
Netsho - Password form. 
Copyright (C) 2023-2024 Netsho

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <https://www.gnu.org/licenses/>.
*/
using pwdvault.Modeles;
using pwdvault.Services;
using pwdvault.Services.Exceptions;
using pwdvault.Controllers;
using Serilog;

namespace pwdvault.Forms
{
    public partial class Password : UserControl
    {
        private string _appName = "";
        private string _username = "";
        private string _iconName = "";

        // Define the event to raise after editing or deleting a password.
        public event EventHandler? PasswordEdited;
        public event EventHandler? PasswordDeleted;

        public string AppName
        {
            get { return _appName; }
            set { _appName = value; lbApp.Text = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; lbUser.Text = value; }
        }
        public string IconName
        {
            get { return _iconName; }
            set { _iconName = value; pictureBoxApp.Image = (Image?)Properties.Resources.ResourceManager.GetObject(value); }
        }


        public Password(string appName, string username, string iconName)
        {
            InitializeComponent();
            AppName = appName;
            Username = username;
            IconName = iconName;
        }

        private void Password_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.InactiveBorder;
        }

        private void Password_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                new EditPassword(AppName, Username).ShowDialog();
                OnPasswordEdited();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure to delete {AppName} password?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    using var context = new PasswordVaultContext();
                    var vaultController = VaultController.GetInstance();

                    var passwordController = new PasswordController(context);
                    var password = passwordController.GetPassword(AppName, Username);

                    passwordController.DeletePassword(password.Id);
                    vaultController.DeleteEncryptionKey(AppName, Username);

                    OnPasswordDeleted();
                    Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    if (ex is PasswordException)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
                }
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new PasswordVaultContext();
                var vaultController = VaultController.GetInstance();

                var passwordController = new PasswordController(context);
                var password = passwordController.GetPassword(AppName, Username);
                Clipboard.SetText(EncryptionService.DecryptPassword(password.Password, vaultController.GetEncryptionKey(AppName, Username), password.Bytes));
                ClearClipboardDelayed();
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        /// <summary>
        /// <para>
        /// Creates a new thread that waits for 10 seconds, and then clears the clipboard.
        /// The apartment state of the thread is set to STA (single-threaded apartment) as to interact with only one thread, the clipboard one.
        /// </para>
        /// </summary>
        private static void ClearClipboardDelayed()
        {
            try
            {
                var thread = new Thread(() =>
                {
                    // Wait for 10 seconds
                    Thread.Sleep(10000);

                    // Clear the clipboard
                    Clipboard.Clear();
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please try again later or contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error("Source : " + ex.Source + ", Message : " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        /// <summary>
        /// Raises PasswordEdited event after editing the password.
        /// </summary>
        protected virtual void OnPasswordEdited()
        {
            PasswordEdited?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Raises PasswordDeleted event after deleting the password.
        /// </summary>
        protected virtual void OnPasswordDeleted()
        {
            PasswordDeleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
