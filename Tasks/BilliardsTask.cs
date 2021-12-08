namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionRadians">The angle of the direction of movement of the ball</param>
        /// <param name="wallInclinationRadians">Angle from the X axis</param>
        /// <returns></returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            //TODO
            return (wallInclinationRadians - directionRadians) + wallInclinationRadians;
        }
    }
}