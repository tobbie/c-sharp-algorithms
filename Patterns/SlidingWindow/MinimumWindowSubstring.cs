using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SlidingWindow
{
    public class MinimumWindowSubstring
    {
       public static string FindMinimumSubstring(string inputString, string subString)
        {
            if (string.IsNullOrEmpty(subString))
                return string.Empty;

            var rCount = new Dictionary<char, int>();
            var window = new Dictionary<char, int>();

           

            for(int i =0; i < subString.Length; i++)
            {
                if (rCount.ContainsKey(subString[i]))
                    rCount[subString[i]]++;
                else
                    rCount.Add(subString[i], 1);

                window.TryAdd(subString[i], 0);
            }

            int required = rCount.Count;
            int current = 0;
            int leftIndex = 0, rightIndex = 0, start = 0;
            string minimumSubstring = string.Empty;
            int minimumLength = int.MaxValue;

            while (rightIndex < inputString.Length)
            {
                char currentCharacter = inputString[rightIndex];
                rightIndex++;

                if (rCount.ContainsKey(currentCharacter))
                {
                    window[currentCharacter] += 1;
                    if (rCount[currentCharacter].Equals(window[currentCharacter]))
                    {
                        current += 1;
                    }
                }

                while(current == required)
                {
                    if(rightIndex - leftIndex < minimumLength)
                    {
                        start = leftIndex;
                        minimumLength= rightIndex - leftIndex;
                    }

                    char trailingCharacter = inputString[leftIndex];
                    leftIndex++;

                    if (rCount.ContainsKey(trailingCharacter))
                    {
                        if (rCount[trailingCharacter].Equals(window[trailingCharacter]))
                            current -= 1;

                        window[trailingCharacter] -= 1;
                            
                    }
                }
            }

            return minimumLength ==int.MaxValue ? string.Empty : inputString.Substring(start, minimumLength);

        }
    }
}
