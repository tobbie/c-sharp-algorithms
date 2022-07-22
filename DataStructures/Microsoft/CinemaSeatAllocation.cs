using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class CinemaSeatAllocation
    {
        public static int MaxNumberOfFamilies(int n, int[][] reservedSeats)
        {
            var seatMapping = new Dictionary<int, HashSet<int>>();
            var maxFamilies = n * 2;

            for (int i = 0; i < reservedSeats.Length; i++)
            {
                int row = reservedSeats[i][0];
                int seat = reservedSeats[i][1];

                if (!seatMapping.ContainsKey(row))
                    seatMapping.Add(row, new HashSet<int>());

                seatMapping[row].Add(seat);
            }

            foreach (var keyPair in seatMapping)
            {
                int decremented = 0;
                if (keyPair.Value.Contains(2) || keyPair.Value.Contains(3) || keyPair.Value.Contains(4) || keyPair.Value.Contains(5))
                {
                    decremented += 1;
                    maxFamilies -= 1;
                }

                if (keyPair.Value.Contains(6) || keyPair.Value.Contains(7) || keyPair.Value.Contains(8) || keyPair.Value.Contains(9))
                {
                    decremented += 1;
                    maxFamilies -= 1;
                }

                if (!keyPair.Value.Contains(4) && !keyPair.Value.Contains(5) && !keyPair.Value.Contains(6) && !keyPair.Value.Contains(7))
                {
                    if (decremented == 2)
                        maxFamilies += 1;

                }

            }

            return maxFamilies;
            
            
        }
    }
}
