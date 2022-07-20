using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class WordSearch
    {
        public static bool Exists(char[][] board, string word)
        {
            if (board == null || word == null)
                return false;

            int m = board.Length;
            int n = board[0].Length;
            if (word.Length > (m * n))
                return false;


            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0] && DepthFirstSearch(board, i, j, word))
                        return true;                 
                }
            }
            return false;
        }

        private static bool DepthFirstSearch(char[][] board, int startRow, int startColumn, string word)
        {
            var stack = new Stack<(int, int, int , bool)>(); // tuple stores : row, col, currentIndex, backTracking boolean.
            var visited = new HashSet<string>();
          
            stack.Push((startRow, startColumn, 0, false));
           
            while (stack.Count > 0)
            {         
                var (row, col, currentIndex, backTrack) = stack.Pop();

                if (currentIndex == word.Length - 1)
                    return true;

                if(backTrack)
                {
                    visited.Remove($"{row},{col}");
                    continue;
                }

                visited.Add($"{row},{col}");
                stack.Push((row, col, currentIndex, true)); // add backtracking node when it's been visited.

              
                var neigbhors = GetNeighbors(row, col, board);
               
                foreach (var neigbhor in neigbhors)
                {
                    var (nRow, nCol) = neigbhor;
                   
                    if (visited.Contains($"{nRow},{nCol}"))
                        continue;

                    if (board[nRow][nCol] == word[currentIndex + 1])   
                        stack.Push((nRow, nCol, currentIndex + 1, false));                                       
                }
                
            }
            return false;
        }

        private static List<(int,int)> GetNeighbors(int row, int col, char[][] board)
        {
            var neigbhors = new List<(int, int)>();
            int rowLength = board.Length;
            int colLength = board[row].Length;

            if (row -1 >= 0)  //go up
                neigbhors.Add((row - 1, col));

            if (row + 1 < rowLength) // go down
                neigbhors.Add((row + 1, col));

            if (col -1 >= 0) // go left
                neigbhors.Add((row, col - 1));

            if (col + 1 < colLength) //go right
                neigbhors.Add((row, col + 1));

            return neigbhors;
        }
    }
}
