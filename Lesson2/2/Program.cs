using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер текущего месяца: ");
            string inputMonth = Console.ReadLine();
            bool isValidMonth = int.TryParse(inputMonth, out int monthNumber);

            if (!isValidMonth || (monthNumber < 1 || monthNumber > 12))
            {
                Console.WriteLine("Введен некорректный номер месяца.");
                Console.ReadKey();
                return;
            }

            string currentMonth = "";
            switch (monthNumber)
            {
                case 1:
                    currentMonth = "Январь";
                    break;
                case 2:
                    currentMonth = "Февраль";
                    break;
                case 3:
                    currentMonth = "Март";
                    break;
                case 4:
                    currentMonth = "Апрель";
                    break;
                case 5:
                    currentMonth = "Май";
                    break;
                case 6:
                    currentMonth = "Июнь";
                    break;
                case 7:
                    currentMonth = "Июль";
                    break;
                case 8:
                    currentMonth = "Август";
                    break;
                case 9:
                    currentMonth = "Сентябрь";
                    break;
                case 10:
                    currentMonth = "Октябрь";
                    break;
                case 11:
                    currentMonth = "Ноябрь";
                    break;
                case 12:
                    currentMonth = "Декабрь";
                    break;
                default:
                    currentMonth = "Месяц с таким номером не существует";
                    break;
            }

            Console.WriteLine($"Текущий месяц: {currentMonth}");
            Console.ReadKey();
        }
    }
}
