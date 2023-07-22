using pwdvault.Modeles;
using pwdvault.Controllers;
using System.Data;

namespace pwdvault.Forms
{
    public partial class MainForm : Form
    {
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        public string _selectedCategory = String.Empty;
        private const int ALL_ROW_INDEX = 10;
        private int _selectedRowIndex = ALL_ROW_INDEX;

        public MainForm()
        {
            InitializeComponent();
            // Attaching the events MouseEnter and MouseLeave for all the cells in the allTable panel
            foreach (Control control in allTable.Controls)
            {
                control.MouseEnter += AllTable_MouseEnter;
                control.MouseLeave += AllTable_MouseLeave;
            }
            // Attaching the events MouseEnter and MouseLeave for all the cells in the categoriesTable panel
            foreach (Control control in categoriesTable.Controls)
            {
                control.MouseEnter += CategoriesTable_MouseEnter;
                control.MouseLeave += CategoriesTable_MouseLeave;
            }
            allTable.GetControlFromPosition(0, 0)!.BackColor = Color.White;
            _selectedCategory = lbAll.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddPassword().ShowDialog();
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*---  When the mouse enters a row in the categories tables panels, the back color changes for this row like it's highlighted. -*/
        /*---  When the mouse leaves the row in the categories tables panels, the back color changes to the original one. --------------*/
        private void AllTable_MouseEnter(object? sender, EventArgs e)
        {
            // Change the back color of the PictureBox and Label controls in the row
            allTable.GetControlFromPosition(1, 0)!.BackColor = Color.FromArgb(160, 108, 125);
            allTable.GetControlFromPosition(2, 0)!.BackColor = Color.FromArgb(160, 108, 125);
        }

        private void AllTable_MouseLeave(object? sender, EventArgs e)
        {
            // Change the back color of the PictureBox and Label controls in the row
            allTable.GetControlFromPosition(1, 0)!.BackColor = Color.FromArgb(195, 141, 158);
            allTable.GetControlFromPosition(2, 0)!.BackColor = Color.FromArgb(195, 141, 158);
        }

        private void CategoriesTable_MouseEnter(object? sender, EventArgs e)
        {
            // Get the row index of the control that raised the event
            var row = categoriesTable.GetRow((Control)sender!);

            // Change the back color of the PictureBox and Label controls in the row
            categoriesTable.GetControlFromPosition(1, row)!.BackColor = Color.FromArgb(160, 108, 125);
            categoriesTable.GetControlFromPosition(2, row)!.BackColor = Color.FromArgb(160, 108, 125);
        }

        private void CategoriesTable_MouseLeave(object? sender, EventArgs e)
        {
            // Get the row index of the control that raised the event
            var row = categoriesTable.GetRow((Control)sender!);

            // Change the back color of the PictureBox and Label controls in the row
            categoriesTable.GetControlFromPosition(1, row)!.BackColor = Color.FromArgb(195, 141, 158);
            categoriesTable.GetControlFromPosition(2, row)!.BackColor = Color.FromArgb(195, 141, 158);
        }
        /*------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------------------------------------*/

        /*-----------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------*/
        /*---  When the mouse is pressed, the _dragging is set to true and gets the window + cursor position ---------------*/
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        /*---  When the mouse is released, the _dragging stops -------------------------------------------------------------*/
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        /*---  With each mouse movement, the window moves by adding values to the location points -------------------------*/
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                var difference = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                Location = Point.Add(_dragFormPoint, new Size(difference));
            }
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------*/

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtBoxFilter.Text.ToLower();
            listPwdPanel.Controls.Clear();
            var passwordUserControls = GetPasswordControls(_selectedCategory);
            var passwordUserControlsFiltred = new List<Password>();
            foreach (Password passwordUserControl in passwordUserControls)
            {
                if (passwordUserControl.AppName.ToLower().Contains(filterText))
                {
                    passwordUserControlsFiltred.Add(passwordUserControl);
                }
            }
            UpdatePasswordControls(passwordUserControlsFiltred);

            if (string.IsNullOrWhiteSpace(txtBoxFilter.Text))
            {
                UpdatePasswordControls(GetPasswordControls(_selectedCategory));
            }
        }

        private void LbAll_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbAll.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbAdmini_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbAdmini.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbWork_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbWork.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbStudy_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbStudy.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbSocial_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbSocial.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbRetail_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbRetail.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbFinance_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbFinance.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbGames_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbGames.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbCoding_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbCoding.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        /// <summary>
        /// <para>
        /// Function to get the list of appPassword user controls based on the selected category of the user.
        /// The passwords are retrieved from the database, and then filtred by selected category.
        /// When creating each appPassword user control, we're subscribing to passwordEdited and passwordDeleted events to update the appPassword user controls list.
        /// </para>
        /// </summary>
        /// <param name="selectedCategory"></param>
        /// <returns></returns>
        private static List<Password> GetPasswordControls(string selectedCategory)
        {
            var passwordControls = new List<Password>();
            List<AppPassword> passwords;
            using (var context = new PasswordVaultContext())
            {
                var passwordController = new PasswordController(context);
                passwords = passwordController.GetAllPasswords();
            }
            if (selectedCategory.Equals("All"))
            {
                foreach (var appPassword in passwords)
                {
                    var password = new Password(appPassword.AppName, appPassword.UserName, appPassword.IconName);
                    passwordControls.Add(password);
                }
            }
            else
            {
                passwords = passwords.Where(password => password.AppCategory.Equals(selectedCategory)).ToList();
                foreach (var appPassword in passwords)
                {
                    var password = new Password(appPassword.AppName, appPassword.UserName, appPassword.IconName);
                    passwordControls.Add(password);
                }
            }
            return passwordControls;
        }

        /// <summary>
        /// Function to clear the panel and update the appPassword user controls in the panel
        /// </summary>
        /// <param name="passwords"></param>
        private void UpdatePasswordControls(List<Password> passwordControls)
        {
            listPwdPanel.Controls.Clear();
            var controlTop = 5;
            foreach (Password passwordControl in passwordControls)
            {
                passwordControl.Width = listPwdPanel.Width - 30;
                passwordControl.Location = new Point(0, controlTop);
                passwordControl.PasswordEditedOrDeleted += OnPasswordEditOrDelete;
                controlTop += passwordControl.Height + 5;
                listPwdPanel.Controls.Add(passwordControl);
            }
        }

        /// <summary>
        /// Event handler raised when a appPassword is edited or deleted to update the passwords list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPasswordEditOrDelete(object? sender, EventArgs e)
        {
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        /// <summary>
        /// <para>
        /// Function that adds a white strip left of the selected category, to highlight to the user which category is selected.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        private void ShowSelectedCategory(object sender)
        {
            if (_selectedRowIndex == ALL_ROW_INDEX)
            {
                // if the sender is not the category "All", else do nothing.
                if (!((Control)sender).Name.Equals("lbAll") && !((Control)sender).Name.Equals("allPicture"))
                {
                    allTable.GetControlFromPosition(0, 0)!.BackColor = Color.FromArgb(195, 141, 158);
                    // Get the row index of the control that raised the event
                    var row = categoriesTable.GetRow((Control)sender);
                    // Change the back color of left column to show which category is selected
                    categoriesTable.GetControlFromPosition(0, row)!.BackColor = Color.White;
                    _selectedRowIndex = row;
                }
            }
            else
            {
                // If the sender is category "All"
                if (((Control)sender).Name.Equals("lbAll") || ((Control)sender).Name.Equals("allPicture"))
                {
                    categoriesTable.GetControlFromPosition(0, _selectedRowIndex)!.BackColor = Color.FromArgb(195, 141, 158);
                    // Change the back color of left column to show which category is selected
                    allTable.GetControlFromPosition(0, 0)!.BackColor = Color.White;
                    _selectedRowIndex = ALL_ROW_INDEX;
                }
                else
                {
                    categoriesTable.GetControlFromPosition(0, _selectedRowIndex)!.BackColor = Color.FromArgb(195, 141, 158);
                    // Get the row index of the control that raised the event
                    var row = categoriesTable.GetRow((Control)sender);
                    categoriesTable.GetControlFromPosition(0, row)!.BackColor = Color.White;
                    _selectedRowIndex = row;
                }
            }
        }
    }
}