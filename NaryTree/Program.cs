using System;
using static NaryTreePostOrderTraversal.NaryTree;

namespace NaryTreePostOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            NaryTree naryTree = new NaryTree();
            Node root = new Node(1);
            Node parentsubchild = new Node(3);
            parentsubchild.addchildren(5);
            parentsubchild.addchildren(6);
            root.addchildren(parentsubchild);
            root.addchildren(2);
            root.addchildren(4);
            naryTree.root = root;


            var postorder = naryTree.postorder();


            var preorderresult = naryTree.preorder();

        }
    }
}
