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

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddPassword().Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyUser_Click(object sender, EventArgs e)
        {

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
    }
}
