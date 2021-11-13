using System;

namespace Indexers
{
    class Students
    {
        ////Rayied
        //private char[] arr1 = new char[6];/storing single name

        //storing multiple name
        //We need list of students not a single name
        //Indexers-> is a special type of property which behaves like an array
        string[] ar1 = new string[3];//0->ABC; 1->DEF; 2->PQR 

        //indexers
        //we use indexers to easily assign values
        public string this[int i]
        {
            get { return ar1[i]; }
            set { ar1[i] = value; }
        }
        //indexer overloading
        public string this[string name]
        {
            get {
                foreach(string s1 in ar1)
                {
                    if (s1.ToLower() == name.ToLower())
                        // Abc->abc==ABC->abc
                    {
                        return s1.ToUpper();
                    }
                   
                    
                }
                return null;
               
            }
            
        }

        //not easy
       /* 
        public void setAr1(string ar1,string ar2, string ar3)
        {
            this.ar1[0]=ar1;
            this.ar1[1]=ar2;
            this.ar1[2]=ar3;
        }
        public string getAr1()
        {
            return ar1[0];
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students slist = new Students();
            /*slist.setAr1("MD.Shahzad Hussain Rayied","Asif","Alif");
            Console.WriteLine(slist.getAr1());*/

            //slist is actually an object but behaves like an array
            slist[0] = "Abc";
            slist[1] = "DEF";
            slist[2] = "PQR";

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(slist[i]);
            }
           // Students slist2 = new Students();

            //Overloaded Indexer
            Console.WriteLine(slist["ABC"]);
            Console.ReadKey();
        }
    }
}
