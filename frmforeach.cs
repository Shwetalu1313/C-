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
    public partial class frmforeach : Form
    {
        public frmforeach()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            String str = txtvowel.Text;
            int count = 0;
            foreach (char ch in str)
            {
                switch (ch)
                {
                    case 'a': case 'A': count++;break;
                    case 'e': case 'E': count++; break;
                    case 'i': case 'I': count++; break;
                    case 'o': case 'O': count++; break;
                    case 'u': case 'U': count++; break;
                }
            }

            if (count != 0)
            {
                lblString.Text = count + " vowel in this string";
            }
            else
            {
                lblString.Text = "No vowel found in this string";
            }
        }
    }
}
