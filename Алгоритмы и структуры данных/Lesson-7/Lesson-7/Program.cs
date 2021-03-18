using System;

namespace Lesson_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = 64;
            int M = 100;
            int countPath = CountPath(M, N);            
            Console.WriteLine(countPath);
            
            Console.ReadKey();
        }

        public static int CountPath(int M, int N)
        {
            if (M <= 0 || N <= 0)
                throw new ArgumentException();
            
            if (M == 1)
                return 1;
            if (N == 1)
                return 1;

            return CountPath(M, N - 1) + CountPath(M - 1, N);
        }
    }    
}
