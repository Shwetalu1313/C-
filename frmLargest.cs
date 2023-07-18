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
    public partial class frmLargest : Form
    {
        public frmLargest()
        {
            InitializeComponent();
        }

        int first, second;

        private void btnsmallest_Click(object sender, EventArgs e)
        {
            clsLargest compare = new clsLargest();
            try
            {
                first = Convert.ToInt32(txtfirst.Text);
                second = Convert.ToInt32(txtsecond.Text);
                lblresult.Text = "Smallest Number is " + compare.findSmallest(first, second).ToString();
            }
            catch (Exception)
            {
                lblresult.Text = "The input should not be text and empty";
            }
        }

        private void btnlargest_Click(object sender, EventArgs e)
        {
            clsLargest compare = new clsLargest();
            try
            {
                first = Convert.ToInt32(txtfirst.Text);
                second = Convert.ToInt32(txtsecond.Text);
                lblresult.Text = "Largest Number is " + compare.findLargest(first, second).ToString();
            }
            catch (Exception)
            {
                lblresult.Text = "The input should not be text and empty";
            }
        }
    }
}
