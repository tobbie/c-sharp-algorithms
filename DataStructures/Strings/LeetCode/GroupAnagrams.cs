using System;
using System.Collections.Generic;

namespace DataStructures.Strings.LeetCode
{
    public static class GroupAnagrams
    {
        public static void Run() { }

        public static IList<IList<string>> OptimalSolution(string [] strs) {

            var anagramDict = new Dictionary<string, List<string>>();
            var result = new List<IList<string>>();

            for (int index = 0; index < strs.Length; index++)
            {
                var stringCharacters = strs[index].ToCharArray();
                Array.Sort(stringCharacters);
                var sortedString = string.Join("", stringCharacters);

                if (!anagramDict.ContainsKey(sortedString))
                    anagramDict.Add(sortedString, new List<string> { strs[index] });
                else
                    anagramDict[sortedString].Add(strs[index]);
            }

            foreach (var item in anagramDict)
                result.Add(item.Value);
            
            return result;
        }
    }
}
