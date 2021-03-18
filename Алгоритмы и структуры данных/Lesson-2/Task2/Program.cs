using System;
using System.Collections.Generic;

namespace Task2
{
    public class Program
    {
        static void Main()
        {
            Console.ReadKey();
        }

        public static int BinarySearch(List<int> inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Count - 1;

            /* Каждую интерацию цикла количество операций поиска делится пополам.
             * Для N=8: 4-2-1
             * Для N=40: 20-10-5-3-1
             * Для N=100: 50-25-12-6-3-1
             * O(N) = lоg2(N)
              */
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
