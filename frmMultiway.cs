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
    public partial class frmMultiway : Form
    {
        public frmMultiway()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myanmar, eng, math;
            myanmar = Convert.ToInt32(txtMyanmar.Text);
            eng = Convert.ToInt32(txtEnglish.Text);
            math = Convert.ToInt32(txtMath.Text);

            if(myanmar > 100 || eng >100 || math > 100)
            {
                lblResult.Text = "This is invalid Mark";
            }
            else if (myanmar >= 80 || eng >= 80 || math >= 80)
            {
                lblResult.Text = "Pass with Distinction";
            }
            else if (myanmar >= 40 || eng >= 40 || math >= 40)
            {
                lblResult.Text = "Pass all Subjects";
            }
            else
            {
                lblResult.Text = "Fail the exam";
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
