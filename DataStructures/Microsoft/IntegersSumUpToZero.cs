using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class IntegersSumUpToZero
    {
        public int[] SumZero(int n)
        {
            bool isOdd = false; ;
            var result = new HashSet<int>();
            var random = new Random();

            if(n % 2 != 0){
                isOdd = true;
                n  -= 1;
            }
          
            while(result.Count != n)
            {
                int number = random.Next(1, 100000);

                if(!result.Contains(number))
                {
                    result.Add(number);
                    result.Add(number * -1);
                }           
            }

            if (isOdd)
                result.Add(0);

            return result.ToArray();
        }
    }
}
