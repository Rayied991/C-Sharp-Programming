using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void JaggedArray()
        {
            int[][] studentAverageGradePerYear = new int[4][];
            studentAverageGradePerYear[0] = new int[3] { 50, 70, 54 };
            studentAverageGradePerYear[1] = new int[2] { 54, 65 };
            studentAverageGradePerYear[2] = new int[2] { 50, 70 };
            studentAverageGradePerYear[3] = new int[1] { 73 };
            WriteJaggedArray(studentAverageGradePerYear);
        }
        static void WriteJaggedArray(int[][] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.Write($"{Array[i][j]} \t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //A jagged array is an array of arrays in which the length of each array can differ
            //a jagged array can be used to create a table in which the lengths of the rows are not the same
            /*
             syntax:  type[ ] [ ] array-name = new type[size][ ];
            Here, size indicates the number of rows in the array.
            the rows are allocated individually
            */

            int[][] mytable = new int[3][];
            mytable[0] = new int[] { 1, 2 };
            mytable[1] = new int[] { 4, 5, 6 };
            mytable[2] = new int[] { 7, 8, 9, 4 };

            for (var list = 0; list < mytable.Length; list++)
            {
                Console.WriteLine("***************************");
                for (var num = 0; num < mytable[list].Length; num++)
                {
                    Console.WriteLine(mytable[list][num]);
                }
            }

            JaggedArray();

            string[][] jaggedarray = new string[3][];
            string[] employees = new string[3];

            employees[0] = "Mark";
            employees[1] = "Alex";
            employees[2] = "John";

            jaggedarray[0] = new string[3];
            jaggedarray[1] = new string[1];
            jaggedarray[2] = new string[2];

            jaggedarray[0][0] = "Bachelors";
            jaggedarray[0][1] = "Masters";
            jaggedarray[0][2] = "Doctorate";

            jaggedarray[1][0] = "Bachelors";

            jaggedarray[2][0] = "Bachelors";
            jaggedarray[2][1] = "Masters";

            for(int i = 0; i < jaggedarray.Length; i++)//length will give the number of arrays which is 3
            {
                string[] innerarray = jaggedarray[i];
                Console.WriteLine(employees[i]);
                Console.WriteLine("-----------------");
                for(int j = 0; j < innerarray.Length; j++)
                {
                    Console.WriteLine(innerarray[j]);
                }Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
