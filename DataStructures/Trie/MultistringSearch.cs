using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trie
{
  public class MultistringSearch
    {
        public static List<bool> Search(string bigstring, string[] smallstrings)
        {
            var suffixTrie = new SuffixTrie(bigstring);

            var result = new List<bool>();

            foreach (var word in smallstrings)
            {
                if (suffixTrie.ContainsWord(word))
                    result.Add(true);
                else
                    result.Add(false);
            }
            // Write your code here.
            return result;
        }
    }
}
