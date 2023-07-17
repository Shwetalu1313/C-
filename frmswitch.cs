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
    public partial class frmswich : Form
    {
        public frmswich()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letter;
            letter = Convert.ToChar(txtletter.Text);
            switch (letter)
            {
                case 'a': case 'e': case 'i': case 'o': case 'u': lblResult.Text = "This is vowel"; break;
                case 'A': case 'E': case 'I': case 'O': case 'U': lblResult.Text = "This is vowel"; break;
                default: lblResult.Text = "This is Consonant"; break;
            }
        }
    }
}
