using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Greedy.Medium
{
  public class ValidStartingCity
    {
        //O(n) time | O(1) space
        public static int GetValidStartingCity(int[] distances, int[] fuel, int mpg) {
            int milesLeft = 0, minumimGas =0, minimumCity = 0;

            for (int index = 1; index < distances.Length; index++)
            {
                milesLeft += (fuel[index - 1] * mpg) - distances[index - 1];
                if (milesLeft < minumimGas) {
                    minumimGas = milesLeft;
                    minimumCity = index;
                }
            }
            return minimumCity;
                   
        }
    }
}
