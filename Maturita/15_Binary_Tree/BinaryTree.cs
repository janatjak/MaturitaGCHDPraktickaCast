using System;
using System.Collections.Generic;

namespace Maturita._15_Binary_Tree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; private set; }

        public BinaryTree(T value)
        {
            Root = new Node<T>(value);
        }

        private Node<T> GetNodeWithValue(T value, Node<T> node)
        {
            while (true)
            {
                if (node == null)
                    return null;

                var compareResult = value.CompareTo(node.Value);

                switch (compareResult)
                {
                    case 1:
                        node = node.Right;
                        continue;
                    case -1:
                        node = node.Left;
                        continue;
                    default:
                        return node;
                }
            }
        }

        private Node<T> GetParentNode(Node<T> node)
        {
            var parentNode = Root;

            while (true)
            {
                var compareResult = node.Value.CompareTo(parentNode.Value);

                switch (compareResult)
                {
                    case 1:
                        if (node.Equals(parentNode.Right))
                            return parentNode;
                        parentNode = parentNode.Right;
                        continue;
                    case -1:
                        if (node.Equals(parentNode.Left))
                            return parentNode;
                        parentNode = parentNode.Left;
                        continue;
                    default:
                        return null;
                }
            }
        }

        public void Insert(T value)
        {
            var node = Root;

            if (node == null)
            {
                Root = new Node<T>(value);
                return;
            }

            while (true)
            {
                var compareResult = value.CompareTo(node.Value);

                switch (compareResult)
                {
                    case 1:
                        if (node.Right == null)
                        {
                            node.Right = new Node<T>(value);
                            return;
                        }
                        node = node.Right;
                        continue;
                    case -1:
                        if (node.Left == null)
                        {
                            node.Left = new Node<T>(value);
                            return;
                        }
                        node = node.Left;
                        continue;
                    default:
                        return;
                }
            }
        }

        public void Delete(T value)
        {
//            var node = GetNodeWithValue(value, Root);
//
//            if (node == null)
//                return;
//
//            var parentNode = GetParentNode(node);
//
//            var left = node.Left;
//            node = node.Right;
//            var i = new SortedSet<int>();
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            return GetNodeWithValue(value, Root) != null;
        }
    }
}