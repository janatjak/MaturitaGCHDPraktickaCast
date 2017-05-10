using System;

namespace Maturita._12_Analytics
{
    public class PointMethods
    {
        public double GetDistance(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) ^ 2 + (a.Y - b.Y) ^ 2);
        }

        public Point GetMiddle(Point a, Point b)
        {
            return GetPointsAvarage(new[] {a, b});
        }

        public Point GetTriangleHelix(Point a, Point b, Point c)
        {
            return GetPointsAvarage(new[] {a, b, c});
        }

        // Teznice ? jak se sakra rekne teznice...
        public double GetTriangleMedianLenght(Point origin, Point b, Point c)
        {
            return GetDistance(origin, GetMiddle(b, c));
        }

        /// <summary>
        /// Points must be ordered
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public double GetCircuit(Point[] points)
        {
            var circuit = (double) 0;
            for (var i = 0; i < points.Length - 1; i++)
            {
                circuit += GetDistance(points[i], points[i + 1]);
            }
            return circuit;
        }

        public Point GetPointsAvarage(Point[] points)
        {
            var sumX = 0;
            var sumY = 0;

            foreach (var point in points)
            {
                sumX += point.X;
                sumY += point.Y;
            }

            return new Point {X = sumX / points.Length, Y = sumY / points.Length};
        }
    }
}