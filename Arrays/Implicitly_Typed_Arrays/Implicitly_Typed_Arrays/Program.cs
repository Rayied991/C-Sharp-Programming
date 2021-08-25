using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicitly_Typed_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*implicitly typed variablesby using the var keyword.
             all implicitly typed variables must be initialized

            example:
            var vals = new[] { 1, 2, 3, 4, 5 };
            var vals = new[,] { {1.1, 2.2}, {3.3, 4.4},{ 5.5, 6.6} };
                    In this case, vals has the dimensions 2×3.
             */


            //Implicitly typed Jagged Arrays

            var jagged = new[] {
                    new[] { 1, 2, 3, 4 },
                    new[] { 9, 8, 7 },
                    new[] { 11, 12, 13, 14, 15 }
                    };
            for (int j = 0; j < jagged.Length; j++)//length=3
            {
                for (int i = 0; i < jagged[j].Length; i++)
                {
                    Console.Write(jagged[j][i] + " ");// 1 2 3 4 9 8 7 11 12 13 14 15
                }
                Console.ReadLine();
            }
        }
    }
}
