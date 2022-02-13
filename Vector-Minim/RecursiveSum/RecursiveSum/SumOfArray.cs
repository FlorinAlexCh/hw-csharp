using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSum
{
     public static class SumOfArray
    {
        public static int CalculateSum(int[] array, int n)
        {
            if (n <= 0 || n > array.Length)
            {
                return 0;
            }
            else
            {
                return CalculateSum(array, n - 1) + array[n - 1];
            }
        }
    }
}
