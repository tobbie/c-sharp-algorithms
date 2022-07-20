using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Heaps.Medium
{
    public class TopKFrequentWords
    {
        public static IList<string> TopFrequent(string[] words, int k)
        {
            /**
             * Iterate over iput arrays
             * Compute frequncy of unique words with hashtable
             * iterate over keys of hashtable, store each key in prority queue
             * while k is greater than zero, remove top item in priority queue and add to result array
             * return result array
             **/

            var maxHeap = new PriorityQueue<string, WordItem>(new WordItemComparer());
            var frequencyTable = new Dictionary<string, int>();
            var result = new List<string>();

            foreach (var word in words)
            {
                if (!frequencyTable.ContainsKey(word))             
                    frequencyTable.Add(word, 1);            
                else
                    frequencyTable[word] += 1;
            }

            foreach (var key in frequencyTable.Keys)
                maxHeap.Enqueue(key, new WordItem(frequencyTable[key], key));

            while( k >  0)
            {
                result.Add(maxHeap.Dequeue());
                k -= 1;
            }

            return result;           
        }
    }
}
