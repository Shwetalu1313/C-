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
    public partial class frmtrycatch : Form
    {
        public frmtrycatch()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int first, second;
                first = Convert.ToInt32(txtnum1.Text);
                second = Convert.ToInt32(txtnum2.Text);
                lblresult.Text = "The result = " + first / second;
            }
            catch (DivideByZeroException de)
            {
                lblresult.Text = de.GetType().ToString()+ "We cannot divided by zero.";
            }
            finally
            {
                MessageBox.Show("Error checking is complete");
            }
        }
    }
}
