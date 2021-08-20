using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = 10;
            Console.WriteLine(n);
            string phrase = "Bangladesh";
            char grade = 'A';
            int age = 30;
            long mynum = 10000000L;
            Console.WriteLine("Long = " + mynum);

            //represent decimal points
            float f = 2.34F;
            double gpa = 3.2;
            Console.WriteLine("Floating number = " + f);

            //decimal type-> mandetory to give (m) suffix otherwise error will occur
            decimal price;
            decimal discount;
            decimal discounted_price;

            //compute discounted price
            price = 19.9m;
            discount = 0.15m;

            discounted_price = price - (price * discount);
           

            //representing true/false
            bool ismale = true;

            //scientific number
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            Console.WriteLine("My country name is = " + phrase);
            Console.WriteLine("My grade is = "+grade);
            Console.WriteLine("My age is = "+age);
            Console.WriteLine("My Gpa is = "+gpa);
            Console.WriteLine("I am male it's = "+ismale);
            Console.WriteLine("Before discount the price was = " + price + " tk");
            Console.WriteLine("Discount given is = " + discount + "%");
            Console.WriteLine("Discounted Price is = " + discounted_price + " tk");
            Console.ReadLine();
        }
    }
}
