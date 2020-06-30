using System.Collections.Generic;

namespace DSA
{
    public class MyHeap
    {
        public void Heapify(List<int> array, int i)
        {
            int size = array.Count; //The size of the array.
            int largest = i; //The largest element in the array.
            
            int l = 2 * i + 1; //20
            int r = 2 * i + 2; //21
            
            if (l < size && array[l] > array[array.IndexOf(largest)])
                largest = l;
            if (r < size && array[r] > array[array.IndexOf(largest)])
                largest = r;

            if (largest != i)
            {
                int temp = array[largest];
                array[largest] = array[i];
                array[i] = temp;
                Heapify(array, largest);
            }
        }
    }
}