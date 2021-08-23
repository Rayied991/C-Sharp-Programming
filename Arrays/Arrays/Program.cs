using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            //creating array

            //way-1

            int[] luckynumber = { 4, 8, 15, 16, 23, 42 };

            //Array length
            Console.WriteLine("The length of the Array : " + luckynumber.Length);

            //sort Arrays
            Array.Sort(luckynumber);

           //Accessing array elements

            Console.WriteLine(luckynumber[0]);
            Console.WriteLine(luckynumber[1]);
            Console.WriteLine(luckynumber[2]);
            Console.WriteLine(luckynumber[3]);

            //updating values

            luckynumber[0] = 11;
            Console.WriteLine(luckynumber[0]);

            //way-2

            string[] friends = new string[10];
            friends[0] = "Angela";
            friends[1] = "Fardin";
            friends[2] = "Alif";
            friends[3] = "Rayied";
            friends[4] = "Asif";

            //Array length

            Console.WriteLine("The length of the Array : " + friends.Length);

            //sort Arrays
            Array.Sort(friends);

            //way-3

            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            ///way-4
            string[] car = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };


            //using system.linq namespace
            int[] mynumbers = { 1, 5, 8, 9 };
            Console.WriteLine("Largest value = " + mynumbers.Max());//returns largest value
            Console.WriteLine("Smallest value = " + mynumbers.Min());//returns smallest value
            Console.WriteLine("Sum = " + mynumbers.Sum());//returns sum of elements

            Console.ReadLine();
        }
    }
}
