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
    public partial class frmoneway : Form
    {
        public frmoneway()
        {
            InitializeComponent();
        }

        private void btnwelcome_Click(object sender, EventArgs e)
        {
            String name;
            name = txtName.Text;
            if(name != ""){
                lblResult.Text = name + "Welocme to our Program";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
