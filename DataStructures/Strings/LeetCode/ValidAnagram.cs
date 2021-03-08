using System;
using System.Collections.Generic;
using static System.Console;


namespace DataStructures.Strings.LeetCode
{
    public static class ValidAnagram
    {

        public static void Run() {
            WriteLine($"Is Anagram: {OptimalSolution("anagram", "nagaraq")}");
        }

        private static bool Solution1(string input1, string input2)
        {
            if (input2.Length != input1.Length)
                return false;

            var firstInputCharacters = input1.ToCharArray();
            var secondInputCharacters = input1.ToCharArray();
            Array.Sort(firstInputCharacters);
            Array.Sort(secondInputCharacters);

            var sortString1 = string.Join("", firstInputCharacters);
            var sortedString2 = string.Join("", secondInputCharacters);

            return sortString1.Equals(sortedString2);
        }

        private static bool OptimalSolution(string s, string t) {


            if (t.Length != s.Length)
                return false;


            var firstStringDict = new Dictionary<char, int>();
            var secondStringDict = new Dictionary<char, int>();

            for (int index = 0; index < s.Length; index++)
            {
                if (!firstStringDict.ContainsKey(s[index]))
                    firstStringDict.Add(s[index], 1);
                else
                    firstStringDict[s[index]]++;
             

                if (!secondStringDict.ContainsKey(t[index]))
                    secondStringDict.Add(t[index], 1);
                else
                    secondStringDict[t[index]]++;

            }

            for (int index = 0; index < t.Length; index++)
            {
                if (!firstStringDict.ContainsKey(t[index]))
                    return false;

                if (secondStringDict[t[index]] != firstStringDict[t[index]])
                    return false;
            }

            return true;

            
        }

    }
}
