using System.Collections.Generic;

namespace DataStructures.Arrays.Neetcode
{
    public static class TwoSum
    {
        public static int[] TwoSumIndices(int[] nums, int target)
        {
            var result = new int[2];
            var dict = new Dictionary<int, int>();

            for (int index = 0; index < nums.Length; index++)
            {
                int difference = target - nums[index];
                if (!dict.ContainsKey(difference))
                    dict.TryAdd(nums[index], index);
                else
                {
                    result[0] = dict[difference];
                    result[1] = index;
                    return result;
                }
            }

            return result;
        }


        public static bool TwoSumBoolean(int[] nums, int target)
        {
            var hashTable = new HashSet<int>();
            for (int index = 0; index < nums.Length; index++)
            {
                int difference = target - nums[index];
                if (!hashTable.Contains(difference))
                    hashTable.Add(nums[index]);
                else
                    return true;
            }

            return false;
        }

        public static int[] TwoSum_2(int[] nums, int target)
        {
            /**
             * 1. define a dictionary of key int and value int
             * 2. iterate over the nums array
             * 3. for every value, subtract from target
             * 4. if result is in dictionary we found the two numbers that sum to target
             * 5. compare the indices of the two numbers
             * 6. assign the lesser to result[0], the greater to result[1]
             * 7. return result.
             * 8. if result is not in dictionary, add number at currnet index to dict key and the current index as it's value
             * 9. continue interation till end of array.
             
             */

            var map = new Dictionary<int, int>();
            var result  = new int[2];
            for (int index = 0; index < nums.Length; index++)
            {
                var difference = target - nums[index];
                if(!map.ContainsKey(difference))
                    map.Add(nums[index], index);
                else
                {
                    result[0] = map[difference];
                    result[1] = index;        
                }
            }

            if (result[0] > result[1])
            {
                var temp = result[1];
                result[1] = result[0];
                result[0] = temp;
            }

            return result;
        }
    }
}
