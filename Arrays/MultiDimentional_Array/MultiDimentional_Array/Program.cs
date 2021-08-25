using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimentional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# allows arrays with more than two dimensions
            //3D Array
            /* syntax:
               type[,....,] name=new type[size1,size2,...,sizeN]
            */

            //create 3D Array

            //way-1

            int[,,] m = new int[3, 3, 3];
            int sum = 0;
            int n = 1;

            // Sum the values on a diagonal of a 3x3x3 matrix.
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                    for (int z = 0; z < 3; z++)
                        m[x, y, z] = n++;
            sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];

            Console.WriteLine("Sum of first diagonal: " + sum);


            //way-2

            int[,,] intarray3D = new int[,,] { { { 1, 2, 3 },
                                             { 4, 5, 6 } },
                                             { { 7, 8, 9 },
                                           { 10, 11, 12 } } };

            //Accessing Array elements
            Console.WriteLine("3DArray[1][0][1] : "
                           + intarray3D[1, 0, 1]);

            Console.WriteLine("3DArray[1][1][2] : "
                              + intarray3D[1, 1, 2]);

            Console.ReadLine();
        }
    }
}
