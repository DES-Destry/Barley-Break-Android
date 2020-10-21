using System;
using System.Collections;
using System.Collections.Generic;

namespace BarleyBreak.Models
{
    class ReferenceCollection<T> : IEnumerable<T>
    {
        private readonly T[] collection;

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                return collection[index];
            }
            set
            {
                collection[index] = value;
            }
        }

        public ReferenceCollection(int size)
        {
            collection = new T[size];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count < collection.Length)
            {
                collection[Count] = item;
                Count++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void AddReference(ref T item)
        {
            if (Count < collection.Length)
            {
                collection[Count] = item;
                Count++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return collection.GetEnumerator();
        }
    }
}
