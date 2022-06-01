using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Meduim
{
    public class ValidIPAddresses
    {
      // O(1) time and O(1) space , ip address occupy 32bits, 4, * bit values alwaays
        public static List<string> Generate(string str)
        {
            var ipAddresses = new List<string>();

            for (int i = 1; i < Math.Min(str.Length , 4); i++)
            {
                var currentIpParts = new string[] { "", "", "", "" };
                currentIpParts[0] = str[..i];

                if (!IsValidIP(currentIpParts[0]))
                    continue;

                for (int j = i + 1; j <  i + Math.Min(str.Length - i, 4); j++)
                {
                    currentIpParts[1] = str[i..j];

                    if (!IsValidIP(currentIpParts[1]))
                        continue;

                    for (int k = j + 1; k < j + Math.Min(str.Length - j, 4); k++)
                    {
                        currentIpParts[2] = str[j..k];
                        currentIpParts[3] = str[k..];

                        if (IsValidIP(currentIpParts[2]) && IsValidIP(currentIpParts[3]))
                            ipAddresses.Add(string.Join('.', currentIpParts));


                    }
                }
            }

            return ipAddresses;
        }

        private static bool IsValidIP(string value)
        {
            // "000", "00", "01", "12"
            int integerValue = Convert.ToInt32(value);
            if (integerValue > 255)
                return false;

            return value.Length == integerValue.ToString().Length;
        }
    }
}
