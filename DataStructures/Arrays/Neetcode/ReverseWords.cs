using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Neetcode
{
    public static class ReverseWords
    {
        // "Hello World"
        // "I am sam"
        // "The quick brown fox jumped over the lazy dog"
        public static string Reverse(string words)
        {
            if (string.IsNullOrEmpty(words))
                return words;
            if (words.Length == 1)
                return words;
            
                
            
            words = words.Trim();
            var charWord = words.ToCharArray();

            int start = 0, end = charWord.Length -1;
            Swap(charWord, start, end);

           
            start = end = 0;

            for(int tracker = 0; tracker < charWord.Length; tracker++)
            {
                if (charWord[tracker] == ' ')
                    end = tracker - 1;
                else if (tracker == charWord.Length - 1)
                    end = tracker;
                else
                    continue;

                Swap(charWord, start, end);
                tracker += 1;
                start = end = tracker;           
            }


            return new String(charWord); ;

        }

        private static void Swap(char[] words, int start, int end) 
        { 
            while(start < end)
            {
                var temp = words[start];
                words[start] = words[end];
                words[end] = temp;
                start += 1;
                end -= 1;
            }
        }
    }
}
