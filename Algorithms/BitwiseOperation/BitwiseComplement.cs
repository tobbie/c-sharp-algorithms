﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BitwiseOperation
{
    public static class BitwiseComplement
    {
        public static int GetComplement(int number)
        {
            int n = number;
            int bitCount = 0;

            while(n > 0)
            {
               bitCount += 1;
               n =  n >> 1; 
            }
            int all_bits_set = (int)Math.Pow(2, bitCount) - 1;
            return number ^ all_bits_set;
       }
    }
}
