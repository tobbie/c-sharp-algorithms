
using Common;

namespace Algorithms.Sort.Easy
{
    public class SelectionSort
    {
        public static int[] Sort(int [] array)
        {
            if (array.Length == 0 || array.Length == 1) return array;

            for (int index = 0; index < array.Length; index++)
            {
                int smallest = index;
                int next = smallest + 1;

                while(next < array.Length)
                {
                    if (array[next] < array[smallest])
                    {
                        smallest = next;
                        next = smallest + 1;
                    }
                    else
                        next++;
                }

                //Swap
                Util.Swap(array, index, smallest);

            }
            return array;
        }
    }
}
