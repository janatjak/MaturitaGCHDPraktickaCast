using System.Collections.Generic;

namespace Maturita._14_Linked_List
{
    public class MyLinkedList<T>
    {
        private Node<T> _first;

        public MyLinkedList(T value)
        {
            _first = new Node<T>(value);
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

        private Node<T> GetPreviousNode(Node<T> node)
        {
            var previousNode = _first;

            while (true)
            {
                if (previousNode == null)
                    return null;

                if (node.Equals(previousNode.Next))
                    return node;

                previousNode = previousNode.Next;
            }
        }

        public void InsertBefore(Node<T> node, T value)
        {
            var newNode = new Node<T>(value) {Next = node};

            if (node.Equals(_first))
            {
                _first = newNode;
                return;
            }

            var previousNode = GetPreviousNode(node);
            previousNode.Next = newNode;
        }

        public void InsertAfter(Node<T> node, T value)
        {
            var newNode = new Node<T>(value) {Next = node.Next};
            node.Next = newNode;
        }

        public bool Contains(T value)
        {
            return GetFirstNodeWithValue(value, _first) != null;
        }

        public void DeleteFirst(T value)
        {
            var node = FindFirst(value);
            if (node == null)
                return;

            if (node.Equals(_first))
                _first = _first.Next;

            var previousNode = GetPreviousNode(node);
            previousNode.Next = node.Next;
        }

        public Node<T> FindFirst(T value)
        {
            return GetFirstNodeWithValue(value, _first);
        }
    }
}