using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTreePathSum
{
    public class BTreeHelper
    {
        public bool HasPathSumRecursive(Node root, int sum) {

            if (root == null)
            {
                return false;
            }
            else if (root.Left == null && root.Right == null && sum - root.Data == 0)
            {
                return true;
            }
            else {

                return HasPathSumRecursive(root.Left, sum - root.Data) || HasPathSumRecursive(root.Right,sum - root.Data);
            }

        }

        public bool HasPathSumIterative(Node root, int sum) {

            if (root == null) return false;

            Stack<Node> stackNode = new Stack<Node>();
            stackNode.Push(root);
            Stack<int> sumStack = new Stack<int>();
            sumStack.Push(sum-root.Data);

            while (stackNode.Count != 0) {

                Node current = stackNode.Pop();
                int current_sum = sumStack.Pop();

                if (current.Left == null && current.Right == null && current_sum == 0) {
                    return true;
                }

                if (current.Left != null) {
                    stackNode.Push(current.Left);
                    sumStack.Push(current_sum - current.Left.Data);
                }
                if (current.Right != null)
                {
                    stackNode.Push(current.Right);
                    sumStack.Push(current_sum - current.Right.Data);
                }
            }

            return false;
        }

        public void PrintRootToLeaf(Node root) {

            if (root == null) return;

            Stack<Node> nodeStack = new Stack<Node>();
            nodeStack.Push(root);

            Dictionary<Node, Node> parent = new Dictionary<Node, Node>();
            parent.Add(root,null);

            while (nodeStack.Count != 0) {

                Node current = nodeStack.Pop();
                if (current.Left == null & current.Right == null) {
                    printTopToBottomPath(current, parent);
                }

                if (current.Right != null) {
                    parent.Add(current.Right, current);
                    nodeStack.Push(current.Right);
                }

                if (current.Left != null) {
                    parent.Add(current.Left,current);
                    nodeStack.Push(current.Left);
                }
            }
        }

        public void printTopToBottomPath(Node current, Dictionary<Node, Node> parent) {

            Stack<Node> resultStack = new Stack<Node>();

            while (current != null) {

                resultStack.Push(current);
                current = parent[current];

            }

            while (resultStack.Count != 0) {
                current = resultStack.Pop();
                if (resultStack.Count != 0)
                {
                    Console.Write($"{current.Data} ->");
                }
                else {
                    Console.Write(current.Data);
                }
                
            }

            Console.WriteLine();
        
        }
    }
}
