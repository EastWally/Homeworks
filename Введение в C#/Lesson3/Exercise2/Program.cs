using System;

namespace Exercise2
{
    class Program
    {
        /*
         Добавить 3 записи в телефонную книгу.
         Предложить пользователю добавить запись.
         Добавлять записи по кругу. Если достигнут конец массива, обнулить номер текущей строки и обновлять строки начиная с нулевой.
         */
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2] { { "Пупкин", "+7-777-876-45-21/pupkin@mail.ru" },{ "Фёдор Конюхов", "+7-777-456-22-33/konuhov@mail.ru" }, { "-", "-/-" },{ "-", "-/-" },{ "-", "-/-" } };
            phoneBook[2, 0] = "Пётр";
            phoneBook[2, 1] = "+7-777-435-67-58/piter@mail.ru";           

            int currentRow = 3;             
            ShowPhoneBook(phoneBook);
            do
            {  
                Console.Write("Добавить новую запись(y/n)?");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                if (key.KeyChar == 'y' || key.KeyChar == 'н')
                {
                    Console.Write("Введите имя: ");
                    phoneBook[currentRow, 0] = Console.ReadLine();
                    Console.Write("Введите номер телефона: ");
                    string phone = Console.ReadLine();
                    Console.Write("Введите email: ");
                    string email = Console.ReadLine();
                    phoneBook[currentRow, 1] = phone + "/" + email;
                    Console.WriteLine();

                    if (currentRow == 4)                    
                        currentRow = 0;                    
                    else                   
                        currentRow++;                    

                    ShowPhoneBook(phoneBook);
                }
                else
                    return;
            } while (true);
            Console.ReadKey();
        }

        static void ShowPhoneBook(string[,] phoneBook)
        {
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.WriteLine($"{phoneBook[i,0]} {phoneBook[i,1]}");
            }
            Console.WriteLine();
        }
    }
}
