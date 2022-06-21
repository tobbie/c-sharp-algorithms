using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Microsoft
{
    public class GroupAnagrams
    {
        public static List<List<string>> Group(List<string> input)
        {
            // the key here is to sort each word in the input list, every anagram will be have the same sequence of characters after sorting therefor it can be used to group.

            /**
             * 1. iterate thru input list
             * 2. convert each string to character array
             * 3. sort the string character array
             * 4. convert it back to a string
             * 5. add sorted string as key to dict, with value as the original item at index
             * 6. repeat for all strings in input list.
             * 7. Loop thru dict and for each item key, add it's values list to a new list.
             * 8. return new list.
             **/

            var anagramDict = new Dictionary<string, List<string>>();
            var result = new List<List<string>>();

            foreach (var word in input)
            {
                var wordArray = word.ToCharArray();
                Array.Sort(wordArray);
                var sortedWord = string.Join("", wordArray);

                if (anagramDict.ContainsKey(sortedWord))
                    anagramDict[sortedWord].Add(word);
                else
                    anagramDict.TryAdd(sortedWord, new List<string> { word });
            }

            foreach (var item in anagramDict)
                result.Add(item.Value);
            
            return result;
        }
    }
}
