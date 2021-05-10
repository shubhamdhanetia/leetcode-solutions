using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerProblems
{
    public class IntegerOperation
    {
        public int reverse(int x) {

            int reverse = 0;
            int pop = 0;

            while (x != 0) {
                if (reverse < Int32.MinValue / 10 || reverse > Int32.MaxValue / 10)
                    return 0;
                pop = x % 10;
                x = x / 10;
                reverse = (reverse * 10) + pop;
            }

            return reverse;
        
        }
    }
}
