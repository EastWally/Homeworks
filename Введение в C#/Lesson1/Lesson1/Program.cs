using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Today.ToLongDateString()}");
            Console.ReadKey();
        }
    }
}
