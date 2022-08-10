using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class MeetingRooms1 
    {
        public static bool CanAttend(int[][] intervals)
        {
            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];

            for(int i = 0; i < intervals.Length; i++)
            {
                startTimes[i] = intervals[i][0];
                endTimes[i] = intervals[i][1];
            }

            Array.Sort(startTimes);
            Array.Sort(endTimes);

            int startIndex = 1;
            int endIndex = 0;

            while(startIndex < intervals.Length)
            {
                if (startTimes[startIndex] < endTimes[endIndex])
                    return false;

                startIndex++;
                endIndex++;
                
            }

            return true;
        }
    }
}
