using System;

namespace Delegates
{ 
    //Delegates
    public delegate void SampleDel(int a, int b);
    class Calculator
    {
        public void addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition :" + result);
        }
        public void Subtraction(int a,int b)
        {
            if (a > b)
            {
                int result = a - b;
                Console.WriteLine("Subtraction :" + result);
            }
            else
            {
                int result = b - a;
                Console.WriteLine("Subtraction :" + result);

            }
        }
        public void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication :" + result);
        }
        public void Division(int a,int b)
        {
            double result = a / b;
            Console.WriteLine("Division :" + result);
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Normal Approach***********");
            Calculator c1 = new Calculator();
            c1.addition(5, 10);//usual approach
            Console.WriteLine();

            //single deligates
            Console.WriteLine("******************Using Single Delegates*****************");
            SampleDel del = c1.addition;
            del(5,10);//using single deligates//Latest-1
            del = c1.Subtraction;
            del(5,10);//Latest-2
            del = c1.Multiplication;
            del(5, 10);//Latest-3
            Console.WriteLine();

            //Multicast Deligates
            Console.WriteLine("*********************Using Multicast Delegates******************");
            /*
             SampleDel del = c1.addition;
             del += c1.Subtraction;
             del += c1.Multiplication;
             del(10, 20);

             */
            Calculator c2 = new Calculator();
            SampleDel d1 = c2.addition; 
            d1 += c2.Subtraction;
            d1 += c2.Multiplication;
            d1 += c2.Division;
            d1(10, 5);
            Console.ReadKey();
        }
    }
}
