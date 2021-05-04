using Common;
using System;

namespace InvertBTree
{
    class Program
    {
        static void Main(string[] args)
        {
            InvertBTreeHelper invertBTreeHelper = new InvertBTreeHelper();

            BTree bTree = new BTree();
            bTree.Insert(10);
            bTree.Insert(8);
            bTree.Insert(12);
            bTree.Insert(11);
            bTree.Insert(7);
            bTree.Insert(9);

            var result = invertBTreeHelper.InvertBinaryTree(bTree.GetRootNode());
        }
    }
}
