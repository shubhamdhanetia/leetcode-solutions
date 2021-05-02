using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCodeSolution solution = new LeetCodeSolution();
            int[] array = new int[6] { 1, 2, 3, 4, 23, 25};
            var indices = solution.twoSumSorted(array, 26);
            Console.WriteLine(indices);
        }
    }
}
