using System;
using System.Collections.Generic;

namespace DSA
{
    public class SlidingWindow
    {
        
        /* FindMaxSubArray list : int[], elements : int
         * Declare a variable maxSum : int to hold the sum init it as 0.
         * Loop
         * Declare a variable i with value 0
         * Stop when i is equal to elementWindow
         * increment i
         * {
         *     through the first element window of the array and add them to maxSum.
         * }
         * Declare a variable windowSum : int and initiate it with maxSum.
         * Loop
         * Declare a variable i with value elementWindow
         * Stop the loop when i is greater than the size of the list.
         * Increment i by one.
         * {
         *     windowSum is the current element - the element - the elementWindow.
         *     maxSum is the maximum between maxSum and windowSum
         * }
         * return maxSum
         */
        
        public static int FindMaxSubArray(List<int> list, int elementWindow)
        {
            var maxSum = 0;
            //Sum the first target from array.  
            for(int i = 0; i < elementWindow; i++)
            {
                maxSum += list[i];
            }
            
            //Save the max sum as the window sum.
            var windowSum = maxSum;
            
            //Cycle through from the first window until the array is over.
            for (var i = elementWindow; i < list.Count; i++)
            {
                //Sum up the current window. A math trick to get the sum.
                windowSum += list[i] - list[i - elementWindow];
                //Find the max from the first one and the next one.
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }

        public static int FindMinSubArray(List<int> list, int target)
        {
            var minSum = 0;

            for (var i = 0; i < target; i++)
            {
                minSum -= list[i];
            }

            var windowSum = minSum;

            for (int i = target; i < list.Count; i++)
            {
                windowSum -= list[i] - list[i - target];
                minSum = Math.Min(minSum,windowSum);
            }
            
            return minSum;
        }
    }
}