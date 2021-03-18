using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер текущего месяца: ");
            string inputMonth = Console.ReadLine();   
            Console.Write("Введите среднюю температуру: ");
            string inputTemp = Console.ReadLine().Replace('.', ',');

            bool isValidMonth = int.TryParse(inputMonth, out int monthNumber);
            isValidMonth = isValidMonth || (monthNumber < 1 || monthNumber > 12);
            bool isValidTemp = float.TryParse(inputTemp, out float averageTemp);

            if (!isValidMonth || !isValidTemp)
            {
                Console.WriteLine("Введены некорректные данные.");
                Console.ReadKey();
                return;
            }

            bool isWinterMonth = (monthNumber == 12) || (monthNumber == 1) || (monthNumber == 2);
            if (isWinterMonth && averageTemp > 0)
            {
                Console.WriteLine("Дождливая зима.");                
            }
            Console.ReadKey();
        }
    }
}
