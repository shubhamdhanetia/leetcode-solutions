using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            SingleLinkedListHelper linkedListHelper = new SingleLinkedListHelper();
            linkedListHelper.InsertLast(linkedList,10);
            linkedListHelper.InsertLast(linkedList, 20);
            linkedListHelper.InsertLast(linkedList, 30);
            linkedListHelper.PrintLinkedList(linkedList);
            linkedListHelper.ReverseLinkedList(linkedList);
            linkedListHelper.PrintLinkedList(linkedList);
        }
    }
}
