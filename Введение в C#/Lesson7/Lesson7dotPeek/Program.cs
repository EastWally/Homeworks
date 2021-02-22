// Decompiled with JetBrains decompiler
// Type: Lesson7.Program
// Assembly: Lesson7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C5A197C-FDEA-4CD7-AD22-034A33D0FF69
// Assembly location: E:\Geekbrains\Homeworks\Lesson7\Lesson7\bin\Debug\Lesson7.exe

using System;

namespace Lesson7
{
  internal class Program
  {
       private static void Main(string[] args)
       {
            Console.Write("Введите первое число: ");
            int result1;
            bool flag1 = int.TryParse(Console.ReadLine(), out result1);
            Console.Write("Введите второе число: ");
            int result2;
            bool flag2 = int.TryParse(Console.ReadLine(), out result2);
            if (flag1 & flag2)
            Console.WriteLine(string.Format("{0} + {1} = {2}", (object) result1, (object) result2, (object) Program.sum(result1, result2)));
            Console.WriteLine($"{result1} * {result2} = {mult(result1, result2)}");
            Console.ReadKey();
       }

        private static int sum(int a, int b) => a + b;
        private static int mult(int a, int b)
        {
            return a * b;
        }
  }
}
