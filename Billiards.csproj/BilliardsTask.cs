using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            double directionDeg = (directionRadians * 180) / Math.PI;
            double wallInclinationDeg = (wallInclinationRadians * 180) / Math.PI;

            double wallAngle = 90 + wallInclinationDeg;
            double ballAngle = 180 + directionDeg;

            double diff = wallAngle - ballAngle;

            return (ballAngle + 2 * diff + 360 * 5) * Math.PI / 180;
        }
    }
}