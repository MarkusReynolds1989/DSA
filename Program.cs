using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using DSA.Sorting;

namespace DSA
{
    class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random(System.DateTime.Now.Millisecond);
            var vec = new Vector<int>(10);
            Console.WriteLine("Contents:");
            for (var i = 0; i < vec.Total; i++)
            {
                vec.Add(rand.Next(0,100));
            }
            
            for(var i = 0; i < vec.Total; i++) 
            {
                Console.WriteLine(vec.Get(i));
            }
            Console.WriteLine($"Total Size:{vec.Total}");
            Console.Write($"Index: {vec.Index}");
        }
    }
}