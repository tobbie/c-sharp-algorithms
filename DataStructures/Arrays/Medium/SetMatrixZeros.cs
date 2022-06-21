using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Medium
{
    public class SetMatrixZeros
    {
        //O(m *n) time, O(1) space.
        public static int[][] SetZeros(int[][] matrix)
        {
            /**
             * 1. First determine if there are zeros in the first row and first column, use booleans to hold this
             * 2. Start iterating from row 1, col 1, when you find a zero, set the first row at that column to 0, and the first column at that row to zero.
             * 3. Start iterating again from row 1, col 1, if(the value at the first row, at that column is zero OR the value at the first col at that row is zero , THEN set the value [i][j] to zero.
             * 4. use the boolens in step 1 to determine if you need to set all values in the first row and first col to zero.
             **/

            int rowLength = matrix.Length;
            int colLength = matrix[0].Length;

            bool firstRowIsZero = false, firstColumnIsZero = false;

            //Step 1
            for(int col = 0; col < colLength; col++)
            {
                if (matrix[0][col] == 0)
                {
                    firstRowIsZero = true;
                    break;
                }
                   
            }

            for (int row = 0; row < rowLength; row++)
            {
                if (matrix[row][0] == 0)
                {
                    firstColumnIsZero = true;
                    break;
                }
                   
            }

            //Step 2
            for (int row = 1; row < rowLength; row++)
            {
                for (int col = 1; col < colLength; col++)
                {
                    if (matrix[row][col] == 0)
                    {
                        matrix[0][col] = 0;
                        matrix[row][0] = 0;
                    }
                }
            }

            //Step 3
            for (int row = 1; row < rowLength; row++)
            {
                for (int col = 1; col < colLength; col++)
                {
                    if (matrix[0][col] == 0 || matrix[row][0] == 0)
                        matrix[row][col] = 0;
                }
            }

            //Step 4
            if(firstRowIsZero)
                for (int col = 0; col < colLength; col++)             
                    matrix[0][col] = 0;


            if (firstColumnIsZero)
                for (int row = 0; row < rowLength; row++)
                    matrix[row][0] = 0;


            return matrix;
        }
    }
}
