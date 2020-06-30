using System;

namespace DSA
{
    public class MyQueue<T>
    {
        private int Front;
        private int Rear;
        private int Size;
        private T[] queue;

        public MyQueue(int size)
        {
            //Two pointers keep track of location of the elements in the queue.
            Front = -1;
            Rear = -1;
            Size = size;
            queue = new T[size];
        }

        public void Enqueue(T input)
        {
            if (IsFull())
            {
                Console.WriteLine("Full");
            }
            else
            {
                //When queueing the first element we set front to 0.
                if (Front == -1)
                    Front = 0;
                //Increase rear and add element there.
                Rear++;
                queue[Rear] = input;
                Console.WriteLine($"Inserted {input}");
            }
        }

        public object Dequeue()
        {
            T element;
            if (IsEmpty())
            {
                Console.WriteLine("Empty");
                return null;
            }
            //Save the first element before moving location.
            element = queue[Front];
            //This indicates the queue is empty.
            if (Front >= Rear)
            {
                Front = -1;
                Rear = -1;
            }
            else
            {
                //Otherwise we change the front location.
                Front++;
            }
            Console.WriteLine($"Removed {element}");
            return element;
        }

        public bool IsEmpty() =>
            //The front of the queue is empty.
            Front == -1;

        public bool IsFull() =>
            //The front of the queue is 0 and the rear size is the max size.
            Front == 0 && Rear == Size - 1;

        public T Peek() =>
            queue[Front];
    }
}