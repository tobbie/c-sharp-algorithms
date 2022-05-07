using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Greedy.Easy
{
    public class TandemBicycle
    {
        public static int TandemTotal(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest) { 
            int total = 0;
            Array.Sort(redShirtSpeeds);

            if (fastest)
                Array.Sort(blueShirtSpeeds);
            else
                Array.Sort(blueShirtSpeeds, (x, y) => y.CompareTo(x));

            int jIndex = blueShirtSpeeds.Length - 1;

            for (int index = 0; index < redShirtSpeeds.Length; index++) {
                total += Math.Max(redShirtSpeeds[index], blueShirtSpeeds[jIndex]);
                jIndex--;
            }
            return total;
        }
    }
}
