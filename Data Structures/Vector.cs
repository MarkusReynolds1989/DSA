namespace DSA
{
    public class Vector<T>
    {
        public int Total { get; set; }
        public int CurrentElement { get; set; }
        public T[] Data { get; set; }

        public void InitVec(int size)
        {
            Data.Initialize();
        }

        public void Add(T data)
        {
            Total++;
            Data[CurrentElement++] = data;
        }

        public void Remove(int element)
        {
            Total--;
        }
    }
}