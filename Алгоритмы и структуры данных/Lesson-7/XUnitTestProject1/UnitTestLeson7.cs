using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTestLeson7
    {
        [Fact]
        public void CountPath_Test_0_0()
        {
            int M = 0;
            int N = 0;
            Assert.Throws<ArgumentException>(() => Lesson_7.Program.CountPath(M, N));
        }

        [Fact]
        public void CountPath_Test_1_1()
        {
            int M = 1;
            int N = 1;
            int actual = Lesson_7.Program.CountPath(M, N);
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPath_Test_2_2()
        {
            int M = 2;
            int N = 2;
            int actual = Lesson_7.Program.CountPath(M, N);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPath_Test_2_3()
        {
            int M = 2;
            int N = 3;
            int actual = Lesson_7.Program.CountPath(M, N);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPath_Test_4_4()
        {
            int M = 4;
            int N = 4;
            int actual = Lesson_7.Program.CountPath(M, N);
            int expected = 20;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountPath_Test_6_5()
        {
            int M = 6;
            int N = 5;
            int actual = Lesson_7.Program.CountPath(M, N);
            int expected = 126;
            Assert.Equal(expected, actual);
        }
    }
}
