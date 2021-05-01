using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCodeSolution solution = new LeetCodeSolution();
            var result = solution.CalculatePascalTriangle(10);
            solution.PrintPascalTriangle(result);
        }
    }
}
