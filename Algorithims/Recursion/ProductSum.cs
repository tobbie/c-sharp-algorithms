using System;
using System.Collections.Generic;
using static System.Console;

namespace Algorithims.Recursion
{
    public static class ProductSum
    {
        public static void Run() {

            var array = new List<object>
            {5, 2,
             new List<object>{7, -1 },
             3,
             new List<object>{6, new List<object> { -13,8}, 4 }
            };

            WriteLine($"Product Sum is :{Solution1(array)}");

        }

        private static int Solution1(List<object> array, int depth = 1) {
            int productSum = 0;
            for (int index = 0; index < array.Count; index++)
            {
                
                var type = array[index].GetType();
                if (type.IsPrimitive)
                    productSum = productSum + (int)array[index];
                else
                    productSum  = productSum + (depth + 1) * Solution1((List<object>)array[index], depth + 1);
                
            }
            return productSum;
        }
    }
}
