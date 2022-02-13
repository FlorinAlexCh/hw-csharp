using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector_minim
{
    public static class Recursive
    {
        public static int Min(int[] array, int item, int min)
        {
            if (min > array[item])
                min = array[item];

            if (item == array.Length - 1)
                return min;
            else
                return Min(array, item + 1, min);
        }
    }
}
