using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class MaxLengthConcatenatedString
    {
        public static int MaxLength(IList<string> array)
        {

            int maxLength = -1;
            var result = new List<string>();
            MaxUnique(array, "", 0, result);

            foreach  (var word in result)
            {
                maxLength = Math.Max(maxLength, HasUniqueCharacters(word));
            }

            return maxLength;
        }

        private static void MaxUnique(IList<string> array, string current, int index, List<string> result)
        {
            if (index == array.Count)
            {
                result.Add(current);
                return;
            }

          //  result.Add(current);    
            MaxUnique(array, current, index + 1, result);
            MaxUnique(array, current + array[index], index + 1, result);

        }

        private static int HasUniqueCharacters(string s)
        {
            var set = new HashSet<char>();
            for (int i = 0; i< s.Length; i++)
            {
                if (!set.Contains(s[i]))
                    set.Add(s[i]);
                else
                    return -1;
            }

            return s.Length;
        }
    }
}
