using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    public class LeetCodeSolution
    {
        public int[] twoSumSorted(int[] numbers, int target) {

            int a_pointer = 0;
            int b_pointer = numbers.Length - 1;

            while (a_pointer <= b_pointer) {

                int sum = numbers[a_pointer] + numbers[b_pointer];

                if (sum > target)
                {
                    b_pointer--;
                }
                else if (sum < target)
                {
                    a_pointer++;
                }
                else {
                    return new int[] {a_pointer+1 , b_pointer+1 };
                }

            }

            return new int[] { a_pointer + 1, b_pointer + 1 };
        }
    }
}
