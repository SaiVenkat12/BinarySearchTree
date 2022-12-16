using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            BinaryTree<int> binarySearchTree = new BinaryTree<int>(56);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(70);
            binarySearchTree.AddNode(22);
            binarySearchTree.AddNode(40);
            binarySearchTree.AddNode(60);
            binarySearchTree.AddNode(95);
            binarySearchTree.AddNode(11);
            binarySearchTree.AddNode(65);
            binarySearchTree.AddNode(31);
            binarySearchTree.AddNode(16);
            binarySearchTree.AddNode(63);
            binarySearchTree.AddNode(67);

            binarySearchTree.Display();
            binarySearchTree.getSize();

            bool result = binarySearchTree.ifExist(63, binarySearchTree);
            Console.WriteLine(result);
        }
    }
}