using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class IntMaxComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
           return y.CompareTo(x);
        }
    }
}
