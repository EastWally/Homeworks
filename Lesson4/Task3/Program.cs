using System;

namespace Task3
{
    class Program
    {
        enum Season
        { 
            Spring = 3,
            Summer = 6,
            Autumn = 9,
            Winter = 12
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 12)
                {
                    Console.WriteLine(GetRuNameOfSeason(GetSeason(number)));
                    Console.ReadKey();
                    return;
                }
                Console.Write("Ошибка: введите число от 1 до 12: ");
            }
        }

        static Season GetSeason(int number)
        {
            Season curSeason;
            if (number < (int)Season.Spring || number == (int)Season.Winter)
                curSeason = Season.Winter;
            else if (number >= (int)Season.Spring && number < (int)Season.Summer)
                curSeason = Season.Spring;
            else if (number >= (int)Season.Summer && number < (int)Season.Autumn)
                curSeason = Season.Summer;
            else
                curSeason = Season.Autumn;

            return curSeason;
        }

        static string GetRuNameOfSeason(Season selectedSeason)
        {
            string nameSeason;
            switch (selectedSeason)
            {
                case Season.Winter:
                    nameSeason = "Зима";
                    break;
                case Season.Spring:
                    nameSeason = "Весна";
                    break;
                case Season.Summer:
                    nameSeason = "Лето";
                    break;
                case Season.Autumn:
                    nameSeason = "Осень";
                    break;
                default:
                    nameSeason = "Сезон не определён";
                    break;
            }

            return nameSeason;
        }
    }
}
