using System;
using System.Collections.Generic;
using System.Text;

namespace PascalTriangle
{
    public class LeetCodeSolution
    {
        public IEnumerable<IEnumerable<int>> CalculatePascalTriangle(int rows) {

            var result = new List<List<int>>();
            if (rows == 0) {
                return result;
            }

            result.Add(new List<int>() {1});

            for (int i = 1; i < rows; i++) {
                var previous_row = result[i - 1];
                var new_row = new List<int>();
                new_row.Add(1);
                for (int j = 1; j < i; j++) {
                    new_row.Add(previous_row[j-1]+ previous_row[j]);
                }
                new_row.Add(1);
                result.Add(new_row);
            }

            return result;
        }

        public void PrintPascalTriangle(IEnumerable<IEnumerable<int>> data) {

            foreach (var row in data) {

                foreach (var item in row) {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();
            }
        
        }
    }
}
