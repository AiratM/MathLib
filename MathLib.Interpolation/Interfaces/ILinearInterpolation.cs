using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.Interpolation.Interfaces
{
    public interface ILinearInterpolation
    {
        /// <summary>
        /// Calc linear interpolation of function f(x)
        /// </summary>
        /// <param name="f1">Function value in X1</param>
        /// <param name="x1">Value X1</param>
        /// <param name="f2">Function value in X2</param>
        /// <param name="x2">Value X2</param>
        /// <param name="xCalc">X for calc function value </param>
        /// <returns></returns>
        double CalcLinearInterpolation(double f1, double x1, double f2, double x2, double xCalc);
    }
}
