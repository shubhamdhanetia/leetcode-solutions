using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfIslands
{
    public class LeetCodeSolution
    {
        public int NumberOfIslands(char[,] grid) {

            int count = 0;

            int rowCount = grid.GetLength(0);
            int colCount = grid.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++) {

                    if (grid[i, j] == '1') {
                        count++;
                        callBFS(grid, i, j);
                    }
                     
                }
            }
            return count;
        }

        public void callBFS(char[,] grid, int i, int j) {
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i, j] == '0')
            {
                return;
            }
            grid[i, j] = '0';
            callBFS(grid, i+1, j);
            callBFS(grid, i-1, j);
            callBFS(grid, i, j+1);
            callBFS(grid, i, j-1);
        }
    }
}
