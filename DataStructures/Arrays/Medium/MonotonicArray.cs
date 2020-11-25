using System;
using static System.Console;

namespace DataStructures.Arrays.Medium
{
    public static class MonotonicArray
    {
        private const  string _nonDecreasing = "nd";
        private const string _nonIncreasing = "ni";

        public static void Run()
        {
            var testArray = new int[] { 1, 1, 1, 2, 3, 4, 1 };
            WriteLine($"Is input array monotonic? { IsMonotonic(testArray) }");
            ReadLine();

        }

        public static bool IsMonotonic(int [] array) {
            bool isMonotonic = true;

            if (array.Length == 0 || array.Length == 1)
                return isMonotonic;
            

            int currentPointer = 0;
            int nextPointer = currentPointer + 1;
            string arrayType = string.Empty;
            
           

            while (nextPointer < array.Length) {

                if (arrayType.Equals(string.Empty))
                {
                    if (array[nextPointer] > array[currentPointer])
                        arrayType = _nonDecreasing;
                    else if (array[nextPointer] < array[currentPointer])
                        arrayType = _nonIncreasing;
                }
                else if (arrayType.Equals(_nonIncreasing))
                {
                    if (array[nextPointer] > array[currentPointer])
                        return false;
                   
                }
                else if (arrayType.Equals(_nonDecreasing)) {
                    if (array[nextPointer] < array[currentPointer])
                        return false;
                 
                }

                currentPointer = nextPointer;
                nextPointer++;
                
            }

            return isMonotonic;
            
        }
    }
}
