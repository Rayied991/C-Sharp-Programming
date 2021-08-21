using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\" C#");//printing with quotation
            string phrase = "Hello c#";
            Console.WriteLine(phrase);
            phrase = phrase + " is cool";
            Console.WriteLine(phrase);
            Console.WriteLine("Length of the Phrase string = " + phrase.Length);
            Console.WriteLine("after converting string to uppercase = " + phrase.ToUpper());
            Console.WriteLine("after converting string to Lowercase = " + phrase.ToLower());

            //concatination
            //way-1
            string firstname = "Rayied";
            string lastname = "Hussain";
            string fullname = firstname + lastname;
            Console.WriteLine("Full name is = " + fullname);

            //way-2
           string fname = "Asif";
            string lname = "Zaman";
            string name = string.Concat(fname, lname);
            Console.WriteLine("Full name is = " + name);

            //Hashcode() Method-> returns HashValue of specified string.
            Console.WriteLine("Hashcode of the string = "+fname.GetHashCode());//Returns HashCode of String


            //Gettype() method-> It returns the System.Type of current instance.
            Console.WriteLine("Type of the string si = "+fname.GetType());//Returns type of string


            //Gettypecode() method->It returns the System.TypeCode for class System.String.

            Console.WriteLine("Type of a string = "+fname.GetTypeCode());//Returns type of string

            //insert() method->Insert the string or character in the string at the specified position.
            Console.WriteLine("After inserting:");
            Console.WriteLine(fname.Insert(0,"Hello "));//Insert substring into string

            //isnormalized() method->This method checks whether this string is in Unicode normalization form C.
            Console.WriteLine("Normalized = "+fname.IsNormalized());//Check Whether string is in Unicode normalization from C

            //Lastindexof() method->Returns the index position of last occurrence of specified character.
            Console.WriteLine("Last index position = "+fname.LastIndexOf("n")); //Returns the last index position of specified value

            //Remove() method->This method deletes all the characters from beginning to specified index position.

            Console.WriteLine(fname.Remove(2));//Deletes all the characters from begining to specified index.

            //Replace() method->This method replaces the character.

            Console.WriteLine(fname.Replace('s', 'i')); // Replace the character

            //split() method->This method splits the string based on specified value.
            string ne= "Acedesdeknm";
            string[] split = ne.Split(new char[] { 'e' }); //Split the string based on specified value


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            //startswith() method->It checks whether the first character of string is same as specified character.

            Console.WriteLine(fname.StartsWith("A")); //Check wheter first character of string is same as specified value

            //tochararray() method->Converts string into char array.

            Console.WriteLine(fname.ToCharArray());
            //Converts an string into char array.

            //trim() method->	It removes extra whitespaces from beginning and ending of string.

            Console.WriteLine(fname.Trim());
            //It removes starting and ending white spaces from string
            

          //Compareto() method->Compare two strings and returns integer value as output. It returns 0 for true and 1 for false

           Console.WriteLine("Comparing fname and lname = "+fname.CompareTo(lname));//Compare two string value and returns 0 for true and 1 for false

            //Endwith() Method->checks whether specified character is the last character of string or not
            Console.WriteLine("The character is last string = " + fname.EndsWith("n"));//Check whether specified value is the last character of string

            //Equals() Method->The Equals Method in C# compares two string and returns Boolean value as output.
            string n1 = "AMD";
            string n2 = "AMD";
            Console.WriteLine("Checking equlity = " + n1.Equals(n2));//Compare two string and returns true and false


            
                
            //String interpolation
            string name1 = "Aritra";
            string name2 = "Das";
            string fname1 = $"My full name is = {name1}{name2}";
            Console.WriteLine(fname1);

            //clone() method->make clone of strings
            Console.WriteLine("The clone of name1 = " + name1.Clone());

           


            //Contains method-> returns true/false
            string str = "Hello Bnagladesh";
            Console.WriteLine("String contains Hello = " + str.Contains("Hello"));
            Console.WriteLine("String contains 1 = " + str.Contains("1"));

            //Accessing strings
            //way-1
            Console.WriteLine("First character of the string is = "+str[0]);
            Console.WriteLine("Second character of the string is = "+str[1]);

            //way-2
            //indexof method->find the index position of a specific character in a string
            Console.WriteLine(str.IndexOf("Hello"));//0
            Console.WriteLine(str.IndexOf("ello"));//1
            Console.WriteLine(str.IndexOf("lo"));//3
            Console.WriteLine(str.IndexOf("y"));//returns -1 (if the string is not available)


            //substring method->
            //which extracts the characters from a string,
            //starting from the specified character position/index,
            //and returns a new string.
            //This method is often used together with IndexOf() to get the specific character position

            Console.WriteLine("Index 6 Character = "+str.Substring(6));//outputs index 6 character
            Console.WriteLine("Position 6 to 11 chararacter = "+str.Substring(0,2));//returns 6 to 11 position strings
            int pos = str.IndexOf("o");
            string last = str.Substring(pos);
            Console.WriteLine(last);

            //Escape sequence character
         
            Console.WriteLine("Hello this is \" Rayied");
            Console.WriteLine("The character \\ is called backslash.");//printing backslash
            Console.WriteLine("We are the so-called \"Vikings\" from the north.");//printing quotations

            Console.ReadLine();
        }
    }
}
