using System;
using Xunit;
using Task1;

namespace Task1Tests
{
    public class UnitTest
    {
        [Fact]
        public void IsNumberSimple_SimpleNumber()
        {
            // Arrange
            int[] number = new int[] { 1, 7, 13};
            SimpleNumber simpleNumber = new SimpleNumber();
            // Act
            for (int i = 0; i < number.Length; i++)
            {
                string result = simpleNumber.IsNumberSimple(number[i]);
                // Assert
                Assert.Equal("Простое", result);
            }
        }

        [Fact]
        public void IsNumberSimple_NotSimpleNumber()
        {
            // Arrange
            int[] number = new int[] { 4, 8, 20 };
            SimpleNumber simpleNumber = new SimpleNumber();
            // Act
            for (int i = 0; i < number.Length; i++)
            {
                string result = simpleNumber.IsNumberSimple(number[i]);
                // Assert
                Assert.Equal("Не простое", result);
            }
        }
    }
}
