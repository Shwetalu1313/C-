using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Simple Message Box🎶.");
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is message box text", "This is title text");
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is message box text", "This is Title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
