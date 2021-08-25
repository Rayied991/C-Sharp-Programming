using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             As with other objects, when you assign one array reference variable to another, you are
           simply making both variables refer to the same array. You are neither causing a copy of the
            array to be created, nor are you causing the contents of one array to be copied to the other.
             */

            //Assigning Array Reference Variables

            int i;
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            for (i = 0; i < 10; i++)
            {
                nums1[i] = i;//0-9
            }
            for (i = 0; i < 10; i++)
            {
                nums2[i] = -i;//0-9
            }

            Console.Write("Here is nums1: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(nums1[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Here is nums2: ");
            for (i = 0; i < 10; i++)
            {

                Console.Write(nums2[i] + " ");
            }
            Console.WriteLine();
            nums2 = nums1; // now nums2 refers to nums1
            Console.Write("Here is nums2 after assignment: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(nums2[i] + " ");
            }            
            Console.WriteLine();
            // Next, operate on nums1 array through nums2.
            nums2[3] = 99;
            Console.Write("Here is nums1 after change through nums2: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(nums1[i] + " ");
            }     
            Console.ReadLine();
        }
    }
}
