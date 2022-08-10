using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MicrosoftInterview
{
    public class BasicCalculator2
    {
        public static int Calculate(string s)
        {
            s = s.Trim();
            int currentNumber = 0,  result = 0;
            char currentCharacter;
            char operation = '+';
            var stack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                currentCharacter = s[i];
                if(char.IsDigit(currentCharacter))
                {
                    currentNumber = currentNumber * 10 + (int)char.GetNumericValue(currentCharacter);
                }

                if((!char.IsDigit(currentCharacter) && currentCharacter != ' ') || i == s.Length  -1)
                {
                    if (operation == '+')
                        stack.Push(currentNumber);
                    else if (operation == '-')
                        stack.Push(-currentNumber);
                    else if (operation == '*')
                    {
                        stack.Push(stack.Pop() * currentNumber);
                    }
                    else if( operation == '/')
                    {
                        stack.Push(stack.Pop() / currentNumber);
                    }

                    currentNumber = 0;
                    operation = currentCharacter;
                }
            }

            while(stack.Count > 0)         
                result += stack.Pop();

            return result;
            
        }

        public static int CalculateOptimal(string s)
        {
            s = s.Trim();

            int lastNumber = 0, currentNumber = 0, result = 0;
            char currentCharacter;
            char operation = '+';

            for (int i = 0; i < s.Length; i++)
            {
                currentCharacter = s[i];
                if(char.IsDigit(currentCharacter))
                {
                    currentNumber = currentNumber * 10 + (int)char.GetNumericValue(currentCharacter);
                }

                if(!char.IsDigit(currentCharacter) && currentCharacter != ' ' || i == s.Length -1)
                {
                    if(operation =='+' || operation == '-')
                    {
                        result += lastNumber;
                        lastNumber = operation == '+' ? currentNumber : -currentNumber;
                    }
                    else if(operation == '*')
                    {
                        lastNumber = lastNumber * currentNumber;

                    }
                    else if (operation == '/')
                    {
                        lastNumber = lastNumber / currentNumber;
                    }

                    operation = currentCharacter;
                    currentNumber = 0;
                }
            }
            result += lastNumber;
            return result;

            
        }
    }
}
