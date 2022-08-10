using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            var memo = new Dictionary<string, bool>();
            return MatchHelper(s, p, 0, 0, memo);
        }

        private static bool MatchHelper(string s, string p, int i, int j, Dictionary<string, bool> memo)
        {
            string position = $"{i},{j}";
            if (memo.ContainsKey(position))
                return memo[position];

            if (i >= s.Length && j >= p.Length)
                return true;

            if (j >= p.Length)
                return false;

            bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if( j+1 < p.Length && p[j+1] == '*' )
            { 
                bool result = MatchHelper(s, p, i, j + 2, memo) || (match && MatchHelper(s, p, i + 1, j, memo));
                memo.Add(position, result);
                return memo[position];
            }

            if (match)
            {
                memo.Add(position, MatchHelper(s, p, i + 1, j + 1, memo));
                return memo[position];
            }


            memo.Add(position, false);
            return memo[position];
        }
    }
}
