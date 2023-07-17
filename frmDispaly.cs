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
    public partial class frmDispaly : Form
    {
        public frmDispaly()
        {
            InitializeComponent();
        }

        private void btnDispaly_Click(object sender, EventArgs e)
        {
            frmDisplaycls s = new frmDisplaycls();
            lbldisplay.Text = s.Dispaly();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbldisplay.Text = "";
        }
    }
}
