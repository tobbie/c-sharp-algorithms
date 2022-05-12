
using System.Collections.Generic;

namespace DataStructures.Stacks.Medium
{
 public class NextGreaterThan
    {
        public static int[] FindNexGreaterThan(int[] inputArray) {

            var stack = new Stack<int>();
            var result = new int[inputArray.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = -1;

            for (int index = 0; index < (2 * inputArray.Length); index++)
            {
                int arrayIndex = index % inputArray.Length;

                while(stack.Count > 0 && inputArray[stack.Peek()] < inputArray[arrayIndex]) 
                {
                    int previousIndex = stack.Pop();
                    result[previousIndex] = inputArray[arrayIndex];
                }

                stack.Push(arrayIndex);
            }
            return result;
        }


    }
}
