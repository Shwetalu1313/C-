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
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }

        int newnum, first, second;

        private void btnChange_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(txtfirst.Text);
            second = Convert.ToInt32(txtsecond.Text);
            Changes(first, second);
        }

        public void Changes(int num1, int num2)
        {
            newnum = num1;
            num1 = num2;
            num2 = newnum;
            lblresult.Text = "The changes number become" + num1 + " and " + num2;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(txtfirst.Text);
            second = Convert.ToInt32(txtsecond.Text);
            lbldisplay.Text = "The original number is " + first + " and " + second;

        }
    }
}
