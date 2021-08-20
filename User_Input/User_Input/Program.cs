using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();//Getting user input nad stored into a variable
            Console.WriteLine("Enter your age:");

            // Console.ReadLine() method returns a string,data type, such as int. willl occur an error
            //for this problem we have to convert it (implicit typecasting) into string to int to avoid error
           
            int age = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter a double value:");
            double d= Convert.ToDouble(Console.ReadLine());
           

            Console.WriteLine("Enter a decimal value:");
            decimal dc = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter a byte value:");
            byte b = Convert.ToByte(Console.ReadLine());

            

            Console.WriteLine("Enter a character value:");
            char c = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Name = " + name);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Decimal value = " + dc);
            Console.WriteLine("Byte value = " + b);
            Console.WriteLine("Character value = " + c);
            Console.ReadLine();
        }
    }
}
