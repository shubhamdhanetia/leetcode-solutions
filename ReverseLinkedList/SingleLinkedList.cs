using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    public class SingleLinkedList
    {
        public Node head { get; set; }

    }
    public class Node
    {
        public int data;

        public Node next;
        public Node(int d) {
            data = d;
            next = null;
        }

    }

    public class SingleLinkedListHelper {

        public void InsertLast(SingleLinkedList singleLinkedList, int new_data) {

            Node new_node = new Node(new_data);
            if (singleLinkedList.head == null) {
                singleLinkedList.head = new_node;
                return;
            }

            Node last_node = GetLastNode(singleLinkedList);
            last_node.next = new_node;
        }

        private Node GetLastNode(SingleLinkedList singleLinkedList) {
            Node temp = singleLinkedList.head;
            while (temp.next != null) {
                temp = temp.next;
            }
            return temp;
        }

        public void ReverseLinkedList(SingleLinkedList singleLinkedList) {

            Node prev = null;
            while (singleLinkedList.head != null) {

                Node next = singleLinkedList.head.next;
                singleLinkedList.head.next = prev;
                prev = singleLinkedList.head;
                singleLinkedList.head = next;

            }

            singleLinkedList.head = prev;

        }

        public void PrintLinkedList(SingleLinkedList singleLinkedList) {

            Node temp = singleLinkedList.head;
            while (temp != null) {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
