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
        private const int ALL_ROW_INDEX = 10;
        private int selectedRowIndex = ALL_ROW_INDEX;

        public MainForm()
        {
            InitializeComponent();
            // Attaching the events MouseEnter and MouseLeave for all the cells in the allTable panel
            foreach (Control control in allTable.Controls)
            {
                control.MouseEnter += allTable_MouseEnter;
                control.MouseLeave += allTable_MouseLeave;
            }
            // Attaching the events MouseEnter and MouseLeave for all the cells in the categoriesTable panel
            foreach (Control control in categoriesTable.Controls)
            {
                control.MouseEnter += categoriesTable_MouseEnter;
                control.MouseLeave += categoriesTable_MouseLeave;
            }
            allTable.GetControlFromPosition(0, 0)!.BackColor = Color.White;
            selectedCategory = lbAll.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddPassword().ShowDialog();
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*---  When the mouse enters a row in the categories tables panels, the back color changes for this row like it's highlighted. -*/
        /*---  When the mouse leaves the row in the categories tables panels, the back color changes to the original one. --------------*/
        private void allTable_MouseEnter(object? sender, EventArgs e)
        {
            // Change the back color of the PictureBox and Label controls in the row
            allTable.GetControlFromPosition(1, 0)!.BackColor = Color.FromArgb(160, 108, 125);
            allTable.GetControlFromPosition(2, 0)!.BackColor = Color.FromArgb(160, 108, 125);
        }

        private void allTable_MouseLeave(object? sender, EventArgs e)
        {
            // Change the back color of the PictureBox and Label controls in the row
            allTable.GetControlFromPosition(1, 0)!.BackColor = Color.FromArgb(195, 141, 158);
            allTable.GetControlFromPosition(2, 0)!.BackColor = Color.FromArgb(195, 141, 158);
        }

        private void categoriesTable_MouseEnter(object? sender, EventArgs e)
        {
            // Get the row index of the control that raised the event
            int row = categoriesTable.GetRow((Control)sender!);

            // Change the back color of the PictureBox and Label controls in the row
            categoriesTable.GetControlFromPosition(1, row)!.BackColor = Color.FromArgb(160, 108, 125);
            categoriesTable.GetControlFromPosition(2, row)!.BackColor = Color.FromArgb(160, 108, 125);
        }

        private void categoriesTable_MouseLeave(object? sender, EventArgs e)
        {
            // Get the row index of the control that raised the event
            int row = categoriesTable.GetRow((Control)sender!);

            // Change the back color of the PictureBox and Label controls in the row
            categoriesTable.GetControlFromPosition(1, row)!.BackColor = Color.FromArgb(195, 141, 158);
            categoriesTable.GetControlFromPosition(2, row)!.BackColor = Color.FromArgb(195, 141, 158);
        }
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/

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
            foreach (Password passwordUserControl in passwordUserControls)
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
            ShowSelectedCategory(sender);
            selectedCategory = lbAll.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbAdmini_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            selectedCategory = lbAdmini.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbWork_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            selectedCategory = lbWork.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbStudy_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            selectedCategory = lbStudy.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbSocial_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            selectedCategory = lbSocial.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbRetail_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            selectedCategory = lbRetail.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbFinance_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            selectedCategory = lbFinance.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbGames_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            selectedCategory = lbGames.Text;
            UpdatePasswordUserControls(GetPasswordUserControls(selectedCategory));
        }

        private void lbCoding_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
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
        private void UpdatePasswordUserControls(List<Password> passwordUserControls)
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

        /// <summary>
        /// <para>
        /// Function that adds a white strip left of the selected category, to highlight to the user which category is selected.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        private void ShowSelectedCategory(object sender)
        {
            if (selectedRowIndex == ALL_ROW_INDEX)
            {
                // if the sender is not the category "All", else do nothing.
                if (!((Control)sender).Name.Equals("lbAll") && !((Control)sender).Name.Equals("allPicture"))
                {
                    allTable.GetControlFromPosition(0, 0)!.BackColor = Color.FromArgb(195, 141, 158);
                    // Get the row index of the control that raised the event
                    int row = categoriesTable.GetRow((Control)sender);
                    // Change the back color of left column to show which category is selected
                    categoriesTable.GetControlFromPosition(0, row)!.BackColor = Color.White;
                    selectedRowIndex = row;
                }
            }
            else
            {
                // If the sender is category "All"
                if (((Control)sender).Name.Equals("lbAll") || ((Control)sender).Name.Equals("allPicture"))
                {
                    categoriesTable.GetControlFromPosition(0, selectedRowIndex)!.BackColor = Color.FromArgb(195, 141, 158);
                    // Change the back color of left column to show which category is selected
                    allTable.GetControlFromPosition(0, 0)!.BackColor = Color.White;
                    selectedRowIndex = ALL_ROW_INDEX;
                }
                else
                {
                    categoriesTable.GetControlFromPosition(0, selectedRowIndex)!.BackColor = Color.FromArgb(195, 141, 158);
                    // Get the row index of the control that raised the event
                    int row = categoriesTable.GetRow((Control)sender);
                    categoriesTable.GetControlFromPosition(0, row)!.BackColor = Color.White;
                    selectedRowIndex = row;
                }
            }
        }
    }
}