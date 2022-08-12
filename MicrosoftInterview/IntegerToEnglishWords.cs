
using static System.Math;

namespace MicrosoftInterview
{
  public class IntegerToEnglishWords
    {
        public  string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";

            string[] OneTo19 = new string[] {"One", "Two", "Three","Four", "Five", "Six",
                 "Seven", "Eight", "Nine", "Ten", "Eleven","Twelve","Thirteen", "Fourteen",
                  "Fifteeen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

            var Tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            //1 billion = 10^9, 1 million = 10^6, 1 thousand = 10^3, 1 hundred = 10 ^ 2

            string Recursor(int num)
            {
                if (num == 0)
                    return "";

                if (num <= 19)
                    return OneTo19[num - 1];

                if (num <= 99)
                    return (Tens[num / 10 - 2] + " " + Recursor(num % 10)).Trim();

                if (num <= 999)
                    return (Recursor(num / 100) + " Hundred " + Recursor(num % 100)).Trim();

                if (num <= Pow(10, 6) - 1)
                    return (Recursor(num / 1000) + " Thousand " + Recursor(num % 1000)).Trim();

                if (num <= Pow(10, 9) - 1)
                    return (Recursor(num / (int)Pow(10, 6)) + " Million " + Recursor(num % (int)Pow(10, 6))).Trim();
                else
                    return (Recursor(num / (int)Pow(10, 9)) + " Billion " + Recursor(num % (int)Pow(10, 9))).Trim();

                
            }

            return Recursor(num);
        }
    }
}
