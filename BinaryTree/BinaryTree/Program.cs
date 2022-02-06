using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Welcome to Binary search tree program...");
            Console.WriteLine("Inserted nodes are : ");
            BinaryTree<int> binarySearchTree = new BinaryTree<int>(56);
            binarySearchTree.InsertNode(30);
            binarySearchTree.InsertNode(70);
            binarySearchTree.InsertNode(22);
            binarySearchTree.InsertNode(40);
            binarySearchTree.InsertNode(60);
            binarySearchTree.InsertNode(95);
            binarySearchTree.InsertNode(11);
            binarySearchTree.InsertNode(65);
            binarySearchTree.InsertNode(3);
            binarySearchTree.InsertNode(16);
            binarySearchTree.InsertNode(63);
            binarySearchTree.InsertNode(67);
            //Display the binary binary search tree 
            binarySearchTree.Display();
            //Getting the size of Binary search tree
            binarySearchTree.GetSize();
        }
    }
}
