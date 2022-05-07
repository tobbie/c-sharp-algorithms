using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Algorithims.DynamicProgramming.Medium
{
    public class LevenshteinDistance
    {
       
        public static int MinimumEdits(string string1, string string2) {
           
            int[,] edits = new int[string1.Length + 1, string2.Length + 1];

            //initilize array
            for (int i = 0; i < string1.Length + 1; i++)
            {
                for (int j = 0; j < string2.Length + 1; j++)
                {
                    edits[i, j] = j;
                }

                edits[i, 0] = i;
            }

            for (int i = 1; i < string1.Length + 1; i++)
            {
                for (int  j = 1;  j < string2.Length + 1;  j++)
                {
                    if (string1[i - 1] == string2[j - 1])
                        edits[i, j] = edits[i - 1, j - 1];
                    else
                     edits[i,j] = 1 +  Math.Min(Math.Min(edits[i - 1, j], edits[i, j - 1]), edits[i - 1, j - 1]);
                }
            }

            return edits[string1.Length, string2.Length];
          }
    }
}
