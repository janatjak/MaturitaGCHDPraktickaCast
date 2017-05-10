using System.Collections.Generic;

namespace Maturita._14_Linked_List
{
    public class MyLinkedList<T>
    {
        private Node<T> _first;

        public MyLinkedList(T value)
        {
            _first = new Node<T>(value);

            var li = new LinkedList<int>();
        }

        private Node<T> GetFirstNodeWithValue(T value, Node<T> node)
        {
            while (true)
            {
                if (node == null)
                    return null;

                if (value.Equals(node.Value))
                    return node;

                node = node.Next;
            }
        }

        public void InsertBefore(Node<T> node, T value)
        {

        }

        public void InsertAfter(Node<T> node, T value)
        {

        }

        public bool Contains(T value)
        {
            return GetFirstNodeWithValue(value, _first) != null;
        }

        public void DeleteFirst(T value)
        {
            var node = FindFirst(value)
        }

        public Node<T> FindFirst(T value)
        {
            return GetFirstNodeWithValue(value, _first);
        }
    }
}