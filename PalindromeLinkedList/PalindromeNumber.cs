using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeLinkedList
{
    public class PalindromeNumber
    {
        public bool isPalindromeNumber(int number)
        {

            if (number == 0) return true;

            if (number % 10 == 0 || number < 0) return false;

            int reverse_integer = 0;

            while (number > reverse_integer) {

                int pop = number % 10;
                number = number / 10;
                reverse_integer = (reverse_integer * 10) + pop;
            }

            if (number == reverse_integer || number == reverse_integer / 10) {
                return true;
            }

            return false;
        }
    }
}
