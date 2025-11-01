using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Neetcode
{
    public class TopKFrequentElements
    {
        public static int[] TopKElements(int[] nums, int k)
        {
            var frequencyTable = new Dictionary<int, int>();
            var bucketArray = new List<int>[nums.Length + 1];
            var result = new List<int>();
            int counter = 0;

            //compute the frequency table
            for (int i = 0; i < nums.Length; i++)
            {
                if (!frequencyTable.ContainsKey(nums[i]))
                    frequencyTable.Add(nums[i], 1);
                else
                    frequencyTable[nums[i]]++;
            }
            
            //use frequecies from above as index of bucketArray to group keys (num items) by frequency
            foreach (var key in frequencyTable.Keys)
            {
                var frequency = frequencyTable[key];
                if (bucketArray[frequency] == null)
                    bucketArray[frequency] = new List<int>();

                bucketArray[frequency].Add(key);
            }

            for (int i = bucketArray.Length - 1; i >= 0 && counter < k; i--)
            {
                if (bucketArray[i] != null)
                {
                   foreach (int item in bucketArray[i])
                    {
                        counter++;
                        result.Add(item);
                        
                    }
                }
            }

            return result.ToArray();
        }
    }
}
