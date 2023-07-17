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
    public partial class frmsumass : Form
    {
        public frmsumass()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int f, s;
            
            try
            {
                f = Convert.ToInt32(txtfirst.Text);
                s = Convert.ToInt32(txtsecond.Text);
                Summy(f, s);
            }
            catch (NullReferenceException)
            {
                lbldisplay.Text = "We cannot calculate, the values are empty";
            }
            catch (FormatException)
            {
                lbldisplay.Text = "The value must be an integer";
            }
            catch (Exception)
            {
                lbldisplay.Text = "An error occurred while performing the calculation.";
            }

        }
        private void Summy(int f, int s)
        {
            try
            {
                lbldisplay.Text = "Sum = " + (f + s);
            }
            catch (NullReferenceException)
            {
                lbldisplay.Text = "We cannot calculate, the values are empty";
            }
            catch (FormatException)
            {
                lbldisplay.Text = "The value must be integer";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearly();
        }
        private void Clearly()
        {
            lbldisplay.Text = "";
            txtsecond.Text = "";
            txtfirst.Text = "";
        }
    }
}
