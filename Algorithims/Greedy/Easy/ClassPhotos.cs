using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithims.Greedy.Easy
{
    public class ClassPhotos
    {
        public static bool CanTakePhotos(List<int> redShirtHeights, List<int> blueShirtHeights)
        {         
           redShirtHeights.Sort((x, y) => y.CompareTo(x));
           blueShirtHeights.Sort((x, y) => y.CompareTo(x));
           
            var backRow = new List<int>();
            var frontRow = new List<int>();

            if (redShirtHeights[0] > blueShirtHeights[0])
            {
                backRow = redShirtHeights;
                frontRow = blueShirtHeights;
            }
            else 
            {
                backRow = blueShirtHeights;
                frontRow = redShirtHeights;
            }

            for (int index = 0; index < backRow.Count; index++)
            {
                if (backRow[index] > frontRow[index])
                    continue;
                else
                    return false;
            }
            return true;          
        }
    }

   
}
