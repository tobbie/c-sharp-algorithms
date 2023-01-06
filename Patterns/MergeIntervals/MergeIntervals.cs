using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.MergeIntervals
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            var result = new List<int[]>();
            result.Add(intervals[0]);

            for(int index = 1; index < intervals.Length; index++)
            {
                var lastInterval = result[^1];
                if (intervals[index][0] <= lastInterval[1])
                {
                    //we have an overlap
                    // merge intervals based on the greater of the values in the end indexes for an interval
                    result[^1][1] = lastInterval[1] >= intervals[index][1] ? lastInterval[1] : intervals[index][1];
                }
                else
                {
                    result.Add(intervals[index]);
                }
            }

            return result.ToArray();
        }
    }
}
