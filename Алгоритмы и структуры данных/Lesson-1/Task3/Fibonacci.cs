using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Fibonacci
    {
        public int GetRecursively(int n)
        {
            if (n < 0)
                throw new ArithmeticException("Число должно быть неотрицательным");

            if (n < 2)
                return n;
            else
                return GetRecursively(n - 1) + GetRecursively(n - 2);
        }

        public int GetCyclically(int n)
        {
            if (n < 0)
                throw new ArithmeticException("Число должно быть неотрицательным");

            if (n < 2)
                return n;

            int n1 = 0, n2 = 1, result = 0;
            for (int i = 0; i < n - 1; i++)
            {
                result = n1 + n2;
                n1 = n2;
                n2 = result;
            }
            return result;
        }
    }
}
