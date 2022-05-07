using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.Medium
{
    public class MinMaxStack
    {
      
		private LinkedList<int> list { get; set; }
		private Dictionary<int, MinMaxValues> tracker { get; set; }

		public MinMaxStack() {
			list = new LinkedList<int>();		
			tracker = new Dictionary<int, MinMaxValues>();
			
		}

		public int Count()
		{
			tracker.Keys.Max();
			return list.Count;
		}

        public int Peek()
		{
			if (list.Count > 0)
				return list.Last.Value;

			return -1;
		}

		public int Pop()
		{
			return _Pop();
		}

		private int _Pop() { 
			
		    if(Peek() != -1)
            {
				var value = list.Last.Value;
			
				tracker[value].Count--;
				
				if (tracker[value].Count == 0)
					tracker.Remove(value);
				
				
				list.RemoveLast();
				return value;
            }
			return -1;
		}

		public void Push(int number)
		{
			_Push(number);
		}

		private void _Push(int number)
		{
			var minMaxValues = new MinMaxValues();

			if (Peek() == -1)
			{
				minMaxValues.Minimum = number;
				minMaxValues.Maximum = number;
				minMaxValues.Count++;

				tracker.Add(number, minMaxValues);
				list.AddLast(number);
				return;
            }

          
			if (!tracker.ContainsKey(number))
			{
				int currentMinimum = tracker.Last().Value.Minimum;
				int currentMaximum = tracker.Last().Value.Maximum;
				minMaxValues.Minimum = number < currentMinimum ? number : currentMinimum;
				minMaxValues.Maximum = number > currentMaximum ? number : currentMaximum;
				minMaxValues.Count++;
				tracker.Add(number, minMaxValues);

			}
			else
			{
				tracker[number].Count++;
			}

			list.AddLast(number);
				
            
		}


		public int GetMin()
		{
			
			if (Peek() != -1)
			{
				return tracker.Last().Value.Minimum;
			
			}
			return -1;
		}


		public int GetMax()
		{
			
			if (Peek() != -1)
			{
				return tracker.Last().Value.Maximum;
			}
			return -1;
		}

	}

	internal class MinMaxValues
	{
        public int  Maximum { get; set; }

		public int Count { get; set; }
		public int Minimum { get; set; }
    }

}
