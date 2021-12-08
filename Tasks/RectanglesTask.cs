using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        // Whether two rectangles intersect (crossing only along the border is also considered an intersection)
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            if ((((r1.Left >= r2.Left) && (r1.Left <= r2.Right))
                || ((r1.Right >= r2.Left) && (r1.Right <= r2.Right)))
                && (((r1.Top >= r2.Top) && (r1.Top <= r2.Bottom))
                || ((r1.Bottom >= r2.Top) && (r1.Bottom <= r2.Bottom))
                || ((r1.Top <= r2.Top) && (r1.Bottom >= r2.Bottom))))
                return true;

            if ((((r2.Left >= r1.Left) && (r2.Left <= r1.Right))
                || ((r2.Right >= r1.Left) && (r2.Right <= r1.Right)))
                && (((r2.Top >= r1.Top) && (r2.Top <= r1.Bottom))
                || ((r2.Bottom >= r1.Top) && (r2.Bottom <= r1.Bottom))
                || ((r2.Top <= r1.Top) && (r2.Bottom >= r1.Bottom))))
                return true;

            return false;
        }

        // Area of intersection of rectangles
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            int left = Math.Max(r1.Left, r2.Left);
            int top = Math.Max(r1.Top, r2.Top);
            int right = Math.Min(r1.Right, r2.Right);
            int bottom = Math.Min(r1.Bottom, r2.Bottom);

            int width = right - left;
            int height = bottom - top;

            if (width < 0 || height < 0)
                return 0;

            return width * height;
        }

        // If one of the rectangles is entirely inside the other, return the number (from zero) of the inner one.
        // Otherwise return -1
        // If the rectangles match, you can return the number of any of them.
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom) return 1;
            if (r2.Left <= r1.Left && r2.Right >= r1.Right && r2.Top <= r1.Top && r2.Bottom >= r1.Bottom) return 0;
            return -1;
        }
    }
}