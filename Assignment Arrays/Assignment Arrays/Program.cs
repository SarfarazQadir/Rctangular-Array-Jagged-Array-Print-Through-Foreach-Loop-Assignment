using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment of Arrays '/t ");
            Console.WriteLine("Rectangular Array");

            int[,] num = new int[4, 4]
            {
                {9,8,7,6 },
                {1,2,3,4},
                {10,1,6,9},
                {11,10,1,9},
            };

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Jagged Array");

            int[][] new1 = new int[4][];

            new1[0] = new int[] { 1, 2, 3, };
            new1[1] = new int[] { 4, 5, 6, 7 };
            new1[2] = new int[] { 5, 2, 3, 3, 2, 4, 8 };
            new1[3] = new int[] { 10, 22, 1, 2, 33, 44, 33, 1 };

           
            foreach (int[] item in new1)
            {
                foreach (int value in item)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }

           
            Console.ReadKey();
        }
    }
}
