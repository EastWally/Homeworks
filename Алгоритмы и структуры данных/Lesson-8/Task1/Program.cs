using System;
using System.Collections.Generic;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = new int[50];
            int maxElement = array.Length * 5;
            int minElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(minElement, maxElement);
            }
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)            
                Console.Write($"[{array[i]}] ");
            Console.WriteLine("\n");
            array = Bucketsort(array, maxElement);
            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write($"[{array[i]}] ");
            Console.ReadKey();
        }

        public static int[] Bucketsort(int[] array, int maxElement)
        {
            //Создаем блоки
            int countBlocks = 10;
            int blockSize = maxElement / countBlocks;
            var blocks = new List<List<int>>();
            for (int i = 0; i < countBlocks; i++)
                blocks.Add(new List<int>());

            //Распределяем элементы по блокам
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j <= countBlocks; j++)
                {
                    if (array[i] < 0) throw new ArgumentOutOfRangeException("Метод поддерживает только сортировку неотрицательных чисел");
                    if (array[i] > (j - 1) * blockSize && array[i] <= j * blockSize)
                    {
                        blocks[j - 1].Add(array[i]);
                        break;
                    }
                }
            }

            //Сортируем блоки
            for (int i = 0; i < countBlocks; i++)
            {
                if (blocks[i].Count > 1)
                    blocks[i] = QuickSort(blocks[i], 0, blocks[i].Count - 1);
            }

            //Собираем элементы блоков в исходный массив
            int k = 0;
            for (int i = 0; i < countBlocks; i++)
            {
                for (int j = 0; j < blocks[i].Count; j++)
                {
                    array[k++] = blocks[i][j];
                }
            }
            return array;
        }


        static List<int> QuickSort(List<int> array, int first, int last)
        {
            int i = first;
            int j = last;
            int x = array[(first + last) / 2];

            do
            {
                while (array[i] < x)
                    i++;
                while (array[j] > x)
                    j--;

                if (i <= j)
                {
                    if(array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }

                    i++;
                    j--;
                }
            } while (i <= j);

            if (i < last)
                QuickSort(array, i, last);
            if (first < j)
                QuickSort(array, first, j);

            return array;
        }
    }
}
