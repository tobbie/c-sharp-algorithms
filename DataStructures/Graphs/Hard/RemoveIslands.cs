using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs.Hard
{
    public class RemoveIslands
    {
        public static int[][] Remove(int[][] matrix)
        {
            var onesConnectedToBorder = new bool[matrix.Length][];
            for (int row = 0; row < matrix.Length; row++)
                onesConnectedToBorder[row] = new bool[matrix[row].Length];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    bool rowIsBorder = row == 0 || row == matrix.Length - 1;
                    bool colIsBorder = col == 0 || col == matrix[row].Length - 1;

                    bool isBorder = rowIsBorder || colIsBorder;

                    if (!isBorder)
                        continue;

                    if (matrix[row][col] != 1)
                        continue;

                    FindOnesConnectedToBorder(matrix, row, col, onesConnectedToBorder);
                }
            }

            for (int row = 1; row < matrix.Length - 1; row++)
            {
                for (int col = 1; col < matrix[row].Length - 1; col++)
                {


                    if (onesConnectedToBorder[row][col])
                        continue;

                    matrix[row][col] = 0;
                }
            }

            return new int[][] { };
        }

        private static void FindOnesConnectedToBorder(int[][] matrix, int startRow, int startCol, bool[][] onesConnectedToBorder)
        {
            var stack = new Stack<(int, int)>();
            stack.Push((startRow, startCol));

            while (stack.Count > 0)
            {
                var currentPosition = stack.Pop();
                var (currentRow, currentColumn) = currentPosition;

                var alreadyVisited = onesConnectedToBorder[currentRow][currentColumn];

                if (alreadyVisited)
                    continue;

                onesConnectedToBorder[currentRow][currentColumn] = true;

                var neighbours = GetNeigbhours(matrix, currentRow, currentColumn);
                foreach (var item in neighbours)
                {
                    var (row, column) = item;
                    if (matrix[row][column] != 1)
                        continue;

                    stack.Push((row, column));

                }

            }
        }

        private static List<(int, int)> GetNeigbhours(int[][] matrix, int currentRow, int currentColumn)
        {
            var neighbours = new List<(int, int)>();

            var numRows = matrix.Length;
            var numCols = matrix[currentRow].Length;

            if (currentRow - 1 >= 0) // looking up
                neighbours.Add((currentRow - 1, currentColumn));

            if (currentRow + 1 < numRows) // looking down
                neighbours.Add((currentRow + 1, currentColumn));

            if (currentColumn - 1 >= 0) // looking left
                neighbours.Add((currentRow, currentColumn - 1));

            if (currentColumn + 1 < numCols) // looking left
                neighbours.Add((currentRow, currentColumn + 1));

            return neighbours;
        }
    }
}
