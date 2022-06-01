using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Meduim
{
    public class MinimumCharactersForWords
    {
        public static char[] MinimumCharacters(string[] words)
        {
            var characterFrequency = new Dictionary<char, int>();
            foreach  (string word in words)
            {
                var characterCounter = new Dictionary<char, int>();
                for (int i = 0; i < word.Length; i++)
                {
                    if (!characterCounter.ContainsKey(word[i]))
                    {
                        characterCounter.Add(word[i], 1);
                        characterFrequency.TryAdd(word[i], 0);
                    }
                    else
                    {
                        characterCounter[word[i]] += 1;
                    }

                    characterFrequency[word[i]] = Math.Max(characterFrequency[word[i]], characterCounter[word[i]]);
                }
            }

            return GenerateCharacterArray(characterFrequency);
        }

        private static char[] GenerateCharacterArray(Dictionary<char, int> characterFrequency)
        {
            var result = new List<char>();

            foreach (char character in characterFrequency.Keys)
            {
                int characterCount = characterFrequency[character];

                for (int i= 0; i < characterCount; i++)
                {
                    result.Add(character);
                }
            }

            return result.ToArray();
        }
    }
}
