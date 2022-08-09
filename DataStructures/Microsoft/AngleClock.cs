using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
   public class AngleClock
    {
        public static double FindAngle(int hour, int minutes)
        {
            const int DegreePerHour = 30;  // 30 degrees is covered in 1hr : 360/12 (360 deg is covered in 12 hrs)
            const int DegrePerMinute = 6;  // 6 degrees is covered in 1min : 360 / 60 (360 deg is covered in 60min)

            var hourDegree = (hour % 12 + (float)minutes / 60) * DegreePerHour;
            var minuteDegree = minutes * DegrePerMinute;

            var angle = Math.Abs(hourDegree - minuteDegree);
            angle = angle > 180 ? 360 - angle : angle;

            return angle;
        }
    }
}
