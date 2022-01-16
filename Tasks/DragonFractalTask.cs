// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System;

namespace Fractals
{
    internal static class DragonFractalTask
    {
        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            double x = 1;
            double y = 0;
            Random random = new Random(seed);

            for (int i = 0; i < iterationsCount; i++)
            {
                if (random.Next(-101, 100) < 0)
                    DrawFirstTransformation(pixels, ref x, ref y);
                else
                    DrawSecondTransformation(pixels, ref x, ref y);
            }
        }

        private static void DrawFirstTransformation(Pixels pixels, ref double x, ref double y)
        {
            double tempX = (x * Math.Cos(Math.PI / 4) - y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2);
            double tempY = (x * Math.Sin(Math.PI / 4) + y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);

            pixels.SetPixel(tempX, tempY);

            x = tempX; y = tempY;
        }

        private static void DrawSecondTransformation(Pixels pixels, ref double x, ref double y)
        {
            double tempX = (x * Math.Cos(3 * Math.PI / 4) - y * Math.Sin(3 * Math.PI / 4)) / Math.Sqrt(2) + 1;
            double tempY = (x * Math.Sin(3 * Math.PI / 4) + y * Math.Cos(3 * Math.PI / 4)) / Math.Sqrt(2);

            pixels.SetPixel(tempX, tempY);

            x = tempX; y = tempY;
        }
    }
}