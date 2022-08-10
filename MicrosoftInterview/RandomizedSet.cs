using System;
using System.Collections.Generic;
using System.Linq;

namespace MicrosoftInterview
{
    public class RandomizedSet
    {
        private Dictionary<int, int> HashMap { get; set; }
        private List<int> numbersList { get; set; }

        private int LastIndex { get => numbersList.Count - 1; }
        public RandomizedSet()
        {
            HashMap = new Dictionary<int, int>();
            numbersList = new List<int>();
        }

        public bool Insert(int val)
        {
           
                
            
            if(!HashMap.ContainsKey(val))
            {
                HashMap.Add(val, numbersList.Count);
                numbersList.Add(val);
                return true;
            }
            else
                return false;
        }

        public bool Remove(int val)
        {
            if (HashMap.ContainsKey(val))
            {
                int index = HashMap[val];
                int lastValue = numbersList[^1];

                numbersList[index] = lastValue;
                numbersList.RemoveAt(LastIndex);

                HashMap[lastValue] = index;
                HashMap.Remove(val);
                return true;
            }
            else
                return false;
           
        }

        public int GetRandom()
        {
            var randomGenerator = new Random();
            int index = randomGenerator.Next(0, numbersList.Count);
            return numbersList[index];
        }
    }
}
