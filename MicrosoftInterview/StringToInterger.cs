using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MicrosoftInterview
{
    public class StringToInterger
    {
        //O(n) time, O(n) space;
        public static int ConvertString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            if (input.StartsWith(' ')) 
                input = input.TrimStart();

            if (string.IsNullOrEmpty(input))
                return 0;

            if (input.Length == 1 && (input[0] == '+' || input[0] == '-'))
                return 0;

            var sb = new StringBuilder();
      
            char startChar =  input[0] == '-' ? input[0] : '+' ;
            sb.Append(startChar);
            int startIndex = input[0] == '+' || input[0] == '-' ? 1 : 0;
            

            for(int i = startIndex; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                    break;
                sb.Append(input[i]);
            }

            var result = GetResult(sb.ToString());

            if (result > int.MaxValue)
                return int.MaxValue;
            else if (result < int.MinValue)
                return int.MinValue;
            else
                return (int)result;
          
        }

        private static BigInteger GetResult(string input)
        {
            if (input.Length == 1 && (input[0] == '+' || input[0] == '-'))
                return 0;
           

            return BigInteger.Parse(input); //Int64.Parse(input);
        }
    }
}
