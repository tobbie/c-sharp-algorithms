using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class MaximizeDistanceToClosestPerson
    {
        public static int MaximizeDistance(int[] seats)
        {
            /**
             * case 1 : guest seats between two people
             * case 2 : guest seats at far left
             * case 3 guest sears at far right.
             **/

            //case1
            int result = 0;
            int curentPos = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 1)
                    curentPos = 0;
                else
                {
                    curentPos += 1;
                    result = Math.Max(result, (curentPos + 1) / 2);
                }
            }

            //case 2;

            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 1)
                {
                    result = Math.Max(result, i);
                    break;
                }
                   
            }


            //case 3;
            int endIndex = seats.Length - 1;

            for (int i = endIndex; i >= 0; i--)
            {
                if (seats[i] == 1)
                {
                    result = Math.Max(result, endIndex - i);
                    break;
                }
                    
            }

            return result;
        }
    }
}
