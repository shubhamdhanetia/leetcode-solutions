using System;
using System.Collections.Generic;
using System.Text;

namespace DuplicateNumber
{
    public class LeetCodeSolution
    {
        public bool CheckIfDuplicateExistsUsingHashSet(int[] num) {

            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < num.Length; i++) {
                if (numbers.Contains(num[i]))
                {
                    return true;
                }
                numbers.Add(num[i]);
            }

            return false;
        }

        public bool CheckIfDuplicateExistsUsingSorting(int[] num) {
            Array.Sort(num);
            for (int i = 0; i < num.Length - 1; i++) {
                if (num[i] == num[i + 1]) {
                    return true;
                }
            }
            return false;
        }
    }
}
