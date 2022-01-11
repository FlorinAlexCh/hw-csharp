using System;
using System.Linq;

namespace Sortare_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 4, 6, 8, 34, 7 };
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please write a number");
                 array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Scrie 1 pentru sortare ascendenta a array-ului sau 2 pentru sortare descendenta");
            var input = Console.ReadLine();
            int input1 = Int32.Parse(input);
            if (input1 == 1)
            {
                Array.Sort(array);
                foreach (int asc in array)
                {
                    Console.WriteLine(asc);
                }
            }
            else if (input1 == 2)
            {
                array = array.OrderByDescending(c => c).ToArray();
                foreach (int reverse in array)
                {
                    Console.WriteLine(reverse);
                }
            }
            else
            {
                Console.WriteLine("Numarul introdus nu e nici 1 nici 2, pierderea ta");
            }
        }
    }
}
