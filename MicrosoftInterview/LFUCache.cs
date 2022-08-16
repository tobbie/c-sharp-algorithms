using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    //explanation :  https://www.youtube.com/watch?v=iM4QKS4GxA4
    public class LFUCache
    {
        private Dictionary<int, LinkedListNode<Item> > Cache { get; set; }
        private Dictionary<int, int> KeyCount { get; set; }
        private int Capacity { get; set; }
        private int MinCount { get; set; }
        private Dictionary<int, LinkedList<Item>> FrequencyMap { get; set; }
        public LFUCache(int capacity)
        {
            Capacity = capacity;
            MinCount = -1;
            FrequencyMap = new();
            FrequencyMap.Add(1, new LinkedList<Item>());
            KeyCount = new();
            Cache = new();
        }

        public int Get(int key)
        {
            if (!Cache.ContainsKey(key)) return -1;

            int currentCount = KeyCount[key];
            KeyCount[key] += 1;

            var nodeItem = Cache[key];
            FrequencyMap[currentCount].Remove(nodeItem);

            if (currentCount == MinCount && FrequencyMap[currentCount].Count == 0)
                MinCount += 1;

            if (!FrequencyMap.ContainsKey(currentCount + 1))
                FrequencyMap.Add(currentCount + 1, new LinkedList<Item>());

            FrequencyMap[currentCount + 1].AddLast(nodeItem);
           
            return Cache[key].Value.ItemValue;

        }

        public void Put(int key, int value)
        {
            if (Capacity <= 0) return;

            if (Cache.ContainsKey(key))
            {
                Cache[key].Value.ItemValue = value;
                Get(key);
                return;
            }

            if(Cache.Count >= Capacity)
            {
                var node = FrequencyMap[MinCount].First;
                EvictItem(node);
            }

            var newItem = new LinkedListNode<Item>(new Item(key, value));
           
            Cache.Add(key,newItem);
            KeyCount.Add(key, 1);
            MinCount = 1;
            FrequencyMap[1].AddLast(newItem);
                
        }

        private void EvictItem(LinkedListNode<Item> node)
        {
            FrequencyMap[MinCount].Remove(node);
            KeyCount.Remove(node.Value.Key);
            Cache.Remove(node.Value.Key);
        }
    }

    public class Item
    {
        public int Key { get; private set; }
        public int ItemValue { get; set; }

        public Item(int key, int value)
        {
            Key = key;
            ItemValue = value;
        }
    }
}

