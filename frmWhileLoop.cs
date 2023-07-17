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
    public partial class frmWhileLoop : Form
    {
        public frmWhileLoop()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            int num;
            Random rand = new Random();
            num = rand.Next(30);
            while (num >= 10)
            {
                lstData.Items.Add(num);
                num = rand.Next(30);
            }
        }
    }
}
