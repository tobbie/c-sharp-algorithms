using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Trie
{
  public class AutocompleteSystem
    {
        private Dictionary<string, int> Lookup = new();
        private PrefixTrie Trie { get; set; }

        private PriorityQueue<string, WordItem> MaxHeap { get; set; }

        private string Keyword { get; set; }
        public AutocompleteSystem(string[] sentences, int[] times)
        {
            for (int i = 0; i < sentences.Length; i++)    
                Lookup.Add(sentences[i], times[i]);

            Trie = new();

            foreach (var word in sentences)     
                Trie.Insert(word);

           // MaxHeap = new PriorityQueue<string, WordItem>(new WordItemComparer());
        }

        public IList<string> Input(char c)
        {
            var answerList = new List<string>();
            MaxHeap = new PriorityQueue<string, WordItem>(new WordItemComparer());

            if (c == '#')
            {
                if (!Lookup.ContainsKey(Keyword))
                    Lookup.Add(Keyword, 1);
                else
                    Lookup[Keyword] += 1;

                Trie.Insert(Keyword);
                Keyword = string.Empty;
                return new List<string>();
            }
            else
            {
                Keyword += c;
                var resultList = Trie.Search(Keyword);

                foreach (var word  in resultList)
                {
                    if (Lookup.ContainsKey(word))
                        MaxHeap.Enqueue(word, new WordItem(Lookup[word], word));
                }

                while (MaxHeap.Count > 0)
                {
                    answerList.Add(MaxHeap.Dequeue());
                    if (answerList.Count == 3)
                        break;
                }    
                return answerList;                       
            }
        }
    }
}

