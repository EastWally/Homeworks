using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3
{
    public class PointClass
    {
        public int X;
        public int Y;

        public static float PointDistance(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
    }
}
