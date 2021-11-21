using System;
using System.Collections;
namespace Stack_Queue
{
    class Program
    {
        //Colections
        //3 category
        //1.Generic Colllection
        //2.Non-Generic Colllection
        //3.Concurrent Colllection


        //non-generic collections->Arraylist,Queue,Stack,Hashtable
        //Generic Collections->List,Queue,Stack,SortedList,Dictionary
        //These are already implemented inside the System.collections namespace

        
        //Queue
        static void Main(string[] args)
        {
            Console.WriteLine("************Stack**********");
            //Stack(Push,Pop)
            Stack s1 = new Stack();

            //Push()

            s1.Push(5);
            s1.Push("Hello");
            s1.Push(65.5);
            s1.Pop();
            s1.Pop();
            s1.Push(99.99);
            s1.Push("Bye");
            s1.Push(75);

            Console.WriteLine("Count="+s1.Count);
            Console.WriteLine("Top Value="+s1.Peek());
            Console.WriteLine("Contains(99.99)="+s1.Contains(99.99));

            Console.WriteLine("Stack elements before remove:");
            foreach(var i in s1)
            {
                Console.WriteLine(i);
            }
            
            //pop()
            s1.Pop();

            Console.WriteLine("Stack elements after remove:");
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("************Queue**********");

            //Queue
            Queue Q1 = new Queue();

            //Enqueue()
            Q1.Enqueue(55);
            Q1.Enqueue(99.99);
            Q1.Enqueue("Hi there!");

            Console.WriteLine("Count=" + Q1.Count);
            Console.WriteLine("Contains(99.99)=" + s1.Contains(99.99));

            Console.WriteLine("Queue elements before remove:");
            foreach(var i in Q1)
            {
                Console.WriteLine(i);
            }


            //Dequeue()

            Q1.Dequeue();
            Console.WriteLine("Queue elements After remove:");

            foreach (var i in Q1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count=" + Q1.Count);
            Console.WriteLine("Contains(99.99)=" + s1.Contains(99.99));

            Console.ReadKey();
        }
    }
}
