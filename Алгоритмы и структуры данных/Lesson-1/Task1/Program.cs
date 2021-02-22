using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            bool correct = int.TryParse(Console.ReadLine(), out int number);
            if (correct)
                Console.WriteLine(new SimpleNumber().IsNumberSimple(number));
            Console.ReadKey();
        }
        
    }
}
