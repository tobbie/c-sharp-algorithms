using System;
using System.Collections.Generic;

namespace DataStructures.Arrays.Neetcode;

public static class LongestSubstringWithoutDuplicateCharacter
{
    public static int LengthOfLongestSubstring(string s)
    {
        /**
         * define a hashset to store characters
         * set leftPointer to 0 rightPointer to 0; maxLength to 0
         * while rightPointer is less than s.length
         * then while character at rightPointer  in hashset
         * remove character at leftPointer from hashset
         * increment leftPointer by 1
         * add character at rightPointer to hashset
         * compute currentLength by subtracting leftPointer from rightPointer and adding 1
         * find the greater value between maxLength and currentLength and assign to maxLength
         * return maxLength
        
        **/

        if (s.Length == 0 || s == string.Empty) return 0;
        if (s.Length == 1) return 1;

        var charSet = new HashSet<char>();
        int leftPointer = 0; int rightPointer = 0; int maxLength = 0;


        while (rightPointer < s.Length)
        {

            while (charSet.Contains(s[rightPointer]))
            {
                charSet.Remove(s[leftPointer]);
                leftPointer++;
            }

            charSet.Add(s[rightPointer]);
            int currentLength = charSet.Count; //rightPointer - leftPointer + 1;
            maxLength = Math.Max(maxLength, currentLength);
            rightPointer++;
        }
        return maxLength;
    }
}
