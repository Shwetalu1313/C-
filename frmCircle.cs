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
    public partial class frmCircle : Form
    {
        double radius, pi;
        public frmCircle()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            radius = Convert.ToDouble(txtradius.Text);
            pi = Convert.ToDouble(txtpi.Text);

            lblresult.Text = "The area of Circle is " + (pi * radius * radius).ToString();
        }
    }
}

