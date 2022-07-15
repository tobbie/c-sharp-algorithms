using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class RandomizedCollection
    {
        private Dictionary<int, SetItem> NumbersMap { get; set; }
        private List<int> NumbersList { get; set; }
        public RandomizedCollection()
        {
            NumbersMap = new Dictionary<int, SetItem>();
            NumbersList =  new List<int>();
        }

        public bool Insert(int val)
        {
            if(NumbersMap.ContainsKey(val))
            {
                NumbersMap[val].Count += 1;
                NumbersMap[val].Indices.Add(NumbersList.Count);
                NumbersList.Add(val);
                return false;
            }
            else
            {
                var setItem = new SetItem();
                setItem.Indices.Add(NumbersList.Count);
                NumbersMap.Add(val, setItem);
                NumbersList.Add(val);
                return true;
            }
        }

        public bool Remove(int val)
        {
            if(NumbersMap.ContainsKey(val))
            {
                int index = NumbersMap[val].Indices.First();
                
                var lastValue = NumbersList[^1];
                NumbersList[index] = lastValue;

                int idxToRemove = NumbersList.Count - 1;
                NumbersMap[lastValue].Indices.Remove(idxToRemove);
                NumbersList.RemoveAt(NumbersList.Count - 1);

                if(idxToRemove != index)
                {
                    NumbersMap[lastValue].Indices.Add(index);                
                }

                if(val != lastValue)
                    NumbersMap[val].Indices.Remove(index);

                NumbersMap[val].Count -= 1;

                if (NumbersMap[val].Count == 0)
                    NumbersMap.Remove(val);
                
                return true;

            }
            else
            {
                return false;
            }
           
        }

        public int GetRandom()
        {
            var random = new Random();
            int index = random.Next(0, NumbersList.Count);
            return NumbersList[index];
        }
    }

    public class SetItem
    {
        public SetItem()
        {
            Count = 1;
            Indices = new HashSet<int>();
        }
        public int Count { get; set; }
        public HashSet<int> Indices { get; set; }
    }



}
