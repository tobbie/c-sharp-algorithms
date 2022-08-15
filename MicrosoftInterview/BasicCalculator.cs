
namespace MicrosoftInterview
{
   public class BasicCalculator
    {
        public static int Calculate(string s)
        {
            int sum = 0;
            var stack = new Stack<int>();
            int sign = 1; // +positive

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int number = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        number = number * 10 + (int)char.GetNumericValue(s[i]);
                        i++;
                    }

                    sum += number * sign;
                    i--;
                }
                else if (s[i] == '+')
                {
                    sign = 1;
                }
                else if (s[i] == '-')
                {
                    sign = -1;
                }
                else if (s[i] == '(')
                {
                    stack.Push(sum);
                    stack.Push(sign);
                    sum = 0;
                    sign = 1;
                }
                else if (s[i] == ')')
                {
                    sum = stack.Pop() * sum;
                    sum += stack.Pop();
                }

            }
            return sum;
        }
    }
}
