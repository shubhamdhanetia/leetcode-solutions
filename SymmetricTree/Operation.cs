using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymmetricTree
{
    public class Operation
    {
        public bool IsSymmetric(Node root)
        {
            if (root == null) return true;

            return IsSymmetric(root.Left, root.Right);
        }

        public bool IsSymmetric(Node left, Node right)
        {

            if (left == null || right == null)
            {
                return left == right;
            }

            if (left.Data != right.Data) {
                return false;
            }
            return IsSymmetric(left.Left, right.Right) && IsSymmetric(left.Right, right.Left);
        }
    }
}
