using System;

namespace DSA
{
    public static class TwoPointers
    {
        //Return the two integers that add up to the num.
        public static int[] GetPairSum(int[] array, int num)
        {
            var i = 0;

            var j = array.Length - 1;

            while (i < j)
            {
                if (array[i] + array[j] == num)
                {
                    return new[] {array[i], array[j]};
                }

                if (array[i] + array[j] < num)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return new[] {0, 0};
        }

        //Find if the array contains a part of ints that add up to the sum.
        //Must be sorted to work.
        public static bool IsPairSum(int[] array, int num)
        {
            //First pointer starts at the beginning of the array.
            var i = 0;
            //Second pointer starts at the end of the array.
            var j = array.Length - 1;

            //While first pointer less than second
            while (i < j)
            {
                //If the first solution works great.
                if (array[i] + array[j] == num)
                {
                    return true;
                }

                //Test the elements sum to see if it's less than required.
                //If it's less we increment the first element.
                if (array[i] + array[j] < num)
                {
                    i++;
                }

                //We decrement the second pointer down to test.
                else
                {
                    j--;
                }

                //int[] test = {2, 3, 5, 6, 9};
                //In our case, we start at 2 + 6, which is 8.
            }

            return false;
        }
    }
}