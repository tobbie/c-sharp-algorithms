using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class MeetingRooms2
    {
        public static int MinumumMeetingRooms(int[][] intervals)
        {
            var startTimes = new PriorityQueue<int, int>();
            var endTimes = new PriorityQueue<int, int>();

            int roomCount = 0, maxRooms = 0;
            

            foreach (var meeting in intervals)
            {
                startTimes.Enqueue(meeting[0], meeting[0]);
                endTimes.Enqueue(meeting[1], meeting[1]);
            }

            while(startTimes.Count > 0)
            {
                if(startTimes.Peek() < endTimes.Peek())
                {
                    roomCount += 1;               
                    startTimes.Dequeue();              
                }
                else
                {
                    roomCount -= 1;
                    endTimes.Dequeue();
                }
                maxRooms = Math.Max(maxRooms, roomCount);
            }

            return maxRooms;
        }
    }
}
