using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();
            char[] outputValue = new char[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                outputValue[inputString.Length - 1 - i] = inputString[i];
            }
            Console.WriteLine(outputValue);
            Console.ReadKey();
        }
    }
}
