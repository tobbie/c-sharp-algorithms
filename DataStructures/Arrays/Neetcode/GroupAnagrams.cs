using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays.Neetcode;

public static class GroupAnagrams
{
    public static IList<IList<string>> IsGrouped(string[] words)
    {

        /*
         * 0. initilize dictionary<string, List<string>>
         * 1. iterate over string of words
         * 2. for every word, initize an arrry of 26 characters with value 0, then iterate over the characters of the word
         * 3. for every character increment it's count using it's index -> do counts[c - 'a']++'
         * 4. after iteration, build a pattern with all values in counts array - string.join('#', counts);
         * 5. add key pattern to dictionry if it's not already there
         * 6. add word to as value for key pattern
         * 7. return list of grouped anagrams
         * 
         */
        if(words is null)
            return new List<IList<string>>();

        var map = new Dictionary<string, IList<string>>();
        foreach (var word in words)
        {
            var characters = new int[26];
            foreach (var c in word)
            {
                characters[c - 'a']++;
            }

            string key = string.Join("#", characters);

            if (!map.ContainsKey(key))
                map.Add(key, new List<string>());

            map[key].Add(word);


        }

        return map.Values.ToList();
    }
}
