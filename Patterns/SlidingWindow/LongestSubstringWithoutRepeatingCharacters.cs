using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SlidingWindow
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static (int, string) LongestSubstring(string inputString)
        {
            if(string.IsNullOrEmpty(inputString)) 
                return(0, string.Empty);    

            inputString = inputString.Trim();

            var characterDict = new Dictionary<char, int>();
            int maxLength = int.MinValue;
            int leftIndex = 0, rightIndex = 0;

            while(rightIndex< inputString.Length)
            {
                char currentChar = inputString[rightIndex];

                if (!characterDict.ContainsKey(currentChar))
                {
                    characterDict.Add(currentChar, rightIndex);
                }
                else
                {                  
                    if(leftIndex <= characterDict[currentChar]) //found duplicate in current window
                    {                  
                        if (rightIndex - leftIndex > maxLength) //compute current maximum
                        {
                            maxLength = rightIndex - leftIndex;
                        }

                        leftIndex = 1 + characterDict[currentChar]; // move leftPointer one step after index of duplicate 
                    }
                    
                    characterDict[currentChar] = rightIndex; // update index of duplicate found
                }
                
                rightIndex++;
            }

            maxLength = (rightIndex - leftIndex) > maxLength? rightIndex - leftIndex : maxLength;
            return(maxLength, inputString.Substring(leftIndex, rightIndex - leftIndex));
            
         }
    }
}
