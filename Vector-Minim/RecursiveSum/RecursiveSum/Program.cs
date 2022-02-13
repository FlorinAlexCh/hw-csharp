using System;

namespace RecursiveSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 3, 6, 8, 9, 5};
            int n = array.Length;
            int result = SumOfArray.CalculateSum(array, n);

            Console.WriteLine("The result is: " + result);
        }
    }
}
