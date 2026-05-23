
using System;
namespace DataStructures.Arrays.Neetcode;

public class MaxPlankSum
{
    // define two values to hold the two largest values in the array.
    // assign int.min to both values
    // loop through the array and compare each value to the two values we defined.
    //if current value in array is larger than the largest value assign the largest value to the second largest value and assign the current value to the largest value.
    // else if the current value is larger than the second largest value assign the current value to the second largest value.

    //if the absolute value of their difference is 1, return -1 , else return the sum of the two values.

    public int MaxSum(int[] arr)
    {
        if (arr == null || arr.Length < 2)
            return -1;



        int max1 = int.MinValue;
        int max2 = int.MinValue;

        foreach (int plank in arr)
        {
            if (plank > max1)
            {
                max2 = max1;
                max1 = plank;
            }
            else if (plank > max2)
            {
                max2 = plank;
            }
        }

        if (Math.Abs(max1 - max2) == 1)
            return -1;
        else
            return max1 + max2;

    }

    //public async Task TestConfigureAwait() { 

    //    await  File.WriteAllTextAsync("test.txt", "Hello, World!").ConfigureAwait(false);
    //}



}