using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.BitwiseOperation
{
    public class FlipAndInvertImage
    {
        public static int[][] FlipInvert(int[][] arr)
        {
            foreach (var row in arr)     
                Array.Reverse(row);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    arr[i][j] = arr[i][j] ^ 1;
                }
            }

            return arr;
        }
    }
}
