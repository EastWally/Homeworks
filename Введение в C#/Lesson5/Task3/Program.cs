using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите набор чисел от 0 до 255, разделенных пробелом: ");
            string[] inputArray = Console.ReadLine().Split(' ');
            if (inputArray != null)
            {
                byte[] byteArray = new byte[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    byte.TryParse(inputArray[i], out byteArray[i]);
                }

                string fileName = "Bytes.bin";
                File.WriteAllBytes(fileName, byteArray);
                Console.WriteLine($"Данные сохранены в файл {fileName}");
            }
            Console.ReadKey();
        }
    }
}
