using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int fibonacci = 0;
                if (number == 1)
                    fibonacci = 1;
                if (number >= 2)
                    fibonacci = GetFibonacci(number);
                Console.WriteLine($"Число Фибоначчи для {number} = {fibonacci}");
            }
            else
                Console.WriteLine("Для введённого значения невозможно получить число Фибоначчи.");
            Console.ReadKey();
        }

        static int GetFibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            return GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
