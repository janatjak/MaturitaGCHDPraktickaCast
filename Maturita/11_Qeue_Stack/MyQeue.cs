using System;

namespace Maturita._11_Qeue_Stack
{
    public class MyQeue<T>
    {
        private T[] _items;
        public int Count { get; private set; }

        public MyQeue(int count = 10)
        {
            _items = new T[count];
            Count = 0;
        }

        public void Enqueue(T item)
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

        public void Dequeue()
        {
            if (Count == 0)
                return;

            for (var i = 0; i < Count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_items.Length - 1] = default(T);
            Count--;
        }

        public T Peek()
        {
            return _items[0];
        }
    }
}