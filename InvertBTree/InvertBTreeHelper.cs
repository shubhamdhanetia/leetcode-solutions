using Common;

namespace InvertBTree
{
    public class InvertBTreeHelper
    {
        public Node InvertBinaryTree(Node root)
        {
            if (root == null) return root;

            Node left = InvertBinaryTree(root.Left);
            Node right = InvertBinaryTree(root.Right);

            root.Left = right;
            root.Right = left;

            return root;
        }
    }
}
