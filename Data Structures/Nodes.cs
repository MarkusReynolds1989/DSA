namespace DSA
{
    public class Node<T>
    {
        //Linked lists are only concerned with the next or previous data.
        private T data;
        public Node<T> Next;

        public Node(T data)
        {
            this.data = data;
            Next = null;
        }
    }

    public class TreeNode<T>
    {
        public T Data;
        public TreeNode<T> Left;
        public TreeNode<T> Right;

        public TreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}