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
            //Stack(Push,Pop)
            Stack s1 = new Stack();

            //Push

            s1.Push(5);
            Console.ReadKey();
        }
    }
}
