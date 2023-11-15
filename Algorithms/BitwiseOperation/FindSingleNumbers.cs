using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BitwiseOperation
{
   public class FindSingleNumbers
    {
        public static int[] Find(int[] numbers)
        {
            int n1xn2 = 0;
            
            foreach  (int num in numbers)        
                n1xn2 = n1xn2 ^ num;

            int rightMostSetBit = 1;

            while ((rightMostSetBit & n1xn2) == 0)
                rightMostSetBit = rightMostSetBit << 1;

            int num1 = 0, num2 = 0;

            foreach (int num in numbers)
            {
                if ((num & rightMostSetBit) != 0)
                    num1 = num1 ^ num;
                else
                    num2 = num2 ^ num;
            }

           

            return new int[] { num1, num2 };
        }
    }
}
