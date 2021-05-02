using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeLinkedList
{
    public class SingleLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) {
                data = d;
                next = null;
            }

        }

        public void InsertLast(int new_data)
        {

            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }

            Node last_node = GetLastNode();
            last_node.next = new_node;
        }

        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public bool IsPalindrome() {
            if (head == null) {
                return true;
            }

            Node fast = head;
            Node slow = head;

            while (fast.next != null && fast.next.next != null) {
                fast = fast.next.next;
                slow = slow.next;
            }

            Node secondHalfHead = reverse(slow.next);
            Node firstHalfHead = head;

            while (secondHalfHead != null && firstHalfHead != null) {
                if (firstHalfHead.data != secondHalfHead.data) {
                    return false;
                }
                secondHalfHead = secondHalfHead.next;
                firstHalfHead = firstHalfHead.next;
            }

            return true;
        }

        private Node reverse(Node head) {
            Node prev = null;
            while (head != null) {
                Node next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }

    }

}
