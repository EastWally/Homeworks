using System;
using System.Collections.Generic;
using Xunit;
using Task3;

namespace Task3Tests
{
    public class FibonacciTest
    {
        [Fact]
        public void GetRecursively_Positive()
        {
            // Arrange
            Dictionary<int, int> number = new Dictionary<int, int> { { 0, 0 }, { 1, 1 }, { 2, 1 }, { 3, 2 }, { 4, 3 }, { 6, 8 }, { 10, 55 }, { 14, 377 } };
            Fibonacci fibonacci = new Fibonacci();
            // Act
            foreach (var n in number)
            {
                int result = fibonacci.GetRecursively(n.Key);
                // Assert
                Assert.Equal(n.Value, result);
            }
        }

        [Fact]
        public void GetRecursively_Negative()
        {
            // Arrange
            int number = -1;
            Fibonacci fibonacci = new Fibonacci();
            // Assert
            Assert.Throws<ArithmeticException>(()=>fibonacci.GetRecursively(number));            
        }


        [Fact]
        public void Get—yclically_Positive()
        {
            // Arrange
            Dictionary<int, int> number = new Dictionary<int, int> { { 0, 0 }, { 1, 1 }, { 2, 1}, { 3, 2 }, { 4, 3 }, { 6, 8 }, { 10, 55 }, { 14, 377 } };
            Fibonacci fibonacci = new Fibonacci();
            // Act
            foreach(var n in number)
            {
                int result = fibonacci.Get—yclically(n.Key);
                // Assert
                Assert.Equal(n.Value, result);
            }
        }

        [Fact]
        public void Get—yclically_Negative()
        {
            // Arrange
            int number = -1;
            Fibonacci fibonacci = new Fibonacci();
            // Assert
            Assert.Throws<ArithmeticException>(() => fibonacci.Get—yclically(number));
        }
    }
}
