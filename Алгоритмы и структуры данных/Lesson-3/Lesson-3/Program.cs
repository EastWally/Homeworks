using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson_3
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
        PointClass pointClassOne = new PointClass() { X = 10, Y = 30 };
        PointClass pointClassTwo = new PointClass() { X = 5, Y = 90 };
        PointStruct pointStructOne = new PointStruct() { X = 10, Y = 30 };
        PointStruct pointStructTwo = new PointStruct() { X = 5, Y = 90 };


        [Benchmark]
        public void Test_PointDistance_ClassFloat()
        {
            PointClass.PointDistance(pointClassOne, pointClassTwo);
        }

        [Benchmark]
        public void Test_PointDistance_StructFloat()
        {
            PointStruct.PointDistance(pointStructOne, pointStructTwo);
        }

        [Benchmark]
        public void Test_PointDistance_StructDouble()
        {
            PointStruct.PointDistanceDouble(pointStructOne, pointStructTwo);
        }

        [Benchmark]
        public void Test_PointDistance_StructShort()
        {
            PointStruct.PointDistanceShort(pointStructOne, pointStructTwo);
        }

    }
}
