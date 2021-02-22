using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Александр", "Пушкин", "Сергеевич"));
            Console.WriteLine(GetFullName("Лев", "Толстой", "Николаевич"));
            Console.WriteLine(GetFullName("Фёдор", "Достоевский", "Михайлович"));
            Console.WriteLine(GetFullName("Михаил", "Лермонтов", "Юрьевич"));
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}
