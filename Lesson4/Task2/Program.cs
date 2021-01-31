using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите набор чисел, разделённых пробелом:");
            string[] inputString = Console.ReadLine().Replace('.',',').Split(' ');
            double sum = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (double.TryParse(inputString[i], out double number))
                    sum += number;
            }
            Console.WriteLine($"Сумма введёных чисел равна {sum}");
            Console.ReadKey();
        }
    }
}
