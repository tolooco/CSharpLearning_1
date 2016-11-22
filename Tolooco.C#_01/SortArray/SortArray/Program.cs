using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 15, 20, 10, 19, 11, 18, 12, 17, 13, 16, 14, 5, 9, 0, 8, 1, 7, 2, 6, 3, 4 };
            SortArray.XSort.Quicksort(test, 0, test.Length - 1);
            for (int i = 0; i < test.Length; i++)
            { Console.WriteLine("Sorting Value :{0}\r\n", test[i]); }

            Console.ReadKey();
        }
    }
}
