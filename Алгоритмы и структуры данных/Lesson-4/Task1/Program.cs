using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadKey();
        }
    }

    public class BechmarkClass
    {
        HashSet<string> hashSetOfStrings = new HashSet<string>();
        string[] arrayOfStrings = new string[10_000];
        string searchString = "";

        public BechmarkClass()
        {
            GenerateArrays();
            searchString = GetRandomString();
        }

        public void GenerateArrays()
        {
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                string newString = $"{i} Generated String {(char)((i + 30) % 127)}";
                hashSetOfStrings.Add(newString);
                arrayOfStrings[i] = newString;
            }
        }

        public string GetRandomString()
        {
            int randomIndex = new Random().Next(0, arrayOfStrings.Length - 1);
            return arrayOfStrings[randomIndex];
        }


        [Benchmark]
        public bool Test_SearchInHash()
        {
            return hashSetOfStrings.Contains(searchString);
        }

        [Benchmark]
        public bool Test_SearchInArray()
        {
            bool found = false;
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                if (arrayOfStrings[i] == searchString)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }


    }
}
