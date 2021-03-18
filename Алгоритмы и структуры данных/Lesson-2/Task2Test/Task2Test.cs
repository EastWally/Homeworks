using System;
using Xunit;
using Task2;
using System.Collections.Generic;

namespace Task2Test
{
    public class Task2Test
    {
        [Fact]
        public void BinarySearch_Contains()
        {
            // Arrange
            List<int> array = new List<int>() { 3, 1, 5, 34, 43, 35, 37, 46, 62, 85, 100, 77 };
            array.Sort();

            // Act
            var result = Program.BinarySearch(array, 43);
            // Assert
            Assert.Equal(6, result);

            // Act
            result = Program.BinarySearch(array, 77);
            // Assert
            Assert.Equal(9, result);

            // Act
            result = Program.BinarySearch(array, 1);
            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void BinarySearch_NotContains()
        {
            // Arrange
            List<int> array = new List<int>() { 1, 3, 5, 34, 35, 37, 43, 46, 62, 77, 85, 100 };
            
            var result = Program.BinarySearch(array, 50);
            // Assert
            Assert.Equal(-1, result);

            // Act
            result = Program.BinarySearch(array, 0);
            // Assert
            Assert.Equal(-1, result);

            // Act
            result = Program.BinarySearch(array, -10);
            // Assert
            Assert.Equal(-1, result);
        }


    }
}
