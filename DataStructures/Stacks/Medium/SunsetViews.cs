using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.Medium
{
    public class SunsetViews
    {
        public static int[] Views(int[] buildings, string direction)
        {
            // EAST ------>
            // <--------- WEST

            var stack = new Stack<int>();
            int step = direction == "EAST" ? 1 : -1;
            int startIndex = direction == "EAST" ? 0 : buildings.Length - 1;

            int index = startIndex;
            while (index >= 0 && index < buildings.Length)
            {
                while (stack.Count > 0 && !(buildings[stack.Peek()] > buildings[index]))
                {
                    stack.Pop();
                }

                stack.Push(index);
                index += step;
            }

            var result = stack.ToList();
            if (direction == "EAST")
                 result.Reverse();
            
            return result.ToArray();
          
        }
    }
}
