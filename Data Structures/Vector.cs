using System;

namespace DSA
{
    public class Vector<T>
    {
        public int Total { get; set; }
        public int Index { get; set; }
        public T[] Data { get; set; }
        
        public Vector(int initSize)
        {
           InitVec(initSize); 
        }
        
        private void InitVec(int initSize)
        {
            Data = new T[initSize];
            Total = Data.Length;
            Index = -1;
        }

        public void Add(T data)
        {
            if (Total > Index - 1)
            {
                Total++;
                Array.Resize(Data, Total); 
            }
            
            Data[++Index] = data;
        }

        public void Remove(int element)
        {
        }

        public T Get(int element) =>
            Data[element];
    }
}