using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TwoPointers
{
  public class PalindromeNumber
    {
        public bool NumberIsPlaindrome(int number)
        {
            var list = SplitNumber(number);

            var start = list.First;
            var end = list.Last;

            while(start != end)
            {
                if(start.Value != end.Value)
                    return false;
                start = start.Next;
                end = end.Previous;
            }
            return true;
        }

        private LinkedList<int> SplitNumber(int number)
        {
            var list = new LinkedList<int>();

            while(number != 0)
            {
                int digit = number % 10;
                list.AddFirst(digit);
                number /= 10;
            }
            return list;
        }
    }
}
