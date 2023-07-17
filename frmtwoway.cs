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
    public partial class frmtwoway : Form
    {
        public frmtwoway()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            int price;
            price = Convert.ToInt32(txtPrice.Text);
            if (price <= 5000)
            {
                MessageBox.Show(price + "is fair price.");
            }
            else
                MessageBox.Show(price + "is very expensive price");
        }
    }
}
