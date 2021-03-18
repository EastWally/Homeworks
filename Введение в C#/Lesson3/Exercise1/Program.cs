using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] 
                { { 11, 12, 13, 14, 15 }, 
                { 21, 22, 23, 24, 25 }, 
                { 31, 32, 33, 34, 35 }, 
                { 41, 42, 43, 44, 45 }, 
                { 51, 52, 53, 54, 55 }};

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i >= array.GetLength(1))
                    break;

                char[] step = new char[i];
                for (int k = 0; k < i; k++)
                {
                    step[k] = '\t';
                }
                Console.WriteLine($"{new string(step)}{array[i,i]}");                
            }
            Console.ReadKey();
        }
    }
}
