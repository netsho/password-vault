using pwdvault.Modeles;
using pwdvault.Services;

namespace pwdvault.Forms
{
    public partial class Password : UserControl
    {
        private string appName = "";
        private string username = "";
        private string iconName = "";

        public string AppName
        {
            get { return appName; }
            set { appName = value; lbApp.Text = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; lbUser.Text = value; }
        }
        public string IconName
        {
            get { return iconName; }
            set { iconName = value; pictureBoxApp.Image = (Image?)Properties.Resources.ResourceManager.GetObject(value); }
        }


        public Password(string appName, string username, string iconName)
        {
            InitializeComponent();
            if (iconName.Equals("icons8_image_48"))
            {
                AppName = appName;
                Username = username;
                IconName = iconName;
                lbUserTitle.Location = new Point(lbApp.Location.X + lbApp.Width + 15, 11);
                lbUser.Location = new Point(lbApp.Location.X + lbApp.Width + 33, 31);
            }
            else
            {
                AppName = appName;
                Username = username;
                IconName = iconName;
                Controls.Remove(lbApp);
                lbUserTitle.Location = new Point(120, 11);
                lbUser.Location = new Point(138, 31);
            }
        }

        private void Password_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.InactiveBorder;
        }

        private void Password_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new EditPassword(AppName, Username).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure to delete {AppName} password?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                UserPassword userPassword;
                using (var context = new PasswordVaultContext())
                {
                    UserPasswordService userPasswordService = new(context);
                    userPassword = userPasswordService.GetUserPassword(AppName, Username);
                }
                using (var context = new PasswordVaultContext())
                {
                    UserPasswordService userPasswordService = new(context);
                    userPasswordService.DeleteUserPassword(userPassword.Id);
                }

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                UserPassword userPassword = userPasswordService.GetUserPassword(appName, username);
                Clipboard.SetText(EncryptionService.DecryptPassword(userPassword.Password, EncryptionService.GetKeyFromFile()));
                ClearClipboardDelayed();
            }
        }

        /// <summary>
        /// <para>
        /// This method creates a new thread that waits for 5 seconds and then clear the clipboard.
        /// The apartment state of the thread is set to STA as to interact with the clipboard.
        /// </para>
        /// </summary>
        private void ClearClipboardDelayed()
        {
            Thread thread = new Thread(() =>
            {
                // Wait for 5 seconds
                Thread.Sleep(5000);

                // Clear the clipboard
                Clipboard.Clear();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
