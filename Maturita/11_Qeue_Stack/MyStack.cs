using System;

namespace Maturita._11_Qeue_Stack
{
    public class MyStack<T>
    {
        private T[] _items;
        public int Count { get; private set; }

        public MyStack(int count = 10)
        {
            _items = new T[count];
            Count = 0;
        }

        public void Push(T item)
        {
            if (Array.IndexOf(_items, default(T)) == -1)
            {
                var newItems = new T[Count * 2];
                _items.CopyTo(newItems, 0);
                _items = newItems;
            }

            _items[Count] = item;
            Count++;
        }

        public void Pop()
        {
            if (Count == 0)
                return;

            _items[Count - 1] = default(T);
            Count--;
        }

        public T Peek()
        {
            return _items[Count - 1];
        }
    }
}