using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите произвольные данные: ");
            string inputString = Console.ReadLine();
            string fileName = "SetOfData.txt";
            File.WriteAllText(fileName, inputString);
            Console.WriteLine($"Данные сохранены в файл {fileName}");
            Console.ReadKey();
        }
    }
}
