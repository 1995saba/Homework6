using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Введите количество элементов массива: ");
            string sizeAsString = Console.ReadLine();
            bool result = Int32.TryParse(sizeAsString, out size);
            if (!result)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   sizeAsString == null ? "<null>" : sizeAsString);
            }

            SquaredArray array = new SquaredArray(size);

            for (int i = 1; i < size; i++)
            {
                array[i] = i;
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
            Console.ReadLine();
        }
    }
}
