using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] nums = new int[10];
            Console.WriteLine("Length of nums is " + nums.Length);//10
            // Use Length to initialize nums.
            for ( i = 0; i < nums.Length; i++)
            {
                nums[i] = i * i;//0 1 4 9 16 25 36 49 64 81
            }
            // Now use Length to display nums.
            Console.Write("Here is nums: ");
            for ( i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");////0 1 4 9 16 25 36 49 64 81
            }

            int[,,] nums2 = new int[10, 5, 6];
            Console.WriteLine("Length of nums is " + nums2.Length);//300



            // Reverse an array
            
            int[] nums3 = new int[10];
            int[] nums4 = new int[10];
            for (i = 0; i < nums3.Length; i++)
            {
                nums3[i] = i;
            }
            Console.Write("Original contents: ");
            for (i = 0; i < nums4.Length; i++)
            {
                Console.Write(nums3[i] + " ");
            }
            Console.WriteLine();
            // Reverse copy nums1 to nums2.
            if (nums4.Length >= nums3.Length) // make sure nums2 is long enough
            {
                for (i = 0, j = nums3.Length - 1; i < nums3.Length; i++, j--)
                {

                    nums4[j] = nums3[i];
                }
            }
            Console.Write("Reversed contents: ");
            for (i = 0; i < nums4.Length; i++)
            {
                Console.Write(nums4[i] + " ");
            }


            // Demonstrate Length with jagged arrays.
            int[][] network_nodes = new int[4][];
            network_nodes[0] = new int[3];
            network_nodes[1] = new int[7];
            network_nodes[2] = new int[2];
            network_nodes[3] = new int[5];

            // Fabricate some fake CPU usage data.
            for (i = 0; i < network_nodes.Length; i++)
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    network_nodes[i][j] = i * j + 70;
                }
            }
            Console.WriteLine("Total number of network nodes: " +
            network_nodes.Length + "\n");
            for (i = 0; i < network_nodes.Length; i++)
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    Console.Write("CPU usage at node " + i +
                    " CPU " + j + ": ");
                    Console.Write(network_nodes[i][j] + "% ");
                    Console.WriteLine();
                }
            }


                Console.ReadLine();
        }
    }
}
