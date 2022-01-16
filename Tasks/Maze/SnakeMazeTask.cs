namespace Mazes
{
    public static class SnakeMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            for (int i = 0; i < height / 4 - 1; i++)
            {
                MoveRight(robot, width);
                MoveDown(robot);
                MoveLeft(robot, width);
                MoveDown(robot);
            }

            if (height % 2 != 0) MoveFinishLeft(robot, width);
            else MoveFinishRight(robot, width);
        }

        private static void MoveRight(Robot robot, int width)
        {
            for (int i = 0; i < width - 3; i++) 
                robot.MoveTo(Direction.Right);
        }

        private static void MoveLeft(Robot robot, int width)
        {
            for (int i = 0; i < width - 3; i++) 
                robot.MoveTo(Direction.Left);
        }

        private static void MoveDown(Robot robot)
        {
            robot.MoveTo(Direction.Down);
            robot.MoveTo(Direction.Down);
        }

        private static void MoveFinishLeft(Robot robot, int width)
        {
            MoveRight(robot, width);
            MoveDown(robot);
            MoveLeft(robot, width);
        }

        private static void MoveFinishRight(Robot robot, int width)
        {
            MoveRight(robot, width);
        }
    }
}