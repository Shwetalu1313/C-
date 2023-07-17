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
    public partial class frmdowhile : Form
    {
        public frmdowhile()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            lstNumber.Items.Clear();
            int num, i;
            num = Convert.ToInt32(txtstart.Text);
            i = Convert.ToInt32(txtend.Text);
            do
            {
                if (num <= i)
                {
                    lstNumber.Items.Add(num);
                }
                else
                {
                    MessageBox.Show("Start Number should Greater than End Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                num++;
            } while (num <= i);
        }
    }
}
