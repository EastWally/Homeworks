using System;
using System.Collections.Generic;
using Xunit;
using Task1;

namespace TestProject
{
    public class Task1Test
    {
        [Fact]
        public void Bucketsort_Test()
        {
            int[] array = new int[] { 10, 6, 4, 7, 16, 90, 45, 24, 67};
            int[] expected = new int[] { 4, 6, 7, 10, 16, 24, 45, 67, 90 };
            int[] fact = Program.Bucketsort(array, 90);
            Assert.Equal(expected, fact);
        }

        [Fact]
        public void Bucketsort_ArraySort_Test()
        {
            var array = new int[100];
            int maxElement = array.Length * 5;
            for (int i = 0; i < array.Length; i++)            
                array[i] = new Random().Next(0, maxElement);
            
            int[] expected = new int[array.Length];
            Array.Copy(array, expected, array.Length);
            Array.Sort(expected);

            int[] fact = Program.Bucketsort(array, maxElement);
            Assert.Equal(expected, fact);
        }

        [Fact]
        public void Bucketsort_Negative_Test()
        {
            int[] array = new int[] { 10, 6, 4, 7, -16, 90, 45, 24, 67 };

            Assert.Throws<ArgumentOutOfRangeException>(() => Program.Bucketsort(array, 90));
        }
    }
}
