using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MathProblems
{
     public class PowerOfTwo
    {
        public static bool IsPowerOfTwo(int num)
        {
            var res = Math.Log2(num);
            return (res % 1) == 0;
            
        }
    }
}
