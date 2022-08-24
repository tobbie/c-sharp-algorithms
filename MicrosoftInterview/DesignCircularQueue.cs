using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
   public class DesignCircularQueue
    {
        private int Capacity { get; set; }
        private LinkedList<int> list { get; set; }
        public DesignCircularQueue(int k)
        {
            Capacity = k;
            list = new LinkedList<int>();

        }

        public bool EnQueue(int value)
        {
            if (IsFull())
                return false;

            list.AddFirst(value);
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
                return false;

            list.RemoveLast();
            return true;
        }

        public int Front()
        {   
            if(!IsEmpty())
              return list.Last.Value;

            return -1;
        }

        public int Rear()
        {
           if(!IsEmpty())
                return list.First.Value;

            return -1;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public bool IsFull()
        {
            return list.Count == Capacity;
        }
    }
}
