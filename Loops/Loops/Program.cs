using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops in C-sharp

            //writing 1 to 5

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            //if we want to show 1 to 5000 then we will use loops

            //Better Approach-> Loops

            //While loops
            /* In Programming languages, Loops are used to execute a set of instructions
            functions repeatedly when some conditions become true*/

            int i = 0;
            int sum = 0;
            while (i <=10)
            {
                Console.WriteLine(i);
                sum = sum + i;
                i++;
            }
            Console.WriteLine("The sum of the numbers = " + sum);

            //Infinitive while loop
            //while (true)
            //{
            //    Console.WriteLine("Infinitive loop");
            //}

            //do-while loop

            /*
             do-while loop is used to iterate a part of the program several times.
                   if the number of iteration is not fixed and you must have to execute
                  the loop at once ,It is recommended to use do-while loop.
              */
            int k = 1;
            do
            {
                Console.WriteLine("Hello");
                k++;

            } while (k <= 10);

            //it will give output at least one time
            int k1 = 1;
            do
            {
                Console.WriteLine("One Time");
                k1++;

            } while (k1 <= 0);

            //Infinitive do-while loops

            //do
            //{
            //    Console.WriteLine("Infinitive do-while loops");
            //} while (true);

            //for loops
            //syntax:
            //for(initialization,condiion checking,updation)

            for(int a = 0; a <= 10; a++)
            {
                Console.WriteLine("Person : " + a);

            }

            //Nested for loops
           
            for(int a = 1; a <= 5; a++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("A ");
                }
                Console.WriteLine();
            }
            
            //Infinitive for loop
            //for(; ; )
            //{
            //    Console.WriteLine("Infinitive for loop");
            //}


            //for-each loop
            int Add = 0;
            int[] nums = new int[10];

            for(int a = 0; a < 10; a++)
            {
                nums[a] = a;

            }
            ////loop start here
            foreach(int x in nums)
            {
                Console.WriteLine("Values are = " + x);
                Add = Add + x;
                
            }
            Console.WriteLine("Total Sum = " + Add);

            Console.ReadLine();
        }
    }
}
