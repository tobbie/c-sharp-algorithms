using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Sort.Medium
{
    public class ThreeNumberSort
    {
      public static int[] Sort(int[] array, int[] order)
       {
            var table = new Dictionary<int, int>();
           
            foreach (int number in array)
            {
                if (table.ContainsKey(number))
                    table[number] += 1;
                else
                    table.Add(number, 1);
            }

            int orderIndex = 0;
            int arrayIndex = 0;

            while(arrayIndex  < array.Length && orderIndex < order.Length)
            {
                if (!table.ContainsKey(order[orderIndex]) || table[order[orderIndex]] == 0)
                    orderIndex++;                         
                else
                {
                    array[arrayIndex] = order[orderIndex];
                    table[order[orderIndex]] -= 1;
                    arrayIndex++;
                }                                
            }

            return array;
       }
    }
}
