namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int count = height >= width ?
                (height - 2) / ((height - 2) / (width - 2)) - 1 :
                (width - 2) / ((width - 2) / (height - 2)) - 1;

            int widthLength = (width - 2) / (height - 2) + (height >= width ? 1 : 0);
            int heightLength = (height - 2) / (width - 2) + (height >= width ? 0 : 1);

            MoveWay(robot, width, height, count, widthLength, heightLength);

            MoveEnd(robot, width, height, widthLength, heightLength);
        }

        private static void MoveEnd(Robot robot, int width, int height, int widthLength, int heightLength)
        {
            if (height >= width)
            {
                if (widthLength == heightLength) return;
                MoveDown(robot, heightLength);
            }
            else
                MoveRight(robot, widthLength);
        }

        private static void MoveWay(Robot robot, int width, int height, int count, int widthLength, int heightLength)
        {
            for (int i = 0; i < count; i++)
            {
                if (height >= width)
                {
                    MoveDown(robot, heightLength);
                    if (widthLength == heightLength && i == count - 1) break;
                    MoveRight(robot, widthLength);
                }
                else
                    MoveOnWidth(robot, widthLength, heightLength);
            }
        }

        private static void MoveOnWidth(Robot robot, int widthLength, int heightLength)
        {
            MoveRight(robot, widthLength);
            MoveDown(robot, heightLength);
        }

        private static void MoveRight(Robot robot, int widthLength)
        {
            for (int i = 0; i < widthLength; i++)
                robot.MoveTo(Direction.Right);
        }

        private static void MoveDown(Robot robot, int heightLength)
        {
            for (int i = 0; i < heightLength; i++)
                robot.MoveTo(Direction.Down);
        }
    }
}