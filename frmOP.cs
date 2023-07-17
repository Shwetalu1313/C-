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
    public partial class frmOP : Form
    {
        int ? num1, num2; // ? is holding value

        public frmOP()
        {
            InitializeComponent();
        }

        private void frmOP_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
            // if label value is null assumes as zero
        {
            num1 = string.IsNullOrEmpty(txtnum1.Text) ? 0 : Convert.ToInt32(txtnum1.Text);
            num2 = string.IsNullOrEmpty(txtnum2.Text) ? 0 : Convert.ToInt32(txtnum2.Text);
            lblResult.Text = num1 + " - " + num2 + " = " + (num1 - num2);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = string.IsNullOrEmpty(txtnum1.Text) ? 0 : Convert.ToInt32(txtnum1.Text);
            num2 = string.IsNullOrEmpty(txtnum2.Text) ? 0 : Convert.ToInt32(txtnum2.Text);
            lblResult.Text = string.IsNullOrEmpty(txtnum2.Text) && string.IsNullOrEmpty(txtnum1.Text) ? "The value is null" : num1 + " / " + num2 + " = " + (num1 / num2);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = string.IsNullOrEmpty(txtnum1.Text) ? 0 : Convert.ToInt32(txtnum1.Text);
            num2 = string.IsNullOrEmpty(txtnum2.Text) ? 0 : Convert.ToInt32(txtnum2.Text);
            lblResult.Text = num1 + " x " + num2 + " =  " + (num1 * num2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = string.IsNullOrEmpty(txtnum1.Text) ? 0 : Convert.ToInt32(txtnum1.Text);
            num2 = string.IsNullOrEmpty(txtnum2.Text) ? 0 : Convert.ToInt32(txtnum2.Text);
            lblResult.Text = string.IsNullOrEmpty(txtnum2.Text) && string.IsNullOrEmpty(txtnum1.Text) ? "The value is null" : num1 + " % " + num2 + " = " + (num1 % num2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = string.IsNullOrEmpty(txtnum1.Text) ? 0 : Convert.ToInt32(txtnum1.Text);
            num2 = string.IsNullOrEmpty(txtnum2.Text) ? 0 : Convert.ToInt32(txtnum2.Text);
            lblResult.Text = num1 + " + " + num2 + " = " + (num1 + num2);
        }
    }
}
