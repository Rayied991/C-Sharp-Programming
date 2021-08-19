using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables->container where I can store specific data value
             
              * syntax:
                    datatype varname=value;
              */
            string charname = "Rayied";
            int age = 21;//Integer variables
            Console.WriteLine("Previous character = "+charname);
            double myDoubleNum = 5.99;//Double variable
            Console.WriteLine("Double value= " + myDoubleNum);
            char myLetter = 'D';//Character variable
            Console.WriteLine("Char value= " + myLetter);
            bool myBool = true;//Boolean variable
            Console.WriteLine("Boolean value= " + myBool);
            charname = "Asif";//updating the variable value
            age = 99;//updating the variable value
            const int myNum = 15;
            //myNum = 20; // error    
            /*
             you can add the const keyword if you don't want others (or yourself) to overwrite existing values (this will declare the variable as "constant", which means unchangeable and read-only):
            The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code. An example that is often referred to as a constant, is PI (3.14159...).

            You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.
              */
            Console.WriteLine("My Name is "+charname);
            Console.WriteLine("I am "+age+" Years old");
            Console.ReadLine();
        }
    }
}
