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
    public partial class frmAscDes : Form
    {
        public frmAscDes()
        {
            InitializeComponent();
        }

        private void btnaes_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Ascending Order");
            for (int i = 2; i <= 20; i+=2)
            {
                lstDisplay.Items.Add(i);
            }
        }

        private void btndes_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Descending Order");
            for (int i = 20; i >= 2; i -= 2)
            {
                lstDisplay.Items.Add(i);
            }
        }
    }
}
