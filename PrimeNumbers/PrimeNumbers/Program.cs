using System;

namespace PrimeNumbers
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Diplay all prime numbers until:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}