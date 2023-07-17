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
    public partial class frmForLoop2 : Form
    {
        public frmForLoop2()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtFirst.Text);
            lstDispaly.Items.Clear();
            for(int i=1; i <= 5; i++)
            {
                lstDispaly.Items.Add(num + " x " + i + " = " + (num * i));
            }
            txtFirst.Focus();
            txtFirst.SelectAll();
        }
    }
}
