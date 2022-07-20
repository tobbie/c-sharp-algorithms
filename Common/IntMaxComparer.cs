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

    public class WordItemComparer : IComparer<WordItem>
    {
        public int Compare(WordItem x, WordItem y)
        {
            if (y.Frequency.CompareTo(x.Frequency) == 0)
            {
                return x.Word.CompareTo(y.Word);
            }
            else
                return y.Frequency.CompareTo(x.Frequency);
        }
    }

    public class WordItem
    {
        public WordItem(int freq, string word)
        {
            Frequency = freq;
            Word = word;
        }
        public int Frequency { get; set; }
        public string Word { get; set; }
    }
}
