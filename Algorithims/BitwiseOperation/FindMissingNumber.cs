using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.BitwiseOperation
{
    public static class FindMissingNumber
    {
        public static int MissingNumber(int[] array)
        {
            int n = array.Length + 1;

            int x1 = 1;
          
            for (int i = 2; i <= n; i++)
                x1 = x1 ^ i;

            int x2 = array[0];


            for (int j = 1; j < array.Length; j++)       
                x2 = x2 ^ array[j];
            return x1 ^ x2;
        }
    }
}
