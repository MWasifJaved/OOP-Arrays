using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_arrays
{
     class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = {
                              {10,20,30,40},
                              { 50,60,70,80},
                              { 90,100,110,120}

            
            };
            Console.WriteLine(numbers.GetLength(0));
            Console.WriteLine(numbers.GetLength(1));
            Console.WriteLine(numbers[2,1]);
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
               for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i,j] + " ");
                }
                Console.WriteLine();


            }




        }



    }
    }

