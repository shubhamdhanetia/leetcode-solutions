using Common;
using System;

namespace MergeBTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeBTreeHelper mergeBTreeHelper = new MergeBTreeHelper();

            BTree bTree = new BTree();
            bTree.Insert(10);
            bTree.Insert(8);
            bTree.Insert(12);
            bTree.Insert(11);
            bTree.Insert(7);
            bTree.Insert(9);

            BTree bTree2 = new BTree();
            bTree2.Insert(10);
            bTree2.Insert(8);
            bTree2.Insert(12);
            bTree2.Insert(11);
            bTree2.Insert(7);
            bTree2.Insert(9);

            var result = mergeBTreeHelper.Merge(bTree.GetRootNode(),bTree2.GetRootNode());
        }
    }
}
