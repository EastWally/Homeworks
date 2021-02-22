using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class SimpleNumber
    {
        public string IsNumberSimple(int n)
        {
            int d = 0, i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }            
            if (d == 0)
                return "Простое";
            else
                return "Не простое";            
        }
    }
}
