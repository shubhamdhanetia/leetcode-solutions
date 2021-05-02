using System;

namespace DuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCodeSolution solution = new LeetCodeSolution();
            int[] array = new int[5] { 9, 2, 3, 10, 9 };
            bool result1 = solution.CheckIfDuplicateExistsUsingHashSet(array); //Priority Time Complexity
            bool result2 = solution.CheckIfDuplicateExistsUsingSorting(array); //Priority Space Complexity
        }
    }
}
