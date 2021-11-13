using System;

namespace Generics
{
   // public void delegate Sampledel(T a, T b);
    //basic Generic Class
    class GenericClass<T>
    {
        public T test;

        public GenericClass()
        {
            Console.WriteLine("Empty constructor is called");

        } 
        public GenericClass(T test)
        {
            this.test = test;
            Console.WriteLine("Parameterized constructor is called");

        }

        public void setTest(T test)
        {
            this.test = test;
        }
        public T getTest()
        {
            return test;
        }   
    }
    class GenericMethod
    {
        public void Display<T>(T a,T b)
        {

            Console.WriteLine("Value of a:" + a);
            Console.WriteLine("Value of b:" + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Generic Class**********");
            GenericClass<string> gc1 = new GenericClass<string>();

            gc1.setTest("Hello There!");
            Console.WriteLine(gc1.getTest());


            GenericClass<int> gc2 = new GenericClass<int>();
            gc2.setTest(75);
            Console.WriteLine(gc2.getTest());

            GenericClass<double> gc3 = new GenericClass<double>(75.5);
            Console.WriteLine(gc3.getTest());

            Console.WriteLine();

            Console.WriteLine("*********Generic Method inside a normal classs*******");
            GenericMethod gm1 = new GenericMethod();
            //gm1.add(15.5, 5.5); //not allowed; not generic, normal class
            gm1.Display<int>(15, 5);
            gm1.Display<string>("Hello","There!");
            Console.ReadKey();
        }
    }
}
