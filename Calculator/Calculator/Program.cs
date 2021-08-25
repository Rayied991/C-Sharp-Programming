using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("1.Summation");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Remainder");
            Console.WriteLine("Enter your Choice:");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Summation = " + (num1 + num2));
                    break;
                case 2:
                    if (num1 > num2)
                    {
                        Console.WriteLine("Subtraction = " + (num1 - num2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Subtraction = " + (num2 - num1));
                        break;

                    }
                case 3:
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Divide = " + (num1 / num2));
                    break;
                case 5:
                    Console.WriteLine("Remainder = " + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();

        }
    }
}
