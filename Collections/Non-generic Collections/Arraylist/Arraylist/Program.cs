using System;
using System.Collections;
namespace Arraylist
{
    //Colections 
    //3 category
    //1.Generic Colllection
    //2.Non-Generic Colllection
    //3.Concurrent Colllection


    //non-generic collections->Arraylist,Queue,Stack,Hashtable
    //Generic Collections->List,Queue,Stack,SortedList,Dictionary
    //These are already implemented inside the System.collections namespace
    //Inside arraylist we can store multiple objects not values not datatypes;.


    //a(b+c)
    //type varname=parse(readline)
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList();
            //add() method
            aList.Add(8);
            aList.Add("Hello!");
            aList.Add(55.5);


            //Count and a Capacity Property
            Console.WriteLine("Count : " + aList.Count);
            Console.WriteLine("Capacity : " + aList.Capacity);

            //Printing values
            Console.WriteLine("Printing Values.........");
            foreach (var i in aList)
            {
                Console.WriteLine(i);
            }

            //Create another arraylist
            //adding values while declaring arraylist
            ArrayList Blist = new ArrayList() { 100, "hello There!" };

            //Printing Blist
            Console.WriteLine("Blist Values.........");
            foreach(var i in Blist)
            {
                Console.WriteLine(i);
            }
            //AddRange functon
            aList.AddRange(Blist);//added alist with Blist

            //[] a={5,10,15};
            //int b=a[1]->(10);

            //storing values in arraylist
            int a = (int)aList[0];
            string b = (string)aList[1];
            Console.WriteLine("Value of a = "+a);
            Console.WriteLine("Value of b = "+b);

            //inserting values
            aList.Insert(1,"Hello There!");

            Console.WriteLine("After insertion Count : " + aList.Count);
            Console.WriteLine("After insertion Capacity : " + aList.Capacity);
            Console.WriteLine("After inserting.......");
            foreach (var i in aList)
            {
                Console.WriteLine(i);
            }

            //removing values

            //Remove() method
            aList.Remove(55.5);//remove 55.5

            //RemoveAt() method
            aList.RemoveAt(0);//remove index value

            Console.WriteLine("Check for an element :"+aList.Contains("Hello There!"));
            Console.WriteLine("Check for another element :"+aList.Contains(55.5));

            Console.WriteLine("After removing Count : " + aList.Count);
            Console.WriteLine("After removing Capacity : " + aList.Capacity);
            Console.WriteLine("After removing........");
            foreach (var i in aList)
            {
                Console.WriteLine(i);
            }



            //Count and a Capacity Property
            Console.WriteLine("Updated Count : " + aList.Count);
            Console.WriteLine("Updated Capacity : " + aList.Capacity);

            Console.WriteLine("Updated Printing Values.........");
            foreach (var i in aList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
