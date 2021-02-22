using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за сутки: ");
            string minTempStr = Console.ReadLine().Replace('.', ',');
            Console.Write("Введите максимальную температуру за сутки: ");
            string maxTempStr = Console.ReadLine().Replace('.', ',');

            bool isValidMinTemp = float.TryParse(minTempStr, out float minTemp);
            bool isValidMaxTemp = float.TryParse(maxTempStr, out float maxTemp);

            if (isValidMinTemp && isValidMaxTemp)
            {
                Console.WriteLine($"Среднесуточная температура равна {(minTemp + maxTemp) / 2.0f:f2}");
            }
            else if (!isValidMinTemp)
            {
                Console.WriteLine("Введено некорректное значение минимальной температуры. Невозможно вычислить среднесуточную температуру.");
            }
            else if (!isValidMaxTemp)
            {
                Console.WriteLine("Введено некорректное значение максимальной температуры. Невозможно вычислить среднесуточную температуру.");
            }
            Console.ReadKey();
        }
    }
}
