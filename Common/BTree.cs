using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class BTree
    {
        private Node _root;

        public BTree() {
            _root = null;
        }

        public void Insert(int data) {

            if (_root == null) {
                _root = new Node(data);
                 return;
            }

            InsertRec(_root,new Node(data));
        }

        public Node GetRootNode() {
            return _root;
        }

        private void InsertRec(Node root, Node newNode) {

            if (root == null) {
                root = newNode;
            }

            if (newNode.Data < root.Data)
            {

                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertRec(root.Left, newNode);
                }
            }
            else {
                if (root.Right == null) {
                    root.Right = newNode;
                }
                else{
                    InsertRec(root.Right, newNode);
                }
            }

        }

        private void DisplayTree(Node root) {

            if (root == null) return;

            DisplayTree(root.Left);
            Console.Write(root.Data + " ");
            DisplayTree(root.Right);

        }

        public void DisplayTree() {

            DisplayTree(_root);
        }

        public IEnumerable<int> InOrderTraversal() {

            Stack<Node> stack = new Stack<Node>();
            List<int> output = new List<int>();
            if (_root == null) {
                return output;
            }

            Node currentNode = _root;

            while (currentNode != null || stack.Count != 0) {

                while (currentNode != null) {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }

                currentNode = stack.Pop();
                output.Add(currentNode.Data);
                currentNode = currentNode.Right;
            }

            return output;
        }

    }

    public class Node { 
    
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node() {         
        }
        public Node(int data) {
            this.Data = data;
        }

    
    }
}
