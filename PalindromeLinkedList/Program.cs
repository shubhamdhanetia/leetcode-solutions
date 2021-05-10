using System;

namespace PalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(3);
            linkedList.InsertLast(2);
            linkedList.InsertLast(1);
            var result = linkedList.IsPalindrome(); // Time Complexity : O(N)   Space Complexity : O(1)

            PalindromeNumber checkPalindrome = new PalindromeNumber();
            bool result1 = checkPalindrome.isPalindromeNumber(123321);
        }
    }
}
