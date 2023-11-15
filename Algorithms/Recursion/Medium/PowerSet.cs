using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Algorithms.Recursion.Medium
{
    public static class PowerSet
    {
        private static int SetLength;

        public static void Run()
        {
            var array = new List<int>{ };
            var result = GetPowerSet(array);
            Util.Print2DArray(result);
        }

        //Iterative solution
        private static List<List<int>> GetPowerSet(int [] array)
        {
            var subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            foreach (var item in array)
            {
                int currentSubsetLength = subsets.Count;
                for (int index = 0; index < currentSubsetLength; index++)
                {
                    var list = new List<int>(subsets[index]);
                    list.Add(item);
                    subsets.Add(list);
                }

            }
            return subsets;
        }

        //recursive solution
        private static List<List<int>> GetPowerSet(List<int> array, int? index = null) {         

            var subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            if (array.Count == 0)  // handle edge case for when input array is empty.
                return subsets;

            if (index == null)
                index = array.Count - 1;
            else if (index < 0)                     
                return subsets;
            
                
            int element = array[(int)index];
            subsets = GetPowerSet(array, index - 1);
            int currentSubsetLength = subsets.Count;

            for (int i = 0; i < currentSubsetLength; i++)
            {
                var list = new List<int>(subsets[i]);
                list.Add(element);
                subsets.Add(list);
            }
            return subsets;
        }



        /**
        private static List<List<int>> GetPowerSet(List<int> array)
        {
            SetLength = array.Count - 1;
            var powerSet = new List<List<int>>();
            GetPowerSet(array, new List<int>(), powerSet, 0);
            return powerSet;

        }

        private static void GetPowerSet(List<int> inputArray, List<int> currentSet, List<List<int>> powerSet,
                                                    int currentIndex)
        {
            if (!inputArray.Any() | inputArray.Count == 1)
                powerSet.Add(inputArray);
           
            else
                for (int index = currentIndex; index < inputArray.Count; index++)
                {
                    if (index == SetLength) {
                        powerSet.Add(inputArray);
                        GetPowerSet(new List<int>(), currentSet, powerSet, currentIndex);
                    }

                    var newSet = new List<int>(currentSet);
                    newSet.Add(inputArray[index]);

                    var newArray = new List<int>(inputArray);
                    newArray.Remove(inputArray[index]);

                    if (newSet.Count < SetLength)
                        powerSet.Add(new List<int>(newSet));                  
                    else if (newSet.Count == SetLength)
                    {
                        powerSet.Add(new List<int>(newSet));
                        newSet.Remove(inputArray[index]);
                    }

                   GetPowerSet(newArray, newSet, powerSet, index);
                }

        }
        **/
        
    }
}
