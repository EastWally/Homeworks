using System;

namespace _6
{
    class Program
    {
        [Flags]
        enum WorkingDays
        { 
            Понедельник = 0b_0000_0001,
            Вторник = 0b_0000_0010,
            Среда = 0b_0000_0100,
            Четверг = 0b_0000_1000,
            Пятница = 0b_0001_0000,
            Суббота = 0b_0010_0000,
            Воскресенье = 0b_0100_0000
        }
        static void Main(string[] args)
        {
            WorkingDays mainOffice = (WorkingDays)0b0111_1111;
            WorkingDays additionalOffice_1 = WorkingDays.Понедельник | WorkingDays.Вторник | WorkingDays.Среда | WorkingDays.Четверг;
            WorkingDays additionalOffice_2 = WorkingDays.Пятница | WorkingDays.Суббота | WorkingDays.Воскресенье | WorkingDays.Понедельник;

            Console.Write("Введите m, если хотите увидеть график работы главного офиса.\n" +
                "Введите d1, если хотите увидеть график работы первого дополнительного офиса.\n" +
                "Введите d2, если хотите увидеть график работы второго дополнительного офиса.\n" +
                "Введите 1, если хотите увидеть список офисов, открытых в понедельник.\n" +
                "Введите 2, если хотите увидеть список офисов, открытых во вторник.\n" +
                "Введите 3, если хотите увидеть список офисов, открытых в среду.\n" +
                "Введите 4, если хотите увидеть список офисов, открытых в четверг.\n" +
                "Введите 5, если хотите увидеть список офисов, открытых в пятницу.\n" +
                "Введите 6, если хотите увидеть список офисов, открытых в субботу.\n" +
                "Введите 7, если хотите увидеть список офисов, открытых в воскресенье.\n");
            string inputKey = Console.ReadLine().ToLower();
            Console.WriteLine(("").PadRight(90, '-'));

            switch (inputKey)
            {
                case "m":
                    Console.WriteLine($"Главый офис открыт в {mainOffice}");
                    break;
                case "d1":
                    Console.WriteLine($"Дополнительный офис 1 открыт в {additionalOffice_1}");
                    break;
                case "d2":
                    Console.WriteLine($"Дополнительный офис 2 открыт в {additionalOffice_2}");
                    break;
                case "1":                    
                    Console.WriteLine($"{WorkingDays.Понедельник.ToString()} - рабочий день в {OpenedOffices(mainOffice, additionalOffice_1, additionalOffice_2, WorkingDays.Понедельник)}");
                    break;
                case "2":
                    Console.WriteLine($"{WorkingDays.Вторник.ToString()} - рабочий день в {OpenedOffices(mainOffice, additionalOffice_1, additionalOffice_2, WorkingDays.Вторник)}");
                    break;
                case "3":
                    Console.WriteLine($"{WorkingDays.Среда.ToString()} - рабочий день в {OpenedOffices(mainOffice, additionalOffice_1, additionalOffice_2, WorkingDays.Среда)}");
                    break;
                case "4":
                    Console.WriteLine($"{WorkingDays.Четверг.ToString()} - рабочий день в {OpenedOffices(mainOffice, additionalOffice_1, additionalOffice_2, WorkingDays.Четверг)}");
                    break;
                case "5":
                    Console.WriteLine($"{WorkingDays.Пятница.ToString()} - рабочий день в {OpenedOffices(mainOffice, additionalOffice_1, additionalOffice_2, WorkingDays.Пятница)}");
                    break;
                case "6":
                    Console.WriteLine($"{WorkingDays.Суббота.ToString()} - рабочий день в {OpenedOffices(mainOffice, additionalOffice_1, additionalOffice_2, WorkingDays.Суббота)}");
                    break;
                case "7":
                    Console.WriteLine($"{WorkingDays.Воскресенье.ToString()} - рабочий день в {OpenedOffices(mainOffice, additionalOffice_1, additionalOffice_2, WorkingDays.Воскресенье)}");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        //Вычислить офисы, открытые в день недели workingDay
        static string OpenedOffices(WorkingDays mainOffice, WorkingDays additionalOffice_1, WorkingDays additionalOffice_2, WorkingDays workingDay)
        {
            bool isMainOffice = (mainOffice & workingDay) != 0;
            bool isAdditionalOffice_1 = (additionalOffice_1 & workingDay) != 0;
            bool isAdditionalOffice_2 = (additionalOffice_2 & workingDay) != 0;
            string mainOfficesOpened = (isMainOffice ? "Главном офисе" : "");
            if (!string.IsNullOrEmpty(mainOfficesOpened))
                mainOfficesOpened += ((isAdditionalOffice_1 || isAdditionalOffice_2)?", ":"");
            string additionalOfficeOpened = (isAdditionalOffice_1 ? "Дополнительном офисе 1" : "");
            if (!string.IsNullOrEmpty(additionalOfficeOpened))
                additionalOfficeOpened += (isAdditionalOffice_2 ? ", " : "");
            return mainOfficesOpened + additionalOfficeOpened + (isAdditionalOffice_2 ? "Дополнительном офисе 2" : "");
        }
    }
}
