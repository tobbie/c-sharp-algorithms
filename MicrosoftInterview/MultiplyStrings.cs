using System.Numerics;

namespace MicrosoftInterview
{
    public class MultiplyStrings
    {
        private Dictionary<char, int> NumberMapping { get; set; }

        public MultiplyStrings()
        {
            NumberMapping = new Dictionary<char, int>();
            NumberMapping.Add('0', 0);
            NumberMapping.Add('1', 1);
            NumberMapping.Add('2', 2);
            NumberMapping.Add('3', 3);
            NumberMapping.Add('4', 4);
            NumberMapping.Add('5', 5);
            NumberMapping.Add('6', 6);
            NumberMapping.Add('7', 7);
            NumberMapping.Add('8', 8);
            NumberMapping.Add('9', 9);

        }

        public string Multiply(string num1, string num2) => (Convert(num1) * Convert(num2)).ToString();            
        private  BigInteger Convert(string input)
        {
            BigInteger currentNumber = 0;
            for (int i = 0; i < input.Length; i++)
            {
                currentNumber = currentNumber * 10 + NumberMapping[input[i]];
            }
            return currentNumber;
        }
    }
}
