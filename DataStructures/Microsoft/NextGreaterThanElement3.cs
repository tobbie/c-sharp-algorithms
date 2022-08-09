using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Microsoft
{
    public class NextGreaterThanElement3
    {
        public static int NextGreaterThan(int n)
        {
            var numberArray = n.ToString().ToCharArray();

            int index = numberArray.Length - 2;
            while (index >= 0 && numberArray[index] >= numberArray[index + 1])
                index--;

            if (index == -1)
                return -1;

            int jIndex = numberArray.Length - 1;
            while (jIndex > index && numberArray[jIndex] <= numberArray[index])
                jIndex--;

            Util.Swap(numberArray, index, jIndex);
            Util.Reverse(numberArray, index + 1, numberArray.Length - 1);

            long result = long.Parse(string.Join("", numberArray));

            return result > int.MaxValue ? -1 : (int)result;
        }


      
    }
}
