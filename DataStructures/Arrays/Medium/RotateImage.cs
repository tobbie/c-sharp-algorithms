using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Arrays.Medium
{
   public class RotateImage
    {
        public static int[][] Rotate(int[][]matrix )
        {
            int length = matrix.Length;

            for (int row = 0; row < length; row++)
            {
                for (int column = row; column < length; column++)
                {
                    int temp = matrix[row][column];
                    matrix[row][column] = matrix[column][row];
                    matrix[column][row] = temp;
                }
            }

            for (int row = 0; row < length; row++)
            {
                Util.Swap2(matrix[row], 0, length - 1);
            }

            return matrix;
        }
    }
}
