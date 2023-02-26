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

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddPassword().Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyUser_Click(object sender, EventArgs e)
        {

        }
    }
}
