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
    public partial class frmCount : Form
    {
        public frmCount()
        {
            InitializeComponent();
        }

        private int spaceCount(String str)
        {
            int count = 0;
            String str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                {
                    count++;
                }
            }
            return count;
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            String letter;
            letter = txtletter.Text;
            lblresult.Text = "The space total is " + spaceCount(letter);
        }
    }
}
