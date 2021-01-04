using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays.LeetCode
{
    public class ThreeNumberSum
    {
        public ThreeNumberSum()
        {
        }

        public static void Run() {
            var array = new int[] { -1, 0, 1, 2, -1, -4 };
            OptimalSolution(array);
            //    Util.Print2DArray(OptimalSolution(array));
           
        }

        private static IList<IList<int>> OptimalSolution(int[] nums)
        {
            if (nums.Length < 3)
                return new List<IList<int>>() ;

            var resultList = new List<IList<int>>();

            int index = 0, targetSum = 0;
           
            Array.Sort(nums);
            var hashTable = new HashSet<string>();
            
            while(index < nums.Length - 2)
            {
                int leftPointer = index + 1, rightPointer = nums.Length - 1;

                while (leftPointer < rightPointer)
                {
                    int currentSum = nums[index] + nums[leftPointer] + nums[rightPointer];
                    if (currentSum > targetSum)
                        rightPointer--;
                    else if (currentSum < targetSum)
                        leftPointer++;
                    else
                    {
                        var triplet = new List<int>();
                        var tripletString = ConvertTripletToString(nums[index], nums[leftPointer], nums[rightPointer]);
                        if (!hashTable.Contains(tripletString))
                           {
                             triplet.Add(nums[index]);
                             triplet.Add(nums[leftPointer]);
                             triplet.Add(nums[rightPointer]);
                             hashTable.Add(tripletString);
                             resultList.Add(triplet.ToArray());
                           }
                                                                 
                        leftPointer++;
                        rightPointer--;
                    }

                }

                index++;

            }

            return resultList;

        }


        private static string ConvertTripletToString(int a, int b, int c) {

            return $"{a}{b}{c}";
        }

    }


}
