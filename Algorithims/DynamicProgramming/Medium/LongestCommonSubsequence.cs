using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.DynamicProgramming.Medium
{
    public class LongestCommonSubsequence
    {
        public static string LCM(string string1, string string2) {

            string[,] lcsArray = new string[string1.Length + 1, string2.Length + 1];
          
            for (int i = 0; i < string1.Length + 1 ; i++)
            {
                for (int j = 0; j < string2.Length + 1; j++)
                {
                    lcsArray[i, j] = string.Empty;
                }
            }


            for (int i = 1; i < string1.Length + 1; i++)
            {
                for (int j = 1; j < string2.Length + 1; j++)
                {
                    if (string1[i - 1] == string2[j - 1])
                    {
                        lcsArray[i, j] = string.Join("", lcsArray[i - 1, j - 1], string1[i - 1]);
                    }
                    else {
                        lcsArray[i, j] = lcsArray[i - 1, j].Length > lcsArray[i, j - 1].Length ? lcsArray[i - 1, j] : lcsArray[i, j - 1];
                    }
                }
            }

            var res = lcsArray[string1.Length, string2.Length];
            var listChar = new List<char>(res.ToCharArray());
            return lcsArray[string1.Length, string2.Length];

        }
    }
}
