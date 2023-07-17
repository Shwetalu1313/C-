using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    internal class frmDisplaycls
    {
        String Name, Address; int Age;

        public frmDisplaycls()
        {
            Name = "Su Su";
            Address = "Yangon";
            Age = 20;
        }
        public String Dispaly()
        {
            String str = "Student Name = " + Name;
            str += "\nAddress = " + Address;
            str += "\nAge = " + Age;
            return str;
        }
    }
}
