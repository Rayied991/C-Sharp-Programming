using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Dimentional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //2D-Array

            //creating 2D-Array

            //int[,] t = { 1, 2, 3, 4 };//occur error

            //way-1


            int[,] numbers = {
                {1,2 },  /* index=0  */
                { 3,4}, /* index=1  */
                { 5,6} /* index=2  */

            };
            Console.WriteLine("Element in index-0 position-0 : " + numbers[0, 0]);//1
            Console.WriteLine("Element in index-0 position-1 : " + numbers[0, 1]);//2
            Console.WriteLine("Element in index-1 position-0 : " + numbers[1, 0]);//3
            Console.WriteLine("Element in index-1 position-1 : " + numbers[1, 1]);//4
            Console.WriteLine("Element in index-2 position-0 : " + numbers[2, 0]);//5
            Console.WriteLine("Element in index-2 position-1 : " + numbers[2, 1]);//6

            //way-2
            int t, i;
            int[,] table = new int[3, 4];

            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.Write(table[t, i] + " ");//1 6 11
                }
                Console.WriteLine();

            }
            //way-3
            int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
                                             { 5, 6 }, { 7, 8 } };


            string[,] str = new string[4, 2] { { "one", "two" },
                                            { "three", "four" },
                                            { "five", "six" },
                                            { "seven", "eight" } };


            // using nested loop show string elements
            for (i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(str[i, j] + " ");
                }

            }

            Console.ReadLine();
        }
    }
}
