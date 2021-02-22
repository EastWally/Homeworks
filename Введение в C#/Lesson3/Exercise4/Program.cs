using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array = new char[,]
                { { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                  { 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X', 'X', 'O' },
                  { 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O' },
                  { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                  { 'X', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                  { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'O' },
                  { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O' },
                  { 'O', 'X', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O' },
                  { 'O', 'X', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O' },
                  { 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'X', 'X' }};

            Console.WriteLine($"   A B C D E F G H I J");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{i + 1,-3}");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    var tmpBackGroud = Console.BackgroundColor;
                    if (array[i, j] == 'X')
                        Console.BackgroundColor = ConsoleColor.Green;
                    else
                        Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write($"{array[i,j]} ");
                    Console.BackgroundColor = tmpBackGroud;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
