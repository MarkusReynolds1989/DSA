using System;

namespace DSA.Sorting
{
    public static class MergeSort
    {
        // Split Array
        public static int[] FnMerge(int[] array)
        {
            // First slice goes up to half.
            var half1 = array[..(array.Length / 2)];
            // Second slice goes from half to the end.
            var half2 = array[(array.Length / 2)..];
            // Sort both of them.
            // Works from here.
            var sorted1 = Sort(half1, 0);
            var sorted2 = Sort(half2, 0);

            // Do the merge.
            return Merge(sorted1, sorted2);
        }

        public static int[] Merge(int[] array1
            , int[] array2
            , int lPos = 0
            , int rPos = 0
            , int count = 0
            , int[] sorted = default
        )
        {
            sorted ??= new int[array1.Length + array2.Length];

            // If there are no more elements in either array
            if (count > array1.Length + array2.Length - 1)
            {
                return sorted;
            }

            if (array1[lPos] < array2[rPos])
            {
                sorted[count] = array1[lPos];
                if (lPos < array1.Length - 1)
                {
                    lPos += 1;
                }
            }
            else
            {
                sorted[count] = array2[rPos];
                if (rPos < array2.Length - 1)
                {
                    rPos += 1;
                }
            }

            return Merge(array1, array2, lPos, rPos, count + 1, sorted);
        }

        // Destructive sort.
        public static int[] Sort(int[] array, int count)
        {
            if (count >= array.Length - 1)
            {
                return array;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    var temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            return Sort(array, count + 1);
        }
    }
}