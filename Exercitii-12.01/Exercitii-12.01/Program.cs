using System;

namespace Exercitii_12._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ReadArray("Array");

            PrintArray("Array", array);

            if (array is null || array.Length ==0)
            {
                Console.WriteLine("Min cannot be calculate");
            }
            else
            {
                int min = array[0];
            }
        }
    }
}
