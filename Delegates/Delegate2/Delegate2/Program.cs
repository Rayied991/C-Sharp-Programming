using System;

namespace Delegate2
{
    //Methods as Parameters

    //delegates declaration
    public delegate void SampleCalc(int a, int b);

    class Basic_Maths
    {
        public void add(int a,int b)
        {
            int res = a + b;
            Console.WriteLine("Addition :" + res);
        }
        public void Sub(int a,int b)
        {
            if (a > b)
            {
                int res = a - b;
                Console.WriteLine("Subtraction :" + res);
            }
            else
            {
                int res = b- a;
                Console.WriteLine("Subtraction :" + res);

            }
        }
        public void Square(int a)
        {
            int res = a * a;
            Console.WriteLine("Square value : " + res);
        }

    }
    class Program
    {

        //Pass Methods as Parameters
        static void SampleFunction(SampleCalc s1,int a,int b)
        {
            s1(a, b);

        }
        static void SampleFunction(SampleCalc s1,SampleCalc s2,int a,int b)
        {
            s1(a, b);

        }
        static void Main(string[] args)
        {
            
            //Single deligates
            Console.WriteLine("**********Single Deligates*******");
            Basic_Maths bm1 = new Basic_Maths();
            SampleCalc sc1 = bm1.add;//assigning reference
            sc1(15, 5);
            sc1 = bm1.Sub;
            sc1(15, 5);
            
            /*sc1 = bm1.Square;
            sc1(5);*/ //error occurs
            
            Console.WriteLine();

            //Multicast delegates   
            Console.WriteLine("**********Multicast Delegeates*********");
            Basic_Maths bm2 = new Basic_Maths();
            SampleCalc sc2 = bm2.add;
            sc2 = sc2 + bm2.Sub;
            //sc2 = sc2 + bm2.Square; //error
            sc2(15, 5);
            Console.WriteLine();

            Console.WriteLine("********Passing methods as Parameters");
            Basic_Maths bm3 = new Basic_Maths();
            SampleFunction(bm3.add,15,5);
            SampleFunction(bm3.Sub,25,5);

            Console.WriteLine("***********Passing Multicast as Parameters***********");
            SampleFunction(bm3.add,bm3.Sub,25,5);
            

            Console.ReadKey();
        }
    }
}
