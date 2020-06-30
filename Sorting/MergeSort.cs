using System;

namespace DSA.Sorting
{
    public class MergeSort
    {
        // Split Array
        public int[] Merge(int[] array)
        {
            // First slice goes up to half.
            var half1 = array[Range.EndAt(array.Length/2)];
            // Second slice goes from half to the end.
            var half2 = array[Range.StartAt(array.Length/2 + 1)];
            // Sort both of them.
            var sorted1 = Sort(half1,0);
            var sorted2 = Sort(half2, 0);
            
            // Merge them together.
        }

        public int[] Sort(int[] array, int count)
        {
            int[] sorted = {};
            if (count > array.Length)
            {
                return sorted;
            }
            
        }
    }
}