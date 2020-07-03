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

        public static int[] Merge(
            int[] array1
            , int[] array2
            , int lPos = 0
            , int rPos = 0
            , int count = 0
            , int[] sorted = default
        )
        {
            // Assign sorted if it isn't assigned yet. Basically a default.
            sorted ??= new int[array1.Length + array2.Length];

            // If there are no more elements in either array
            if (count > array1.Length + array2.Length - 1)
            {
                return sorted;
            }

            // Sorted always gets the lessor of the two first.
            // If array1's ele is less than array2's ele
            if (lPos > array1.Length - 1)
            {
                sorted[count] = array2[rPos];
                rPos++;
            }
            else if (rPos > array2.Length - 1)
            {
                sorted[count] = array1[lPos];
                lPos++;
            }
            else
            {
                if (array1[lPos] == array2[rPos])
                {
                    sorted[count] = array1[lPos];
                    lPos++;
                }
                else if (array1[lPos] < array2[rPos])
                {
                    // Sorted gets array1's element
                    sorted[count] = array1[lPos];
                    // Increment array1's element
                    lPos++;
                }
                else if (array1[lPos] > array2[rPos])
                {
                    sorted[count] = array2[rPos];
                    rPos++;
                }
            }

            return Merge(
                array1
                , array2
                , lPos
                , rPos
                , count + 1
                , sorted);
        }

        // Destructive sort.
        public static int[] Sort(int[] array, int count = 0)
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