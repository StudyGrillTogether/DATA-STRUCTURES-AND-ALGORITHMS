using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_11_PRACTICE
{
    internal class Program
    {
        class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        class BinaryTree
        {
            Node root; //points to root node

            public void InOrder(Node node)
            {
                if (node == null) return;
                InOrder(node.left); //go left
                Console.WriteLine(node.data); //print
                InOrder(node.right);//go right
            }

            public void PreOrder(Node node)
            {
                if (node == null) return;
                Console.WriteLine(node.data);
                PreOrder(node.left);
                PreOrder(node.right);
            }

            public void PostOrder(Node node) {
        }

        
        static void Main(string[] args)
        {
        }
    }
}
