/*
Netsho - Main form. 
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
using pwdvault.Models;
using pwdvault.Controllers;
using pwdvault.Services;
using Serilog;

namespace pwdvault.Forms
{
    public partial class MainForm : Form
    {
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        private string _selectedCategory;
        private const int AllRowIndex = 10;
        private int _selectedRowIndex = AllRowIndex;

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
            if (new AddPassword().ShowDialog() == DialogResult.OK)
            {
                UpdatePasswordControls(GetPasswordControls(_selectedCategory));
            }
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
            if (!_dragging) return;
            var difference = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(difference));
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------*/

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                List<AppPassword> passwords;
                // Get all the passwords
                using (var context = new PasswordVaultContext())
                {
                    var passwordController = new PasswordController(context);
                    passwords = passwordController.GetAllPasswords();
                }
                // Export the passwords in a CSV file
                PasswordService.ExportPasswords(passwords);
                Cursor = Cursors.Default;
                MessageBox.Show($"Passwords successfully exported at {Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault")}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(
                    ex is ArgumentException
                        ? ex.Message
                        : "An unexpected error occured. Please try again later or contact the administrator.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
            }
        }

        private async void BtnImport_Click(object sender, EventArgs e)
        {
            var openFileDialogCsv = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (openFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    await PasswordService.ImportPasswords(openFileDialogCsv.FileName);
                    Cursor = Cursors.Default;
                    MessageBox.Show($"Passwords successfully imported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSelectedCategory(lbAll);
                    UpdatePasswordControls(GetPasswordControls(lbAll.Text));
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(
                        ex is ArgumentException
                            ? ex.Message
                            : "An unexpected error occured. Please try again later or contact the administrator.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Logger.Error(ex, "Source : {Source}, Message : {Message}\n {StackTrace}", ex.Source, ex.Message, ex.StackTrace);
                }
            }
        }

        private void TxtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtBoxFilter.Text.ToLower();
            List<Password> passwordUserControls = GetPasswordControls(_selectedCategory);

            if (string.IsNullOrWhiteSpace(txtBoxFilter.Text))
            {
                // If the filter text is empty, display all controls
                UpdatePasswordControls(passwordUserControls);
            }
            else
            {
                // Filter the controls based on the filter text
                List<Password> passwordUserControlsFiltered = passwordUserControls.Where(p => p.AppName.Contains(filterText, StringComparison.CurrentCultureIgnoreCase)).ToList();
                UpdatePasswordControls(passwordUserControlsFiltered);
            }
        }

        private void LbAll_Click(object sender, EventArgs e)
        {
            ShowSelectedCategory(sender);
            _selectedCategory = lbAll.Text;
            UpdatePasswordControls(GetPasswordControls(_selectedCategory));
        }

        private void LbAdministrative_Click(object sender, EventArgs e)
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
        /// Gets the list of appPassword user controls based on the selected category of the user.
        /// The passwords are retrieved from the database, and then filtered by selected category.
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

                passwords = selectedCategory.Equals("All")
                    ? passwordController.GetAllPasswords()
                    : passwordController.GetPasswordByCategory(selectedCategory);
            }

            foreach (var appPassword in passwords)
            {
                var password = new Password(appPassword.AppName, appPassword.UserName, appPassword.IconName);
                passwordControls.Add(password);
            }

            return passwordControls;
        }

        /// <summary>
        /// Clears the panel and update the appPassword user controls in the panel.
        /// </summary>
        /// <param name="passwordControls"></param>
        private void UpdatePasswordControls(List<Password> passwordControls)
        {
            listPwdPanel.Controls.Clear();
            lbCount.Text = passwordControls.Count.ToString();
            int controlTop = 5;
            passwordControls.Sort((p1, p2) => string.Compare(p1.AppName, p2.AppName, StringComparison.OrdinalIgnoreCase));
            foreach (var passwordControl in passwordControls)
            {
                passwordControl.Width = listPwdPanel.Width - 40;
                passwordControl.Location = new Point(0, controlTop);
                passwordControl.PasswordEdited += OnPasswordEdit;
                passwordControl.PasswordDeleted += OnPasswordDelete;
                controlTop += passwordControl.Height + 5;
                listPwdPanel.Controls.Add(passwordControl);
            }
        }

        /// <summary>
        /// Repositions the password controls in the panel starting from the given index.
        /// </summary>
        /// <param name="startIndex"></param>
        private void RepositionPasswordControls(int startIndex)
        {
            // Get the Y point of the Control before the start.
            int controlTop = startIndex > 0 ?
                listPwdPanel.Controls[startIndex - 1].Location.Y + listPwdPanel.Controls[startIndex - 1].Height + 5
                : 5;

            for (int i = startIndex; i < listPwdPanel.Controls.Count; i++)
            {
                Control control = listPwdPanel.Controls[i];
                control.Location = new Point(0, controlTop);
                controlTop += control.Height + 5;
            }
        }

        /// <summary>
        /// Event handler raised when an appPassword is edited to update the passwords list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPasswordEdit(object? sender, EventArgs e)
        {
            using var context = new PasswordVaultContext();
            AppPassword appPassword = new PasswordController(context).GetPassword(((Password)sender!).AppName, ((Password)sender).Username);
            if (_selectedCategory != lbAll.Text && _selectedCategory != appPassword.AppCategory)
            {
                OnPasswordDelete(sender, e);
            }
        }

        /// <summary>
        /// Event handler raised when an appPassword is deleted to update the passwords list, without clearing the list to improve performance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPasswordDelete(object? sender, EventArgs e)
        {
            // Find the index of the Password to delete
            int passwordIndex = listPwdPanel.Controls.IndexOf((Password)sender!);
            if (passwordIndex == -1) return;
            listPwdPanel.Controls.RemoveAt(passwordIndex);
            lbCount.Text = (int.Parse(lbCount.Text) - 1).ToString();
            RepositionPasswordControls(passwordIndex);
        }

        /// <summary>
        /// <para>
        /// Adds a white strip left of the selected category, to highlight to the user which category is selected.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        private void ShowSelectedCategory(object sender)
        {
            Control senderControl = (Control)sender;
            bool isAllCategory = senderControl.Name.Equals("lbAll") || senderControl.Name.Equals("allPicture");
            if (_selectedRowIndex == AllRowIndex)
            {
                // if the sender is not the category "All", else do nothing.
                if (isAllCategory) return;
                allTable.GetControlFromPosition(0, 0)!.BackColor = Color.FromArgb(195, 141, 158);
                UpdateSelectedCategory(senderControl);
            }
            else
            {
                // If the sender is category "All"
                if (isAllCategory)
                {
                    categoriesTable.GetControlFromPosition(0, _selectedRowIndex)!.BackColor = Color.FromArgb(195, 141, 158);
                    // Change the back color of left column to show which category is selected
                    allTable.GetControlFromPosition(0, 0)!.BackColor = Color.White;
                    _selectedRowIndex = AllRowIndex;
                }
                else
                {
                    categoriesTable.GetControlFromPosition(0, _selectedRowIndex)!.BackColor = Color.FromArgb(195, 141, 158);
                    UpdateSelectedCategory(senderControl);
                }
            }
        }

        /// <summary>
        /// Updates the selected category by changing the background color and setting the new selected row index.
        /// </summary>
        /// <param name="senderControl">The Control that raised the event</param>
        private void UpdateSelectedCategory(Control senderControl)
        {
            // Get the row index of the control that raised the event
            var row = categoriesTable.GetRow(senderControl);
            // Change the back color of left column to show which category is selected
            categoriesTable.GetControlFromPosition(0, row)!.BackColor = Color.White;
            _selectedRowIndex = row;
        }
    }
}