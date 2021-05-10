using Common;
using System;

namespace MaximumDepthBTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTreeOperation operation = new BTreeOperation();

            BTree bTree = new BTree();
            bTree.Insert(10);
            bTree.Insert(8);
            bTree.Insert(12);
            bTree.Insert(11);
            bTree.Insert(7);
            bTree.Insert(9);
            bTree.Insert(6);
            int maxdepth = operation.GetMaximumDepth(bTree.GetRootNode());
        }
    }
}
