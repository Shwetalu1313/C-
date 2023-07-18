using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    class clsLargest
    {
        public int findLargest(int one, int two)
        {
            int largest;
            largest = one;
            if (largest < two)
            {
                largest = two;
            }
            return largest;
        }

        public int findSmallest(int one, int two)
        {
            int smallest;
            smallest = one;
            if (smallest > two)
            {
                smallest = two;
            }
            return smallest;
        }
    }
}
