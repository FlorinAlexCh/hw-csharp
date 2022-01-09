using System;
using System.Linq;

namespace Probleme_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Elementul maxim intr-un array 
            int maxNumber = array.Max();
            Console.WriteLine($"Max number of this array is: {maxNumber}");

            // Elementul minim intr-un array
            int minNumber = array.Min();
            Console.WriteLine($"Max number of this array is: {minNumber}");

            // Display the Index from a specific number
            Console.WriteLine("Please write a number from 1 to 7");
            var item = Console.ReadLine();
            int item1 = Int32.Parse(item);
            var index1 = Array.IndexOf(array, item1);
            Console.WriteLine("Your number can be found at index " + index1);

            // Media aritmetica

            double average = array.Average();
            Console.WriteLine($"The average is {average}");
        }

    }
}
