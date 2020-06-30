using System;

namespace DSA
{
    //TODO: Annotate class for learning.
    public class MyLinkedList<T>
    {
        public Node<T> Head;

        public void AddToFront(T input)
        {
            var newNode = new Node<T>(input) {Next = Head};
            Head = newNode;
        }

        public void AddToRear(T input)
        {
            var newNode = new Node<T>(input);
            Head ??= newNode;

            var last = Head;
            while (last.Next != null)
            {
                last = last.Next;
            }

            last.Next = newNode;
        }

        public void AddToMiddle(Node<T> prevNode, T input)
        {
            var newNode = new Node<T>(input);

            if (prevNode == null)
            {
                Console.WriteLine("NULL");
                return;
            }

            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        public void DeleteFromFront()
        {
            Head = Head.Next;
        }

        public void DeleteFromEnd()
        {
            var temp = Head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
        }

        public void DeleteFromMiddle(int postition)
        {
            var temp = Head;
            for (int i = 2; i < postition; i++)
            {
                if (temp.Next != null)
                {
                    temp = temp.Next;
                }
            }
            temp.Next = temp.Next.Next;
        }
    }
}