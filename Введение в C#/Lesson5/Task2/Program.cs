using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentTime = DateTime.Now.ToLongTimeString() + "\n";
            File.AppendAllText("startup.txt", currentTime);
            Console.Write($"Текущее время: {currentTime}");
            Console.ReadKey();
        }
    }
}
