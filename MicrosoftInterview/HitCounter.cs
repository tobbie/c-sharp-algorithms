using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
   public class HitCounter
    {
        private Dictionary<int, int> HitDict { get; set; }
        public HitCounter()
        {
            HitDict = new Dictionary<int, int>();
        }

        public void Hit(int timestamp)
        {
            if (HitDict.ContainsKey(timestamp))
                HitDict[timestamp] += 1;
            else
                HitDict.Add(timestamp, 1);
        }

        public int GetHits(int timestamp)
        {
            int hits = 0;
            foreach (var key in HitDict.Keys)
            {
                if (timestamp - key < 300)
                    hits += HitDict[key];
                else
                    HitDict.Remove(key);
            }

            return hits;
           
        }
    }
}
