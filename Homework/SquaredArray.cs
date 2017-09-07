using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class SquaredArray
    {
        private int[] number;
        public int this[int index]
        {
            get
            {
                return number[index];
            }
            set
            {
                number[index] = (value * value);
            }
        }

        public SquaredArray(int size)
        {
            number = new int[size];
        }
    }
}
