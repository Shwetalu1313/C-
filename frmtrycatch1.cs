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
    public partial class frmtrycatch1 : Form
    {
        public frmtrycatch1()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                num = Convert.ToInt32(txtnum.Text);
                lbldisplay.Text = "Number: " + num;
                txtnum.Focus();
            }
            catch (FormatException)
            {

                lbldisplay.Text = "The input must be integer format";
            }
        }
    }
}
