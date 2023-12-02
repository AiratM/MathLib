using MathLib.Interpolation.Interfaces;
using MathLib.Common.Implementations;

namespace MathLib.Interpolation.Implementations
{
    public class LinearInterpolation : ILinearInterpolation
    {
        public double CalcLinearInterpolation(double f1, double x1, double f2, double x2, double xCalc)
        {
            double res = f1 + (f2 - f1) / (x2 - x1) * (xCalc - x1);
            return res;
        }

        public double CalcLinearInterpolationWithCheck(double f1, double x1, double f2, double x2, double xCalc)
        {
            if (!IntervalCheck.IsInInterval(x1,x2,xCalc))
                throw new ArgumentException("Argument is not in interval");

            return CalcLinearInterpolation(f1, x1, f2, x2, xCalc);
        }
    }
}