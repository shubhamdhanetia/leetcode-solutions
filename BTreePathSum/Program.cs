using Common;
using System;

namespace BTreePathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree bTree = new BTree();
            bTree.Insert(10);
            bTree.Insert(5);
            bTree.Insert(15);
            bTree.Insert(4);
            bTree.Insert(6);
            bTree.Insert(7);
            bTree.Insert(12);
            bTree.Insert(17);
            BTreeHelper treeHelper = new BTreeHelper();
            bool result = treeHelper.HasPathSumRecursive(bTree.GetRootNode(), 42);
            bool result1 = treeHelper.HasPathSumIterative(bTree.GetRootNode(), 42);
            treeHelper.PrintRootToLeaf(bTree.GetRootNode());
        }
    }
}
