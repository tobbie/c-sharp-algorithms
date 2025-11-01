using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Neetcode
{
    public static class MissingNumber
    {
        public static int MissingNumberZeroIncluded(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = 0, inputSum = 0;
            

            for(int index =1; index <= n; index++)       
                expectedSum += index;

            for(int index = 0; index < nums.Length; index++)
                inputSum += nums[index];

            int missingNumber = expectedSum - inputSum;

            return missingNumber;
            
        }

        public static int MissingNumberZeroNotIncluded(int[] nums)
        {
            int n = nums.Length + 1;
            int expectedSum = 0;
            int inputSum = 0;

            for (int index = 1; index <= n; index++)
                expectedSum += index;

            for (int index = 0; index < nums.Length; index++)
                inputSum += nums[index];

            int missingNumber = expectedSum - inputSum;

            return missingNumber;

        }
    }
}
