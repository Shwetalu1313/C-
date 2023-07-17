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
    public partial class frmsum : Form
    {
        public frmsum()
        {
            InitializeComponent();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtnum.Text);
            int sum = 0;
            lstResult.Items.Clear();
            for(int i = num; i > 0; i--)
            {
                lstResult.Items.Add(i);
                sum += i;
            }
            lstResult.Items.Add("Total sum " + sum);
            txtnum.Focus();
            txtnum.SelectAll();
        }
    }
}
