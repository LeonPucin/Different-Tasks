using System;

namespace DistanceTask
{
    public static class DistanceTask
    {
        // Distance from point (x, y) to segment AB with coordinates A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double distance = GetDistanceFromStraight(ax, ay, bx, by, x, y);

            double distanceToPointA = GetDistanceFromPointToPoint(ax, ay, x, y);
            double distanceToPointB = GetDistanceFromPointToPoint(bx, by, x, y);

            double vectorABX, vectorABY, vectorPointX, vectorPointY;

            if (distanceToPointB < distanceToPointA)
            {
                MakeVector(out vectorABX, out vectorABY, ax, ay, bx, by);
                MakeVector(out vectorPointX, out vectorPointY, x, y, bx, by);
            }
            else
            {
                MakeVector(out vectorABX, out vectorABY, bx, by, ax, ay);
                MakeVector(out vectorPointX, out vectorPointY, x, y, ax, ay);
            }

            if (GetScalarMultiplier(vectorABX, vectorABY, vectorPointX, vectorPointY) <= 0)
                return Math.Min(distanceToPointA, distanceToPointB);

            return distance;
        }

        public static void MakeVector(out double vecX, out double vecY, double x1, double y1, double x2, double y2)
        {
            vecX = x1 - x2;
            vecY = y1 - y2;
        }

        public static double GetScalarMultiplier(double x1, double y1, double x2, double y2)
        {
            return x1 * x2 + y1 * y2;
        }

        public static double GetDistanceFromStraight(double ax, double ay, double bx, double by, double x, double y)
        {
            double coeffA = ay - by;
            double coeffB = bx - ax;
            double coeffC = ax * by - bx * ay;

            return Math.Abs(coeffA * x + coeffB * y + coeffC) / Math.Sqrt(coeffA * coeffA + coeffB * coeffB);
        }

        public static double GetDistanceFromPointToPoint(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
    }
}