using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class WildcardMatching
    {

        //s = "abcdef", p = "a?c*f";
        public static bool IsMatch(string s, string p)
        {
            var grid = new bool[s.Length + 1, p.Length + 1];
            int rowLength = grid.GetLength(0);
            int colLength = grid.GetLength(1);

            grid[0, 0] = true;

            //handle case ofr when pattern starts with *
            for(int col = 1; col < colLength; col++)
            {
                if (p[col - 1] == '*')
                    grid[0, col] = true;
                else
                    break;
            }

            for (int row   = 1; row < rowLength ; row++)
            {
                for (int col = 1; col < colLength; col++)
                {
                    if (s[row - 1] == p[col - 1] || p[col -1] == '?')
                    {
                        grid[row, col] = grid[row - 1, col - 1];
                    }
                    else if (p[col -1] == '*')
                    {
                        grid[row, col] = grid[row, col - 1] || grid[row - 1, col];
                    }
                   
                }
            }

            return grid[s.Length, p.Length];
        }
    }
}
