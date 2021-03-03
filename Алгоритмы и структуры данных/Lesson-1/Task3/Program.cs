using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            bool correct = int.TryParse(Console.ReadLine(), out int number);
            if (correct)
            {
                Console.WriteLine($"Фибоначчи рекурсивно: {new Fibonacci().GetRecursively(number)}");
                Console.WriteLine($"Фибоначчи в цикле: {new Fibonacci().GetCyclically(number)}");
            }
            Console.ReadKey();
        }
    }
}
