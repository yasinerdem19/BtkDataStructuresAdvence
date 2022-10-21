﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>,ICloneable
    {
        private T[] InnerList;
        public int Count { get; private set; }
        public int Capasity => InnerList.Length;

        public void Add(T item)
        {
            if (InnerList.Length == Count)
                DoubleArray();
            InnerList[Count] = item;
            Count++;
        }
        public T Remove()
        {
            if (Count==0)
                throw new Exception("There is no item to be removed from the array.");
            if (InnerList.Length/4==Count)
                HalfArray();
            
            
            var temp=InnerList[Count-1];
            if (Count>0)
                Count--;
            return temp;
        }

        private void HalfArray()
        {
            if (InnerList.Length>2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, InnerList.Length/4 );
                InnerList = temp;
            }
        }

        public void DiziyiListele()
        {
            foreach (var item in InnerList)
            {
                Console.WriteLine(item);
            }
        }
        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];
            /*
            for (int i = 0; i < InnerList.Length; i++)
            {
                temp[i] = InnerList[i];
            }
            */
            System.Array.Copy(InnerList, temp,InnerList.Length);
            InnerList = temp;
        }

        public Array()
        {
            InnerList=new T[2];
            Count = 0;
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
