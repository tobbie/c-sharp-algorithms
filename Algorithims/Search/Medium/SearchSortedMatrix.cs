using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Search.Medium
{
    public class SearchSortedMatrix
    {
        public static int[] Search(int[,] matrix, int target)
        {
            int rowLength = matrix.GetLength(0);
            int columnLength = matrix.GetLength(1);

            int row = 0;
            int column = columnLength - 1;

            while(row < rowLength && column >= 0)
            {
                if (matrix[row, column] > target)
                    column -= 1;
                else if (matrix[row, column] < target)
                    row += 1;
                else
                    return new int[] { row, column };
            }

            return new int[] { -1, -1 };
        }

        public static bool SearchJagged(int[][] matrix, int target)
        {

            int rowLength = matrix.Length;

            if (matrix.Length == 0)
                return false;
            int startRow = 0;
            int startColumn = matrix[startRow].Length -1;

            while(startRow < rowLength && startColumn >=0 )
            {
               

                if (matrix[startRow][startColumn] > target)
                    startColumn -= 1;
                else if (matrix[startRow][startColumn] < target)
                {
                    startRow += 1;                 
                }
                else
                    return true; 

            }

            return false;

        }
    }
}
