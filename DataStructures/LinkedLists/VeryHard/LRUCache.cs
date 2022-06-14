using System;
using System.Collections.Generic;


namespace DataStructures.LinkedLists.VeryHard
{
	public class LRUCache
	{
		public int maxSize;
        public Dictionary<string, LinkedListNode<KeyValueItem>> Cache { get; set; }
		public LinkedList<KeyValueItem> ListOfMostRecentValues { get; set; }
		public int CurrentSize { get; private set; }

        public LRUCache(int maxSize)
		{
			this.maxSize = maxSize > 1 ? maxSize : 1;
			Cache = new Dictionary<string, LinkedListNode<KeyValueItem>>();
			CurrentSize = 0;
			ListOfMostRecentValues = new LinkedList<KeyValueItem>();
			
			
		}

		public void InsertKeyValuePair(string key, int value)
		{
			// Write your code here.
			if(!Cache.ContainsKey(key))
            {
				if (CurrentSize == maxSize)
					EvictLeastRecent();			
				else
					CurrentSize += 1;			
				
				Cache.Add(key, new LinkedListNode<KeyValueItem>(new KeyValueItem(key, value)));
				ListOfMostRecentValues.AddFirst(Cache[key]);
			}
			else
            {
				ReplaceKey(key, value);
				UpdateMostRecentValue(Cache[key]);
            }
			//updateMostRecentValue
			//UpdateMostRecentValue(Cache[key]);
			
		}

		private void UpdateMostRecentValue(LinkedListNode<KeyValueItem> node)
        {
			ListOfMostRecentValues.Remove(node);
			ListOfMostRecentValues.AddFirst(node);

		}

		private void ReplaceKey(string key, int value)
        {
			if (!Cache.ContainsKey(key))
				throw new InvalidOperationException();

			Cache[key].Value.ItemValue = value;
        }

		private void EvictLeastRecent()
        {
			string keyToRemove = ListOfMostRecentValues.Last.Value.ItemKey;
			ListOfMostRecentValues.RemoveLast();
			Cache.Remove(keyToRemove);
        }

		public LRUResult GetValueFromKey(string key)
		{
			if (!Cache.ContainsKey(key))
				return null;

			UpdateMostRecentValue(Cache[key]);
			return new LRUResult(true, Cache[key].Value.ItemValue);
		}

		public string GetMostRecentKey()
		{
			return ListOfMostRecentValues.First.Value.ItemKey;
		}
	}

	public class KeyValueItem
    {
        public string ItemKey { get; set; }
        public int ItemValue { get; set; }

		public KeyValueItem(string key, int value)
        {
			ItemKey = key;
			ItemValue = value;
        }
    }

	public class LRUResult
	{
		public bool found;
		public int value;

		public LRUResult(bool found, int value)
		{
			this.found = found;
			this.value = value;
		}
	}
}
