using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Hard
{
   public class LongestSubstringWithoutDuplication
    {
        public LongestSubstringWithoutDuplication()
        {
            StartIndex = 0;
            Length = 0;
            Count = 0;
            EndIndex = 0;

        }
        public  int StartIndex { get; private set; }
        public  int Length { get; private set; }
        public  int EndIndex { get; private set; }

        public int Count { get; private set; }
        public  string Find(string str)
        {
            var table = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!table.ContainsKey(str[i]))
                {
                    table.Add(str[i], i);
                    Count += 1;
                }               
                else
                {
                    ComputeSubStringBounds(i);
                    i = table[str[i]];
                    table = new Dictionary<char, int>();
                    Count = 0;
                }
            }

            ComputeSubStringBounds(str.Length);
            return str.Substring(StartIndex, Length);
           // return str[StartIndex..(EndIndex + 1)];
        }

        private void ComputeSubStringBounds(int currentIndex)
        {
            if (Count > Length)
            {
                Length = Count;
                EndIndex = currentIndex - 1;
                StartIndex = EndIndex - Length + 1;
            }
               
        }
    }
}
