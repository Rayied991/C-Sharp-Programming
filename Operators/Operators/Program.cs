using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=4,b=2;
            //Operators in C#


            Console.WriteLine("The Arithmetic Operators: ");
            //Arithmetic Operators

            Console.WriteLine("The value of a+b is = " + (a + b));
            Console.WriteLine("The value of a-b is = " + (a - b));
            Console.WriteLine("The value of a*b is = " + (a * b));
            Console.WriteLine("The value of a/b is = " + (a / b));
            Console.WriteLine("The value of a%b is = " + (a % b));
            a++;
            b++;
            Console.WriteLine("The value of a++ is = " + a);
            Console.WriteLine("The value of b++ is = " + b);
            ++a;
            ++b;
            Console.WriteLine("The value of ++a is = " + a);
            Console.WriteLine("The value of ++b is = " + b);


            Console.WriteLine("The Assignment Operators: ");
            //Assignment Operators

            int c = 4;
            int d = c;
            Console.WriteLine(d);
            d += 4;
            Console.WriteLine("The value of d+4 = "+d);
            d -= 4;
            Console.WriteLine("The value of d-4 = " + d);
            d *= 2;
            Console.WriteLine("The value of d*2 = " + d);
            d /= 2;
            Console.WriteLine("The value of d/2 = " + d);
            d %= 2;
            Console.WriteLine("The value of d%2 = " + d);

            Console.WriteLine(d);

            Console.WriteLine("The Comparison Operators: ");
            //Comparison Operators

            Console.WriteLine(324==5);// returns False because 324 is not equal to 5
            Console.WriteLine(324>5);
            Console.WriteLine(324>555);
            Console.WriteLine(324>=555);
            Console.WriteLine(324<555);
            Console.WriteLine(324<=555);
            Console.WriteLine(5!=3); // returns True because 5 is not equal to 3

           

            Console.WriteLine("The Logical Operators: ");
            //Logical Operators(operates in two boolean types)

            Console.WriteLine(true & false);
            Console.WriteLine(true & true);
            Console.WriteLine(false & false); 
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);  
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            bool b1 = true, b2 = false;
            Console.WriteLine(b1^b2);//X-OR operator(^)
            Console.WriteLine(b2 ^ b1);
            Console.WriteLine(false ^ false);
            Console.WriteLine(true ^ true);

            Console.WriteLine("Ternary Operator: ");
            //Ternary Operator

            int a4 = 2;
            int b4 = 5;
            int min = (a4 < b4) ? a4 : b4;//if (a>b) true then it will print maximum value=5 else 2
            Console.WriteLine(min);

            Console.WriteLine("Implication Operator: ");
            //Implication Operator
            Console.WriteLine("True implies True is = " + (true | true));
            Console.WriteLine("True implies false is = " + (true | false));
            Console.WriteLine("false implies true is = " + (false | true));
            Console.WriteLine("false implies false is = " + (false | false));

            Console.WriteLine("Bitwise Operator: ");
            //Bitwise Operator
            /*   & = Bitwise AND
               | = Bitwise OR
             ^ = Bitwise exclusive OR(XOR)
             >> - Shift right
                 << - Shift left
               ~  = One’s complement(unary NOT)*/

            Console.WriteLine("Left Shift Operator: ");
            //Left Shift operator
            Console.WriteLine(10 << 2);//10*2^2=10*4=40
            Console.WriteLine(10 << 3);//10*2^3=10*8=80
            Console.WriteLine(20 << 2);//2-*2^2=20*4=80
            Console.WriteLine(15 << 4);//15*2^4=15*16=240

            Console.WriteLine("Right Shift Operator: ");
            //Right shift operator
            Console.WriteLine(10 >> 2);//10/2^2=10/4=2
            Console.WriteLine(20 >> 2);//20/2^2=20/4=5
            Console.WriteLine(20 >> 3);//20/2^3=20/8=2

            Console.WriteLine("Bitwise AND Operator: ");
            //AND Operator->Logical && and Bitwise &
            //&& if the first condition is found false,then he will not check next condition
            //& if the first condition is found false,then he will check next condition


            int A = 10;
            int B = 5;
            int C = 20;
            Console.WriteLine(A < B && A < C);//false && true=false
            Console.WriteLine(A < B & A < C);//false & true=false
            Console.WriteLine(A < B && A++ < C);//false && true=false
            Console.WriteLine(A );//10(not incremented) Because 2nd condition is not checked
            Console.WriteLine(A < B && A++ < C);//false & true=false
            Console.WriteLine(A);//11(incremented) because 2nd condition  is checked

            Console.WriteLine("Bitwise OR Operator: ");
            //OR Operator Example: logical  ||  and Bitwise |
            // ||->if first condition is true then it will not check the second condition
            //|->if first condition is true/false then it will also check the second condition
            int a3 = 10;
            int b3 = 5;
            int c3 = 20;
            Console.WriteLine(a3 > b3 || a3 < c3);//true||true=true
            Console.WriteLine(a3 > b3 | a3 < c3);//true|true=true

            int A1 = 10;
            int B1 = 5;
            int C1 = 20;
            Console.WriteLine(A1 > B1 || A1++ < C1);//true||true=true
            Console.WriteLine(A1);//10(not incremented) Because 2nd condition is not checked
            Console.WriteLine(A1 > B1 | A1++ < C1);//true|| true=true
            Console.WriteLine(A1);//11(incremented) because 2nd condition  is checked

            Console.ReadLine();
        }
    }
}
