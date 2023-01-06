using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TwoPointers
{
    public class ReverseWords
    {
        public static string ReverseStringWords(string sentence)
        {
            sentence = sentence.Trim(); 

            var trimmedString = RemoveUnwantedSpaces(sentence);
            var stringArray = trimmedString.ToCharArray();

             ReverseString(stringArray, 0, stringArray.Length - 1);

            int left = 0, right = 0;
            int start = 0,end = 0;

            while(right < stringArray.Length)
            {
               if(stringArray[right] == ' ')
                {
                    start = left;
                    end = right - 1;
                    ReverseString(stringArray, start, end);
                    left = right + 1;

                }
                right += 1;
            }
            start = left;
            end = right - 1;

            ReverseString(stringArray, start, end);
            return string.Join("", stringArray);
          
        }

        private static void ReverseString(char[] array, int leftPointer, int rightPointer)
        {
            while(leftPointer < rightPointer)
            {
                char temp = array[leftPointer];
                array[leftPointer] = array[rightPointer];
                array[rightPointer] = temp;

                leftPointer++;
                rightPointer--;
            }           
        }
        private static string RemoveUnwantedSpaces(string input)
        {
            var sb = new StringBuilder();
            int spaceCount = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ') 
                {
                    sb.Append(input[i]);
                    spaceCount = 0;
                }
                else if (input[i] == ' ' && spaceCount == 0)
                {
                    sb.Append(' ');
                    spaceCount += 1;
                }
                else if (input[i] == ' ' && spaceCount > 0)
                {
                    spaceCount += 1;
                }    
            }

            return sb.ToString();

        }
    }
}
