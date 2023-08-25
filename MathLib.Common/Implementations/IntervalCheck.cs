using System.Reflection.Metadata.Ecma335;

namespace MathLib.Common.Implementations
{
    public static class IntervalCheck
    {
        /// <summary>
        /// Checks, that xChecking in interval [x1,x2]
        /// </summary>
        /// <param name="x1">First interval value</param>
        /// <param name="x2">Second interval value</param>
        /// <param name="xChecking">Checking value</param>
        /// <returns>True, if xChecking between x1 and x2, otherwise false</returns>
        public static bool IsInInterval(double x1, double x2, double xChecking) =>
            x1 < x2 ? x1 <= xChecking && xChecking <= x2 : x2 <= xChecking && xChecking <= x1;
    }
}