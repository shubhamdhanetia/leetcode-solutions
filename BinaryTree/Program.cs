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


            BTree bTree2 = new BTree();
            bTree2.Insert(10);
            bTree2.Insert(8);
            bTree2.Insert(12);
            bTree2.Insert(11);
            bTree2.Insert(7);
            bTree2.Insert(9);

            MergeTwoBTree merge = new MergeTwoBTree();
            var mergeResult = merge.Merge(bTree.GetRootNode(),bTree2.GetRootNode());


        }
    }
} 
