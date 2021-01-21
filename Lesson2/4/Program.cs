using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string storeName = "ООО \"Вкусвилл\"";
            string tin = "7734675810";
            string address = "117031, г. Москва, ул. Адмирала Лазарева, д.63";
            int shift = 412;
            int receiptNumber = 5;
            DateTime date = new DateTime(2021, 1, 21, 11, 41, 0);
            string cashier = "Муравьева Анастасия Васильевна";

            (string title, double price, double quantity, double vat)[] purchases = {
            ("Масло оливковое, шт", 448.00, 1, 0.1),
            ("Молоко цельное, шт", 58.00, 1, 0.1),
            ("Гель для мытья посуды, шт", 116.00, 1, 0.2),
            ("Яблоко карамелька, кг", 115.00, 0.736, 0.1)
            };

            //Итоговая сумма
            double result = 0.0;

            Console.WriteLine($"{storeName, 52}");
            Console.WriteLine($"{"",-38}ИНН {tin}");
            Console.WriteLine($"{"",-40}Магазин");
            Console.WriteLine($"{address, 70}");
            Console.WriteLine($"{"",-35}Кассовый чек. Приход");
            Console.WriteLine($"Смена: {shift}");
            Console.WriteLine($"Чек №: {receiptNumber} {"",42} Кассир: {cashier}");
            Console.WriteLine($"{date}");
            Console.WriteLine(("").PadRight(90,'-'));
            
            Console.WriteLine($"№{"",-5}{"Наименование",-43}{"Цена за ед.",-19}{"Кол.", -17}Сумма\n");
            for (int i = 0; i < purchases.Length; i++)
            {
                double sum = purchases[i].quantity * purchases[i].price; //Стоимость позиции
                Console.WriteLine($"{i+1}. {purchases[i].title,-43}{purchases[i].price, 10:f2}{purchases[i].quantity, 16:f3}{sum,18:f2}");
                Console.WriteLine($"{"",-5}Товар");
                Console.WriteLine($"{"",-5}Полный расчет");
                Console.WriteLine($"{"",-5}НДС {purchases[i].vat:p0}{purchases[i].vat*sum,78:f2}");
                result += sum;
            }

            Console.WriteLine(("").PadRight(90, '-'));
            Console.WriteLine($"Итого{result,85:f2}");
            Console.WriteLine(("").PadRight(90, '-'));

            Console.ReadKey();
        }
    }
}
