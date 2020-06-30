using System;
using System.Collections.Generic;
using System.Linq;
using static DSA.Lisp;

namespace DSA
{
    public class Recursion<T> 
    {
        //In use, don't touch.
        public static List<T> SkipElement(
            List<T> list
            , int skip
            , List<T> newList = null)
        {
            newList ??= new List<T>();
            if (newList.Count == list.Count - 1) return newList;
            newList.Add(list[skip]);
            return SkipElement(list, skip + 1, newList);
        }

        public static int GetCount(List<int> list, int count = 0)
        {
            if (list.Count <= 0) return count;
            return GetCount(list.Rest(), count + 1);
        }

        //We should change this to where it only works on List<int> and create and overload for string
        //That gets size.
        public static int GetSum(List<int> list, int sum = 0)
        {
            if (GetCount(list) <= 0) return sum;
            sum += list.First();
            return GetSum(list.Rest(), sum);
        }

        public static bool IsMember(List<int> list, T item)
        {
            if (GetCount(list) <= 0) return false;
            return item.Equals(list.First())
                   || IsMember(list.Rest(), item);
        }

        public static List<int> ApplyFunc(
            List<int> list
            , Func<int, int> func
            , List<int> newList = null)
        {
            newList ??= new List<int>();
            if (GetCount(list) <= 0) return newList;
            newList.Add(func(list.First()));
            return ApplyFunc(
                list.Rest()
                , func
                , newList);
        }

        public static int GetMaxElement(List<int> list, int max = int.MinValue)
        {
            if (GetCount(list) <= 0) return max;
            if (list.First() > max)
            {
                max = list.First();
            }

            return GetMaxElement(list.Rest(), max);
        }

        public static int GetMinElement(List<int> list, int min = int.MaxValue)
        {
            if (GetCount(list) <= 0) return min;
            if (list.First() < min)
            {
                min = Convert.ToInt32(list.First());
            }

            return GetMinElement(list.Rest(), min);
        }

        //Should work on numbers only or string sizes.
        public static int GetAverage(List<int> list) =>
            GetSum(list) / GetCount(list);
    }
}