using System;
using System.Collections.Generic;

namespace DataStructures.Strings.Meduim
{
    public static class GroupAnagrams
    {
        public static void Run() {
            var input = new string[] {"yo", "act", "flop", "tac", "foo", "cat", "oy", "olfp" };
            Util.Print2DArray(OptimalSolution(input));
            
        }

        private static List<List<string>> OptimalSolution(string [] input) {

            var anagramDict = new Dictionary<string, List<string>>();
            var result = new List<List<string>>();

            for (int index= 0; index < input.Length; index++)
            {
                var sortedItem = input[index].ToCharArray();
                Array.Sort(sortedItem);
                var sortedString = string.Join("", sortedItem);

                if (!anagramDict.ContainsKey(sortedString))
                    anagramDict.TryAdd(sortedString, new List<string> { input[index] });           
                else             
                    anagramDict[sortedString].Add(input[index]);              
            }

            foreach (var item in anagramDict)
                result.Add(item.Value);
            
            return result;
            
        }

    }
}
