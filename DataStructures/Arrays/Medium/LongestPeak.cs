using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace DataStructures.Arrays.Medium
{
    public static class LongestPeak
    {
        private const string StrictlyIncreasing = "inc";
        private const string StrictlyDecreasing = "dec";

        public static void Run()
        {
            var testArray = new int[] { 1, 3, 2 };

            Util.PrintValue(BestSolution(testArray));
        }

        public static int FindLongestPeak(int[] array)
        {
            if (array.Length < 3)
            {
                return 0;
            }

            int currentPointer = 0;
            int nextPointer = currentPointer + 1;
            var peaks = new List<Peak>();
            string trend = string.Empty;

            var peak = new Peak();

            while (nextPointer < array.Length)
            {
                var lastPeak = new Peak();
                if (trend.Equals(string.Empty))
                {
                    if (array[nextPointer] > array[currentPointer])
                    {
                        trend = StrictlyIncreasing;
                        peak.InsertValue(array[currentPointer]);
                        peak.InsertValue(array[nextPointer]);
                    }

                }
                else if (trend.Equals(StrictlyIncreasing))
                {

                    if (array[nextPointer] > array[currentPointer])
                        peak.InsertValue(array[nextPointer]);
                    else if (array[nextPointer] < array[currentPointer])
                    {
                        peak.InsertValue(array[nextPointer]);
                        trend = StrictlyDecreasing;
                        peak.SetPeak(); // found a peak.
                        peak.SetLength();
                        peaks.Add(peak);
                    }
                    else
                    {
                        peak = new Peak();
                        trend = string.Empty;
                    }



                }
                else if (trend.Equals(StrictlyDecreasing))
                {


                    if (array[nextPointer] < array[currentPointer])
                    {
                        peak.InsertValue(array[nextPointer]);
                        peak.SetLength();
                        lastPeak = peak;
                    }
                    else if (array[nextPointer] > array[currentPointer])
                    {
                        trend = StrictlyIncreasing;
                        peak.SetLength();
                        peaks.Add(peak);

                        peak = new Peak();
                        peak.InsertValue(array[currentPointer]);
                        peak.InsertValue(array[nextPointer]);
                    }
                    else
                    {
                        peak = new Peak();
                        trend = string.Empty;
                    }


                }
                if (lastPeak.IsPeak & nextPointer == array.Length - 1)
                {
                    peaks.Add(lastPeak);
                }
                currentPointer = nextPointer;
                nextPointer++;
            }

            int length = peaks.Any() ? peaks.Select(peak => peak.PeakLength)
                                         .Max() : 0;

            return length;


        }

        public static int BestSolution(int[] array)
        {
            if (array.Length < 3)
            {
                return 0;
            }

            int pointer = 1;
            int longestPeak = 0;

            while (pointer < array.Length - 1)
            {

                if (array[pointer] > array[pointer - 1] & array[pointer] > array[pointer + 1])
                {
                    //peak found
                    int leftIndex = pointer - 1;
                    int rightIndex = pointer + 1;

                    //find peak length
                    while (leftIndex > 0 && array[leftIndex - 1] < array[leftIndex])
                        leftIndex--;

                    while (rightIndex < array.Length - 1 && array[rightIndex + 1] < array[rightIndex])
                        rightIndex++;

                    int length = rightIndex - leftIndex + 1;
                    longestPeak = length > longestPeak ? length : longestPeak;
                    pointer = rightIndex;
                }
                pointer++;
            }

            return longestPeak;
        }

        
    }

    public class Peak
    {
        public List<int> Numbers { get; }
        public bool IsPeak { get; private set; }
        public int PeakLength { get; private set; }

        public Peak()
        {
            Numbers = new List<int>();
            IsPeak = false;
        }

        public void InsertValue(int number)
        {
            Numbers.Add(number);
        }

        public void SetPeak()
        {
            IsPeak = true;
        }

        public void SetLength()
        {
            PeakLength = Numbers.Count;
        }

    }
}
