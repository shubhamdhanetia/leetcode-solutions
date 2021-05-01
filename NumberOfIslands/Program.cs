using System;

namespace NumberOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCodeSolution solution = new LeetCodeSolution();
            char[,] grid = new char[4, 5] {
                {'1','1','1','1','0' },
                {'1','1','0','1','0' },
                {'1','1','0','0','1' },
                {'0','0','1','0','1' }
            };
            int numberOfIslands = solution.NumberOfIslands(grid);
        }
    }
}
