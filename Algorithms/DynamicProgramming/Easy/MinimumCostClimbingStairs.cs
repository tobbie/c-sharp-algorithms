using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming.Easy
{
   public class MinimumCostClimbingStairs
    {
        public static int MinCost(int[] cost)
        {
            var costList = cost.ToList();
            costList.Add(0);
            int length = costList.Count;

            for (int i = length -3 ; i>=0;  i--)
            {
                //find the minimum value of the cost of taking 1step or steps from the current postion in array to the list end
                costList[i] = Math.Min(costList[i] + costList[i + 1], costList[i] + costList[i + 2]);
                //costList[i] += Math.Min(costList[i + 1], costList[i + 2]);
            }

            return Math.Min(costList[0], costList[1]);
        }
    }
}
