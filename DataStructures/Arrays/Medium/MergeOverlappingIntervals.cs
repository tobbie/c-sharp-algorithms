using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Medium
{
    public class MergeOverlappingIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            var sorted =  intervals.OrderBy(x => x[0]).ToArray();

            var result = new List<int[]>(){ sorted[0]};
            
            var previous = result[0];

            for (int i = 1; i < sorted.Length; i++)
            {
                var current = sorted[i];
                if (previous[1] >= current[0] && previous[1] > current[1])
                {
                    continue;                 
                }                 
                else if (previous[1] >= current[0])
                {
                    previous[1] = current[1];
                }
                {
                    previous = current;
                    result.Add(previous);
                }    
            }

            return result.ToArray();
            
        }
    }
}
