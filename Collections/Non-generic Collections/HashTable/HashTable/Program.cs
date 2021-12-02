using System;
using System.Collections;
namespace HashTable
{//Colections
    //3 category
    //1.Generic Colllection
    //2.Non-Generic Colllection
    //3.Concurrent Colllection


    //non-generic collections->Arraylist,Queue,Stack,Hashtable
    //Generic Collections->List,Queue,Stack,SortedList,Dictionary
    //These are already implemented inside the System.collections namespace

    //Non-Generic->Hashtable(key and value) 
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();


            //Add() method
            ht1.Add(5, "Five");
            ht1.Add(51, 65);
            ht1.Add("Hello", "Bye");///key =hello; value=bye
            ht1.Add("Hello1", 5.559);

            //way-2 inserting
            ht1[2] = "Good";//inside array notation is key and assigned is the value
            //key=2;value="Good";
            try
            {
                ht1.Add("Hello", 55);
            }
            catch
            {
                Console.WriteLine("Already Exist! Try Something new!");

            }


            //Accessing values
            int a = (int)ht1[0];
            int b = (int)ht1[1];

            Console.WriteLine("Value of a:" + a);
            Console.WriteLine("Value of b:" + b);


            Console.WriteLine("printing values......");
            //for hashtable we use dictionaryentry
            foreach (DictionaryEntry i in ht1)
            {
                Console.WriteLine(i.Key + " " + i.Value);

            }

            //Containkey,Containvalue
            Console.WriteLine("Key Availablity:" + ht1.ContainsKey(5));
            Console.WriteLine("Key Availablity:" + ht1.ContainsValue("Five"));
            Console.WriteLine();
            //Remove elements
            ht1.Remove("Hello");//Total will be removed
            Console.WriteLine("After removing....");
            foreach (DictionaryEntry i in ht1)
            {
                Console.WriteLine(i.Key + " " + i.Value);

            }
            Console.ReadKey();
        }
    }
}
