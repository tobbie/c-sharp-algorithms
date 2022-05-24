using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

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

        public static int[] Sort2(int[] array, int [] order)
        {
            //first pass ----->

            int firstIndex = 0;
            int first = order[0];

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == first)
                {
                    Util.Swap(array, firstIndex, index);
                    firstIndex++;
                }
                    
            }

            //second pass 
           // <-------------------------------

            int lastIndex = array.Length - 1;
            int last = order[2];

            for (int jIndex = array.Length -1; jIndex >= 0; jIndex--)
            {
                if (array[jIndex] == last)
                {
                    Util.Swap(array, jIndex, lastIndex);
                    lastIndex--;
                }

            }

            return array;
        }

    }
}
