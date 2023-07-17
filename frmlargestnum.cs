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
    public partial class frmlargestnum : Form
    {
        public frmlargestnum()
        {
            InitializeComponent();
        }

        private void btnlargest_Click(object sender, EventArgs e)
        {
            int first, second;
            first = Convert.ToInt32(txtfirst.Text);
            second = Convert.ToInt32(txtsecond.Text);
            string txtstring = " is the largest number";

            if (first > second)
                lblResult.Text = first + txtstring;
            else
                lblResult.Text = second + txtstring;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
