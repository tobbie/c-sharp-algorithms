using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class MinimumMovesToEqualElementsOfArray
    {
        public static int MinimumMoves(int[] nums)
        {
            int maxNumber = int.MaxValue;
            int moves = 0;

            foreach (var num in nums)
                maxNumber = Math.Max(maxNumber, num);

            foreach  (var num in nums)
                moves += (maxNumber - num);

            return moves;
             
        }
    }
}
