using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public T data;
        public BinaryTree<T> left;
        public BinaryTree<T> right;
        public BinaryTree(T data)
        {
            this.data = data;
            this.left = null; 
            this.right = null;
        }
        int leftCount = 0, rightCount = 0;
        public void AddNode(T Value)
        {
            T NodeValue = this.data;
            if (NodeValue.CompareTo(Value) > 0)
            {
                if (this.left == null)
                    this.left = new BinaryTree<T>(Value);
                else
                    this.left.AddNode(Value);
            }
            else
            {
                if (this.right == null)
                    this.right = new BinaryTree<T>(Value);
                else
                    this.right.AddNode(Value);
            }
        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftCount++;
                this.left.Display();
            }
            Console.WriteLine(this.data);
            if (this.right != null)
            {
                this.rightCount++;
                this.right.Display();
            }
        }
        public void getSize()
        {
            Console.WriteLine("Size of BinarySearch Tree" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool ifExist(T element, BinaryTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.data.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.data);
                return true;
            }
            else
            {
                Console.WriteLine("Current element in {0} in BST", node.data);
            }
            if (element.CompareTo(node.data) < 0)
            {
                ifExist(element, node.left);
            }
            if (element.CompareTo(node.data) > 0)
            {
                ifExist(element, node.right);
            }
            return true;
        }
    }
}
