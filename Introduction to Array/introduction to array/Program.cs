using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_array
{
     class Program
    {
        static void Main(string[] args)
        {
                //1. Array Declaration and Initialization
                int[] numbers = { 10, 20, 30, 40, 50 };

              Console.WriteLine(numbers[2]);
            //now we use loops to access arrays
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
                //the next one is foreach loop
                foreach (int item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }

