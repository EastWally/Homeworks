using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            bool isFirstNumber = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("\nВведите второе число: ");
            bool isSecondNumber = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (isFirstNumber && isSecondNumber)
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {sum(firstNumber, secondNumber)}");
            }
            Console.ReadKey();
        }

        static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
