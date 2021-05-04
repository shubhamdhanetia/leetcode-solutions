using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree bTree = new BTree();
            bTree.Insert(10);
            bTree.Insert(8);
            bTree.Insert(12);
            bTree.Insert(11);
            bTree.Insert(7);
            bTree.Insert(9);
            var result = bTree.InOrderTraversal();


        }
    }
} 
