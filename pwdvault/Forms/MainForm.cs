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
            dataGridTest.DataSource = passwords;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new EditPassword().Show();
        }

        private void lbAll_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            dataGridTest.DataSource = passwords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbAdmini_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> administrativePasswords = passwords.Where(userPassword => userPassword.AppCategory == "Administrative").ToList();
            dataGridTest.DataSource = administrativePasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbWork_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> workPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Work").ToList();
            dataGridTest.DataSource = workPasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbStudy_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> studyPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Study").ToList();
            dataGridTest.DataSource = studyPasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbSocial_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> socialPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Socials").ToList();
            dataGridTest.DataSource = socialPasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbRetail_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> retailPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Retail").ToList();
            dataGridTest.DataSource = retailPasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbFinance_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> financePasswords = passwords.Where(userPassword => userPassword.AppCategory == "Finance").ToList();
            dataGridTest.DataSource = financePasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbGames_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> gamesPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Games").ToList();
            dataGridTest.DataSource = gamesPasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }

        private void lbCoding_Click(object sender, EventArgs e)
        {
            dataGridTest.DataSource = null;
            using (var context = new PasswordVaultContext())
            {
                UserPasswordService userPasswordService = new(context);
                passwords = userPasswordService.GetAllUserPassword();
            }
            List<UserPassword> codingPasswords = passwords.Where(userPassword => userPassword.AppCategory == "Coding").ToList();
            dataGridTest.DataSource = codingPasswords;
            dataGridTest.Columns["Id"].Visible = false;
            dataGridTest.Columns["Password"].Visible = false;
        }
    }
}
