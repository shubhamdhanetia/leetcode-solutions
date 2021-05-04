using System;
using System.Collections.Generic;
using System.Text;

namespace NaryTreePostOrderTraversal
{
    public class NaryTree
    {
        public Node root { get; set; }

        public class Node
        {
            public int data;
            public List<Node> children { get; set; }
            public Node(int d)
            {
                data = d;
                children = new List<Node>();  
                
            }

            public void addchildren(Node node) {

                children.Add(node);
            }

            public void addchildren(int data)
            {
                Node node = new Node(data);
                children.Add(node);
            }

        }

        public IEnumerable<int> postorder() {

            LinkedList<Node> stack = new LinkedList<Node>();
            LinkedList<int> output = new LinkedList<int>();

            if (root == null) {
                return output;
            }
            stack.AddLast(root);
            while (stack.Count > 0) {
                Node node = stack.Last.Value;
                stack.RemoveLast();
                output.AddFirst(node.data);
                foreach (Node child in node.children) {
                    stack.AddLast(child);
                }
            }
            return output;
        }

        public IEnumerable<int> preorder() {

            Stack<Node> stack = new Stack<Node>();
            List<int> output = new List<int>();
            if (root == null)
            {
                return output;
            }
            stack.Push(root);
            while (stack.Count > 0) {
                Node node = stack.Pop();
                output.Add(node.data);
                for (int i = node.children.Count - 1; i >= 0; i--) {
                    stack.Push(node.children[i]);
                }

            }

            return output;
        }

    }
}
