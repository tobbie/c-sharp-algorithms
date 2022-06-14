using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    public class NumberOfIslands
    {
       
        public static int FindIslands(int[][] matrix)
        {
            var hashTable = new HashSet<int>();
            if (!hashTable.Contains(3))
                hashTable.Add(4);
            
          
            int numberOfIslands = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (matrix[row][column] == 0)
                        continue;
                    else
                        IdentifyIslands(matrix, row, column);
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (matrix[row][column] == 2)
                        numberOfIslands += 1;                  
                }
            }

            return numberOfIslands;
        }

        private static void IdentifyIslands(int[][] matrix, int startRow, int startColumn)
        {
            var stack = new Stack<(int, int)>();
            stack.Push((startRow, startColumn));
           

            while(stack.Count > 0)
            {
                var currentPosition = stack.Pop();
                var (currentRow, currentColumn) = currentPosition;
                bool alreadyVisited = matrix[currentRow][currentColumn] == 2 || matrix[currentRow][currentColumn] == 0;

                if (alreadyVisited)
                    continue;
               
                
                if(currentRow == startRow && currentColumn == startColumn) // this is a root node where DFS starts;
                    matrix[currentRow][currentColumn] = 2;
                else
                    matrix[currentRow][currentColumn] = 0;

                var neigbhours = GetNeighbours(matrix, currentRow, currentColumn);

                foreach (var item in neigbhours)
                {
                    stack.Push(item);
                }
            }
        }

        private static List<(int, int)> GetNeighbours(int[][] matrix, int row, int column)
        {
            var neigbhours = new List<(int, int)>();
            int rowLength = matrix.Length;
            int columnLength = matrix[row].Length;

            //look up
            if (row - 1 >= 0 && matrix[row - 1][column] == 1)
                neigbhours.Add((row - 1, column));

            //look down
            if (row + 1 < rowLength && matrix[row + 1][column] == 1)
                neigbhours.Add((row + 1, column));

            //look left
            if(column -1 >= 0 && matrix[row][column -1] == 1)
                neigbhours.Add((row, column -1));

            //look right
            if (column + 1 < columnLength && matrix[row][column + 1] == 1)
                neigbhours.Add((row, column + 1));
            return neigbhours;
        }
    }
}
