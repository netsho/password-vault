using pwdvault.Modeles;
using pwdvault.Services;
using System.Data;


namespace pwdvault.Forms
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public string selectedCategory = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            selectedCategory = lbAll.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddPassword().ShowDialog();
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        /*-----------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------*/
        /*---  When the mouse is pressed, the dragging is set to true and gets the window + cursor position ---------------*/
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        /*---  When the mouse is released, the dragging stops -------------------------------------------------------------*/
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        /*---  With each mouse movement, the window moves by adding values to the location points -------------------------*/
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(difference));
            }
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtBoxFilter.Text.ToLower();
            listPwdPanel.Controls.Clear();
            List<Password> passwordUserControls = GetPasswordUserControls(selectedCategory);
            List<Password> passwordUserControlsFiltred = new List<Password>();
            foreach(Password passwordUserControl in passwordUserControls)
            {
                if (passwordUserControl.AppName.ToLower().IndexOf(filterText) >= 0)
                {
                    passwordUserControlsFiltred.Add(passwordUserControl);
                }
            }
            UpdatePasswordUserControls(passwordUserControlsFiltred);

            if (string.IsNullOrWhiteSpace(txtBoxFilter.Text))
            {
                UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
            }
        }

        private void lbAll_Click(object sender, EventArgs e)
        {
            selectedCategory = lbAll.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbAdmini_Click(object sender, EventArgs e)
        {
            selectedCategory = lbAdmini.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbWork_Click(object sender, EventArgs e)
        {
            selectedCategory = lbWork.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbStudy_Click(object sender, EventArgs e)
        {
            selectedCategory = lbStudy.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbSocial_Click(object sender, EventArgs e)
        {
            selectedCategory = lbSocial.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbRetail_Click(object sender, EventArgs e)
        {
            selectedCategory = lbRetail.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbFinance_Click(object sender, EventArgs e)
        {
            selectedCategory = lbFinance.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbGames_Click(object sender, EventArgs e)
        {
            selectedCategory = lbGames.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbCoding_Click(object sender, EventArgs e)
        {
            selectedCategory = lbCoding.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        /// <summary>
        /// <para>
        /// Function to get the list of password user controls based on the selected category of the user.
        /// The passwords are retrieved from the database, and then filtred by selected category.
        /// When creating each password user control, we're subscribing to passwordEdited and passwordDeleted events to update the password user controls list.
        /// </para>
        /// </summary>
        /// <param name="selectedCategory"></param>
        /// <returns></returns>
        private List<Password> GetPasswordUserControls(string selectedCategory)
        {
            List<Password> passwordUserControls = new List<Password>();
            List<UserPassword> passwords;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            if (selectedCategory.Equals("All"))
            {
                foreach (UserPassword userPassword in passwords)
                {
                    Password password = new Password(userPassword.AppName, userPassword.UserName, userPassword.IconName);
                    passwordUserControls.Add(password);
                }
            }
            else
            {
                passwords = passwords.Where(userPassword => userPassword.AppCategory.Equals(selectedCategory)).ToList();
                foreach (UserPassword userPassword in passwords)
                {
                    Password password = new Password(userPassword.AppName, userPassword.UserName, userPassword.IconName);
                    passwordUserControls.Add(password);
                }
            }
            return passwordUserControls;
        }

        /// <summary>
        /// Function to clear the panel and update the password user controls in the panel
        /// </summary>
        /// <param name="passwords"></param>
        public void UpdatePasswordUserControls(List<Password> passwordUserControls)
        {
            listPwdPanel.Controls.Clear();
            int controlTop = 5;
            foreach (Password passwordUserControl in passwordUserControls)
            {
                passwordUserControl.Width = listPwdPanel.Width - 30;
                passwordUserControl.Location = new Point(0, controlTop);
                controlTop += passwordUserControl.Height + 5;
                listPwdPanel.Controls.Add(passwordUserControl);
            }
        }
    }
}
