using System.Collections.Generic;

namespace DataStructures.Arrays.Neetcode
{
    public static class ValidAnagram
    {
        public static bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;


            var frequencyTable = new Dictionary<char, int>();
            for (int index = 0; index < s.Length; index++)
            {
                if (frequencyTable.ContainsKey(s[index]))
                    frequencyTable[s[index]]++;
                else
                    frequencyTable.Add(s[index], 1);
            }

            for (int index = 0; index < t.Length; index++)
            {
                if (!frequencyTable.ContainsKey(t[index]))
                    return false;
                else if (frequencyTable.ContainsKey(t[index]) && frequencyTable[t[index]] > 0)
                    frequencyTable[t[index]]--;
                else if (frequencyTable.ContainsKey(t[index]) && frequencyTable[t[index]] == 0)
                    return false;


            }

            return true;
        }

        public static bool IsAnagram(string s, string t)
        {
            /**
            1. initilize two dictionaries of char key and value int
            2. interate over both strings then insert thier values in the dictionary
            3. increment the integer value of charters for every time they re-occur
            4. loop thru string s , if the value of the character is note same in both dictonaries, then
            return false, other wise continue looping
            5. return true at the end of the loop

             Edge case
        ====================================
        if both strings are not equal return false,
        if either or both strings are null return false
        if both strings are empty return true

        **/

            if (s == null || t == null) return false;

            if (s.Length != t.Length) return false;

            var dictOne = new Dictionary<char, int>();
            var dictTwo = new Dictionary<char, int>();

            for (int index = 0; index < s.Length; index++)
            {
                if (!dictOne.ContainsKey(s[index]))
                    dictOne.Add(s[index], 1);
                else
                    dictOne[s[index]]++;
            }

            for (int index = 0; index < t.Length; index++)
            {
                if (!dictTwo.ContainsKey(t[index]))
                    dictTwo.Add(t[index], 1);
                else
                    dictTwo[t[index]]++;
            }

            for (int index = 0; index < s.Length; index++)
            {
                if (!dictTwo.ContainsKey(s[index]))
                    return false;

                if (dictOne[s[index]] != dictTwo[s[index]])
                    return false;
            }

            return true;
        }
    }
}
