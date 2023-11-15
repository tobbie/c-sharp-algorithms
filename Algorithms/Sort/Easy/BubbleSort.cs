


namespace Algorithms.Sort.Easy
{
    public class BubbleSort
    {
        public static int[] Sort(int [] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                int leftPointer = index;
                int rightPointer = leftPointer + 1;

                while(rightPointer < array.Length)
                {
                    if (array[rightPointer] < array[leftPointer])
                        Swap(array, leftPointer, rightPointer);

                    rightPointer++;
                }
            }

            return array;
                
        }

        private static void Swap(int[] array, int leftPointer, int rightPointer)
        {
            var temp = array[leftPointer];
            array[leftPointer] = array[rightPointer];
            array[rightPointer] = temp;
        }
    }
}
