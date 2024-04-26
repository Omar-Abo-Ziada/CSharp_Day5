using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class MyList<T> : IEnumerable
    {
        protected T[] items;
        int currentIndex;

        public int Count
        {
            get
            {
                return currentIndex + 1;
            }
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                if (index < Count)
                    items[index] = value;
            }
        }

        public MyList() 
        {
            items = new T[5];
            currentIndex = -1;
        }

        public void Add(T item) 
        {
            if (currentIndex == items.Length - 1)
                Extende();

            currentIndex++;
            items[currentIndex] = item;
        }

        public T GetByIndex(int index)
        {
            return items[index];
        }

        private void Extende()
        {
            
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            MyList<T> myList;
            int index;

            public Iterator(MyList<T> myList)
            {
                this.myList = myList;
                index = -1;
            }

            public object Current
            {
                get
                {
                    return myList.items[index];
                }
            }

            public bool MoveNext()
            {
                index++;

                return index <= myList.currentIndex;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
