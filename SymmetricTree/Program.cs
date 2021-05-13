using Common;
using System;

namespace SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(2);
            root.Left.Left = new Node(3);
            root.Left.Right = new Node(4);
            root.Right.Left = new Node(4);
            root.Right.Right = new Node(3);
            Operation treeOperation = new Operation();
            bool result = treeOperation.IsSymmetric(root);
        }
    }
}
