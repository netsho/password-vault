using Microsoft.IdentityModel.Tokens;
using pwdvault.Modeles;
using pwdvault.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwdvault.Forms
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private List<UserPassword> passwords = new();

        public MainForm()
        {
            InitializeComponent();
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            AddPasswordsItems(passwords);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddPassword().Show();
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

        /*-----------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------*/
        /*---  The MainForm is composed of a picture box, a main panel and a top panel. Those event methodes are implemented
         *     to make the main window move by pressing the mouse on any of these components ------------------------------*/
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm_MouseUp(this, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MainForm_MouseMove(this, e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm_MouseDown(this, e);
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm_MouseUp(this, e);
        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            MainForm_MouseMove(this, e);
        }

        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm_MouseDown(this, e);
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm_MouseUp(this, e);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            MainForm_MouseMove(this, e);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm_MouseDown(this, e);
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            // filter password by app names
        }

        private void lbAll_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            AddPasswordsItems(passwords);
        }

        private void lbAdmini_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> administrativePasswords = passwords.Where(userPassword => userPassword.AppCategory == "Administrative").ToList();
            AddPasswordsItems(administrativePasswords);
        }

        private void lbWork_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> workPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Work").ToList();
            AddPasswordsItems(workPasswords);
        }

        private void lbStudy_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> studyPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Study").ToList();
            AddPasswordsItems(studyPasswords);
        }

        private void lbSocial_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> socialPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Socials").ToList();
            AddPasswordsItems(socialPasswords);
        }

        private void lbRetail_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> retailPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Retail").ToList();
            AddPasswordsItems(retailPasswords);
        }

        private void lbFinance_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> financePasswords = passwords.Where(userPassword => userPassword.AppCategory == "Finance").ToList();
            AddPasswordsItems(financePasswords);
        }

        private void lbGames_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> gamesPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Games").ToList();
            AddPasswordsItems(gamesPasswords);
        }

        private void lbCoding_Click(object sender, EventArgs e)
        {
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> codingPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Coding").ToList();
            AddPasswordsItems(codingPasswords);
        }

        /// <summary>
        /// Function to clear the panel and add all the passwords by clicked category
        /// </summary>
        /// <param name="passwords"></param>
        private void AddPasswordsItems(List<UserPassword> passwords)
        {
            listPwdPanel.Controls.Clear();
            foreach (UserPassword password in passwords)
            {
                Password passwordForm = new Password(password.AppName, password.UserName, password.IconName);
                passwordForm.Width = listPwdPanel.Width;
                listPwdPanel.Controls.Add(passwordForm);
            }
        }
    }
}
