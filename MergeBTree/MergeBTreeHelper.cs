using Common;

namespace MergeBTree
{
    public class MergeBTreeHelper
    {
        public Node Merge(Node t1, Node t2)
        {

            if (t1 == null) return t2;

            if (t2 == null) return t1;

            t1.Data = t1.Data + t2.Data;

            t1.Left = Merge(t1.Left, t2.Left);

            t1.Right = Merge(t1.Right, t2.Right);

            return t1;

        }
    }
}
