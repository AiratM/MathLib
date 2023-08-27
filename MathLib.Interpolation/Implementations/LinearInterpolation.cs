using MathLib.Interpolation.Interfaces;

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
            throw new NotImplementedException();
        }
    }
}