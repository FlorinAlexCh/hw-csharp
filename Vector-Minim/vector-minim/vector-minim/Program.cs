using System;


namespace vector_minim
{ 
    class Program
    {
        static void Main(string[] args)
        {
        int[] array = { 21, 25, 13, 16, 116 };
        
        int min = Recursive.Min(array, 1, array[0]);
        Console.WriteLine($"The minimum value is = {min}"); 
    }
    }
}
