using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditional statement-> if,else-if,else
            Console.WriteLine("Enter your age:");
            string agestr = Console.ReadLine();
            int age = Convert.ToInt32(agestr);
            if (age <2)
            {
                Console.WriteLine("You just borned");
            }
            else if (age < 10 )
            {
                Console.WriteLine("Finish your High School");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are below 18");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are eligable for driving");
            }
             if(age > 80)
            {
                Console.WriteLine("You are too old to drive");
            }
             else
            {
                Console.WriteLine("You cannot drive");
            }

            //Decision making using ternary operator
            /*short-hand if else, which is known as the ternary operator because,
              it consists of three operands. It can be used to replace multiple lines of code
             with a single line.
            It is often used to replace simple if else statements
            */
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
