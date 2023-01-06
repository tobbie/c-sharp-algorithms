using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public  class ListNode
    {
        public ListNode next { get; set; }
        public int Value { get; private set; }
        public ListNode(int value)
        {
            next = null;
            Value = value;
        }
        
    }
}
