using System;

namespace BinaryTree
{
    internal class BinarySearchTree<T> where T : IComparable
    {
        private T item;

        public BinarySearchTree(T item)
        {
            this.item = item;
        }

        internal void InsertNode<T>(T item) where T : IComparable
        {
            throw new NotImplementedException();
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }
    }
}