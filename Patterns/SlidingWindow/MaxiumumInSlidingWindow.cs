

namespace Patterns.SlidingWindow
{
   public static class MaximumInSlidingWindow
    {
        /**
         1. Find maximum in firstw window size.
         2. Loop thru first window and find maximum
         3. Starting from window size loop thru rest of array , find maxium per window size and store in result array
         4. Check if index of the first element in deque (linkedlist) is part of the window, if not remove from deque linked list
         **/
        public static List<int> FindMaximum(List<int> numbers, int windowSize)
        {
            var result = new List<int>();

            if(!numbers.Any()) return result;

            if(windowSize > numbers.Count)
                windowSize = numbers.Count;

            var window = new LinkedList<int>();

            for (int i = 0; i < windowSize; i++)
            {
                //remove all previous values less than current value from window
                while (window.Count > 0 && numbers[i] >= numbers[window.Last.Value])
                {
                    window.RemoveLast();
                }

                window.AddLast(i);               
            }
            if(window.First != null)
               result.Add(numbers[window.First.Value]);
            
            for (int i = windowSize; i < numbers.Count; i++)
            {
                // remove all previous values less than current value from window
                while (window.Count > 0 && numbers[i] >= numbers[window.Last.Value])
                {
                    window.RemoveLast();
                }

                //remove first index in linked list if it does not fall withing the current window
                if(window.Count > 0 && window.First.Value <= (i - windowSize))
                    window.RemoveFirst();

                 window.AddLast(i);
                 result.Add(numbers[window.First.Value]);
            }


            return result;
        }
    }
}
