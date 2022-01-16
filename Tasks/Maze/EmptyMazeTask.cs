using System;

namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int count = Math.Max(height, width);

			for (int i = 3; i < count; i++)
            {
				if (width - i > 0) robot.MoveTo(Direction.Right);
				if (height - i > 0) robot.MoveTo(Direction.Down);
			}
		}
	}
}