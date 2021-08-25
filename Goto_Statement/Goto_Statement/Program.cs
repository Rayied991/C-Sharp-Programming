using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement
{
    class Program
    {
        /*
         The goto is C#  unconditional jump statement. When encountered, program flow jumps to the location specified by the goto.

                The goto requires a label of operation. A label is a valid C# identifier followed by colon.
          */
        static void Main(string[] args)
        {
            for(int i = 1; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("In case 1");
                        goto case 3;
                    case 2:
                        Console.WriteLine("In case 2");
                        goto case 1;
                    case 3:
                        Console.WriteLine("In case 3");
                        goto default;
                    default:
                        Console.WriteLine("In default");
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
