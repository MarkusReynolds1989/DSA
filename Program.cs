using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DSA.Sorting;

namespace DSA
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] items = {2, 1, 6, 5, 3, 4, 11, 0, 22, 55};
            var test = MergeSort.FnMerge(items);
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}