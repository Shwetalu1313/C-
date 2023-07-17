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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }
        private void welcome()
        {
            lbldisplay.Text = "Welocme my friend";
        }

        private void good()
        {
            lbldisplay.Text = "Have a Good Day🎶🎶";
        }

        private void btnwelcome_Click(object sender, EventArgs e)
        {
            welcome();
        }

        private void btngood_Click(object sender, EventArgs e)
        {
            good();
        }
    }
}
