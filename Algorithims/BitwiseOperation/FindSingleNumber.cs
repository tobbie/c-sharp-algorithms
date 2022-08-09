using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.BitwiseOperation
{
    public class FindSingleNumber
    {
        public static int Find(int[] array)
        {
            int bitwiseSum = array[0];

            for (int i = 1; i < array.Length; i++)
                bitwiseSum = bitwiseSum ^ array[i];

            return bitwiseSum;
           
         }

    }
}
