using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.Medium
{
    public class BalancedBrackets
    {
        //using stack,  string and hashtable or dictionary
        public static bool IsValid(string input)
        {
            //((){}()[({})])

            //1. iterate thru string, 
            //2. use stack to store any opening brackets <({[>
            //3.  when you encounter closing bracket:
            //     1. if stack is empty, return false.
            //     2. check if bracket at top of stack is the matching closing bracket, if so pop item at top of stack, if not return false.
            // 4.repeat process
            //5.  at the end of iteration, check if the stack if empty, if empty, return true else false.

            string openingBrackets = "({[";
            string closingBrackets = ")}]";

            var matchingBrackets = new Dictionary<char, char>();
            matchingBrackets.Add(')', '(');
            matchingBrackets.Add(']', '[');
            matchingBrackets.Add('}', '{');

            var stack = new Stack<char>();

            foreach (char item in input)
            {
                if (openingBrackets.Contains(item))
                    stack.Push(item);
                else if(closingBrackets.Contains(item))
                {
                    if (stack.Count == 0)
                        return false;

                    if (stack.Peek() == matchingBrackets[item])
                        stack.Pop();
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }

        
    }
}
