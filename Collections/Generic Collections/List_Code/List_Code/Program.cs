using System;
using System.Collections.Generic;

namespace List_Code
{
    class students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double cgpa { get; set; }
    }
    class Program
    {
        //Generic Collections-> type safe
        //list
        //queue
        //stack
        //sortedlist<key,value>
        //dictionary<key,value>
        //hashset-> non-duplicate value

        //User defined type list
        
        static void Main(string[] args)
        {
            //   Pre defined datatype of List
            //List
            Console.WriteLine("*************Pre-Defined type List*************");
            List<int> List1 = new List<int>();

            List1.Add(111);
            //List1.Add(34.5);
            List1.Add(1);
            Console.WriteLine("Count of List1= " + List1.Count);
            Console.WriteLine("Capacity of List1= " + List1.Capacity);
            Console.WriteLine("List1 values:");
            foreach (int i in List1)
            {
                Console.WriteLine(i);
            }
            List<string> list2 = new List<string>();
            list2.Add("Hello");
            Console.WriteLine("Count of List2= " + list2.Count);
            Console.WriteLine("Capacity of List2= " + list2.Capacity);
            Console.WriteLine("List2 values:");
            foreach (string i in list2)
            {
                Console.WriteLine(i);
            }

            //User defined list
            students s = new students();
            s.Id = 1;
            s.Name = "Rasel";
            s.cgpa = 3.76;
            Console.WriteLine("*************User-Defined type List*************");
            List<students> slist = new List<students>()
            {
                //while creating the list the values are assigned
                new students{Id=2,Name="Asif",cgpa=3.92},//0
                new students{Id=3,Name="Alif",cgpa=3.40},//2
                new students{Id=4,Name="Hemal",cgpa=3.77}//3
                //cannot be removed 
                //can e removed by removeAt()
            };
            slist.Insert(1, s);//1
            //index,item
            Console.WriteLine("Before remove...");
            foreach (students i in slist)
            {
                //Console.WriteLine(i);//get addresses
                Console.WriteLine("Id : " + i.Id + "Name : " + i.Name + "Cgpa : " + i.cgpa);
            }
            Console.ReadKey();

            slist.Remove(s);
            Console.WriteLine("After remove:");
            foreach (students i in slist)
            {

                Console.WriteLine("Id : " + i.Id + "Name : " + i.Name + "Cgpa : " + i.cgpa);
            }
            slist.RemoveAt(0);
            Console.WriteLine("After removeAt:");
            foreach (students i in slist)
            {

                Console.WriteLine("Id : " + i.Id + "Name : " + i.Name + "Cgpa : " + i.cgpa);
            }
        }
    }
}
