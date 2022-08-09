using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Numerics;

namespace MicrosoftInterview
{
    public class RemoveDigitToMaximizeResult
    {
      public static string RemoveDigit(string number, char digit)
        {
            BigInteger result = -1;

            for (int  i = 0;  i < number.Length;  i++)
            {
                if (number[i] == digit)
                {
                    BigInteger current = BuildNumber(number, i);
                    result = current > result ? current : result;

                    //Math.Max()
                }
            }

            return result.ToString();
        }

        private static BigInteger BuildNumber(string number, int index)
        {
            
            var sb = new StringBuilder(number);
            sb.Remove(index, 1);
            return BigInteger.Parse(sb.ToString());
           // return Util.ConvertToBigInteger(sb.ToString());
            
        }
    }
}
