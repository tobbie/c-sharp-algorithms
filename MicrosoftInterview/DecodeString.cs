using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
  public class DecodeString
    {
        public static string Decode(string s)
        {
            var numbers = new Stack<int>();
            var stringList = new Stack<string>();
            string result = string.Empty;
            int index = 0;
            
            while (index < s.Length)
            {
                if (char.IsDigit(s[index]))
                {
                    int currentNumber = 0;
                    while (char.IsDigit(s[index]))
                    {
                        currentNumber = currentNumber * 10 + (int)char.GetNumericValue(s[index]);
                        index += 1;
                    }

                    numbers.Push(currentNumber);
                }
                else if (s[index] == '[')
                {
                    stringList.Push(result);
                    result = string.Empty;
                    index += 1;
                }
                else if (s[index] == ']')
                {              
                    result = BuildString(result, stringList.Pop(), numbers.Pop());
                    index += 1;
                }
                else
                {
                    result += s[index];
                    index += 1;
                }
            }
            return result;
        }


        private static string BuildString(string current, string lastResult, int number)
        {
            var builder = new StringBuilder(lastResult);
            for (int i = 0; i < number; i++)
                builder.Append(current);

            return builder.ToString();
            
        }
    }
}
