using System.Collections.Generic;

namespace DataStructures.Arrays.Neetcode;

public static class ContainsDuplicate
{
    public static void Run()
    { }

    public static bool HasDuplicate2(int[] nums)
    {
        var hashSet = new HashSet<int>();
        for (int index = 0; index < nums.Length; index++)
        {
            if (hashSet.Contains(nums[index]))
                return true;
            else
                hashSet.Add(nums[index]);
        }
        return false;

    }

    public static bool HasDuplicate(int[] nums)
    {
       if(nums is  null || nums.Length == 0 || nums.Length  == 1) return false;

        var hashSet = new HashSet<int>();
        foreach (var value in nums)
        {
            if (hashSet.Contains(value))
                return true;
            hashSet.Add(value);
        }
        return false;
    }
}