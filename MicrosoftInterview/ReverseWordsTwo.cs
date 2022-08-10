using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace MicrosoftInterview
{
   public class ReverseWordsTwo
    {
        public static char[] Reverse(char[] s)
        {
            if (s.Length == 0 || s.Length == 1)
                return s;


            var res = s.Where(x => char.IsWhiteSpace(x)).FirstOrDefault();
            if (res != ' ')
                return s;
             

            int startIndex = 0;
            int endIndex = s.Length - 1;
            bool hasSpaces = false;

            DoCharacterSwap(s, startIndex, endIndex);         
            startIndex = endIndex =  0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    continue;
                else
                {
                    endIndex = i - 1;
                    i += 1;

                    DoCharacterSwap(s, startIndex, endIndex);
                    startIndex = i;
                    hasSpaces = true;
                }
            }
            //swap for last character;
            if(hasSpaces)
                DoCharacterSwap(s, startIndex, s.Length - 1);

           


            return s;
        }

        private static void DoCharacterSwap(char[] array, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                Util.Swap(array, startIndex, endIndex);
                startIndex++;
                endIndex--;
            }
        }
    }
}
