using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class BinarySearch
    {
        public void binarySearch()
        {
            // Create an array of 10 elements
            int[] IntArray = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };
            // Vaue to search for
            int target = 17;
            int pos = Array.BinarySearch(IntArray, target);
            if (pos >= 0)
                Console.WriteLine($"Item {IntArray[pos].ToString()} found at position {pos + 1}.");
            else
                Console.WriteLine("Item not found.");
            Console.ReadKey();
        }
    }
}
