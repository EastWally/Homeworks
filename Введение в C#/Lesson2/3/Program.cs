using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            string inputValue = Console.ReadLine();
            bool isValid = int.TryParse(inputValue, out int number);

            if (!isValid)
            {
                Console.WriteLine("Введено некорректное число.");
                Console.ReadKey();
                return;
            }

            if ((number % 2) == 0)
            {
                Console.WriteLine($"{number} - чётное число.");
            }
            else
            {
                Console.WriteLine($"{number} не является чётным числом.");
            }

            Console.ReadKey();
        }
    }
}
