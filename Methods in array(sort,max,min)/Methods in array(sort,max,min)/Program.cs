using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_in_array_sort_max_min_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mynum = { 80, 33, 56, 20, 99, 88, 55 };
            //in this we discuss about sorting arrays
            Array.Sort(mynum);
            foreach (int i in mynum)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Max value is" + mynum.Max());//it gives max value
            Console.WriteLine("Min value is" + mynum.Min());//it gives min value
            Console.WriteLine("Length of array is" + mynum.Length);



        }
    }
}


