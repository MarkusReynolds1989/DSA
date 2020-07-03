using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using DSA.Sorting;

namespace DSA
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Random random = new Random();

            int[] items = new int[9500];
            foreach (var item in Enumerable.Range(0, 9500))
            {
                items[item] = random.Next(0, 999);
            }

            timer.Start();
            var test = MergeSort.FnMerge(items);
            timer.Stop();
            Console.WriteLine($"MergeSort took {timer.Elapsed.Milliseconds}ms or {timer.Elapsed.Seconds}s");
            timer.Reset();
            timer.Start();
            var test2 = MergeSort.Sort(items);
            timer.Stop();
            Console.WriteLine($"Sort took {timer.Elapsed.Milliseconds}ms or {timer.Elapsed.Seconds}s");
        }
    }
}