using System;

namespace Fibonacci
{
    class Program
    {
        private static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int aux = a;
                a = b;
                b = aux + b;
            }
            return a;
        }

        static void Main()
        {
            Console.Write("Adauga lungimea sirului: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Rezultatul de la {input} este ", input);
            for (int i = 0; i < input; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
        }
    }
}
