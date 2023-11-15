using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search.Easy
{
    public class FindThreeLargestNumbers
    {
        public static int? [] Find(int [] array)
        {
            var threeLargest = new int?[3];
            foreach (var number in array)
            {
                UpdateLargest(threeLargest, number);
            }
            return threeLargest;
            
        }

        private static void UpdateLargest(int?[] threeLargest, int number)
        {
            if (threeLargest[2] == null || number > threeLargest[2])
                ShiftAndUpdate(threeLargest, number, 2);
            else if(threeLargest[1] == null || number > threeLargest[1])
                ShiftAndUpdate(threeLargest, number, 1);
            else if(threeLargest[0] == null || number > threeLargest[0])
                ShiftAndUpdate(threeLargest, number, 0);
        }

        private static void ShiftAndUpdate(int?[] threeLargest, int number, int index)
        {
            for (int i = 0; i < index +1; i++)
            {
                if (i == index)
                    threeLargest[i] = number;
                else
                    threeLargest[i] = threeLargest[i + 1];
            }
        }
    }
}
