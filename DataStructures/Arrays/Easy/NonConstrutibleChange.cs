using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Easy
{
   public class NonConstrutibleChange
    {
        public static int FindMinimumChange(int[] array)
        {
            Array.Sort(array);
            int currentChange = 0;

            foreach (var item in array)
            {
                if (item > currentChange + 1)
                    return currentChange + 1;

                currentChange += item;
            }

            return currentChange + 1;

        }
    }
}
