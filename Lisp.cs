using System.Collections.Generic;

namespace DSA
{
    public static class Lisp
    {
        public static int First(this List<int> list) =>
            list[0];

        public static double First(this List<double> list) =>
            list[0];

        public static string First(this List<string> list) =>
            list[0];

        public static List<int> Rest(this List<int> list) =>
            Recursion<int>.SkipElement(list,1);

        public static List<string> Rest(this List<string> list) =>
            Recursion<string>.SkipElement(list, 1);
    }
}
