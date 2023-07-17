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
    public partial class frmCh1ass1 : Form
    {
        public frmCh1ass1()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblResult.BackColor = Color.Black;
            lblResult.ForeColor = Color.White;
            lblResult.Text = "This is Basic Software Engeering Course";
            lblclick.ForeColor = Color.Red;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is message box testing.");
        }
    }
}
