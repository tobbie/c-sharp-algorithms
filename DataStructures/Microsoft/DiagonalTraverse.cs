using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class DiagonalTraverse
    {
        public static List<int> Traverse(List<List<int>> array)
        {
            int height = array.Count - 1;
            int width = array[0].Count - 1;

            var result = new List<int>();
            bool goingDown = true;

            int row = 0, col = 0;

            while(!IsOutOfBounds(row, col, height, width))
            {
                result.Add(array[row][col]);
                if(goingDown)
                {
                    if(col == 0 || row == height)
                    {
                        goingDown = false;
                        if (row == height)
                            col += 1;
                        else if (col == 0)
                            row += 1;
                    }
                    else
                    {
                        row += 1;
                        col -= 1;
                    }
                }
                else
                {
                    if(row == 0 || col == width)
                    {
                        goingDown = true;
                        if (col == width)
                            row += 1;
                        else if (row == 0)
                            col += 1;                       
                    }
                    else
                    {
                        row -= 1;
                        col += 1;
                    }
                }

            }

            return result;
        }

        private static bool IsOutOfBounds(int row, int col, int height, int width)
        {
            return row < 0 || row > height || col < 0 || col > width;
        }
    }
}
