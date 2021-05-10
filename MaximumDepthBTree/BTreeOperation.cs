using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumDepthBTree
{
    public class BTreeOperation
    {
        public int GetMaximumDepth(Node root) {

            if (root == null) {
                return 0;
            }

            int left = GetMaximumDepth(root.Left);
            int right = GetMaximumDepth(root.Right);

            return Math.Max(left, right) + 1;

        }
    }
}
