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
    public partial class frmgrade : Form
    {
        public frmgrade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int grade = Convert.ToInt32(txtgrade.Text);
            string ga, gb, gc, gd, ge, gf;
            ga = "Grade A";
            gb = "Grade B";
            gc = "Grade C";
            gd = "Grade D";
            ge = "Grade E";
            gf = "Grade F";

            if (grade > 70)
            {
                lblReslt.Text = ga;
                lblReslt.ForeColor = Color.Black;
            }
            else if (grade <= 70 && grade > 60)
            {
                lblReslt.Text = gb;
                lblReslt.ForeColor = Color.Black;
            }
            else if (grade <= 60 && grade > 50)
            {
                lblReslt.Text = gc;
                lblReslt.ForeColor = Color.Black;
            }
            else if (grade <= 50 && grade > 40)
            {
                lblReslt.Text = gd;
                lblReslt.ForeColor = Color.Black;
            }
            else
                lblReslt.Text = gf;
            lblReslt.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
