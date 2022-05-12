using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.Medium
{
    public class SortStack
    {
        public static List<int> Sort(List<int> stack) 
        {
            if (stack.Count == 0)
                return stack;

            int top = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            Sort(stack);

            InsertInOrderedStack(stack, top);

            return stack;


        }

        private static void InsertInOrderedStack(List<int> stack, int value)
        {
            if (stack.Count == 0 || stack[stack.Count - 1] <= value)
            {
                stack.Add(value);
                return;
            }
               
            int top = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            InsertInOrderedStack(stack, value);

            stack.Add(top);
        }
    }
}
