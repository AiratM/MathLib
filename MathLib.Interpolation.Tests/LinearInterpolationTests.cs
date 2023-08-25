using MathLib.Interpolation.Interfaces;
namespace MathLib.Interpolation.Tests
{
    public class LinearInterpolationTests
    {
        private ILinearInterpolation _linearInterpolation;

        [OneTimeSetUp]
        public void Setup()
        {
            _linearInterpolation = new LinearInterpolation();
        }

        [TestCase(1.0, 3.0, 2, 1.00001)]
        [TestCase(3.0, 5.0, 4, 1.00001)]
        [TestCase(3.0, 5.0, 4, 1.00001)]
        public void CalcInterpolationTest_ShouldLessEpsilon(double x1, double x2, double xCalc, double epsilon)
        {
            double interpolated = _linearInterpolation.CalcLinearInterpolation(TestFunc(x1), x1, TestFunc(x2), x2, xCalc);
            double calculated = TestFunc(xCalc);
            double delta = Math.Abs(interpolated - calculated);
            Assert.LessOrEqual(delta, epsilon);
        }

        [TestCase(1.0, 3.0, 2.0, 5.0)]
        [TestCase(5.0, 12.0, 7.0, 59.0)]
        public void CalcInterpolationTest_ShouldBe(double x1, double x2, double xCalc, double shouldBe)
        {
            double interpolated = _linearInterpolation.CalcLinearInterpolation(TestFunc(x1), x1, TestFunc(x2), x2, xCalc);
            Assert.That(interpolated, Is.EqualTo(shouldBe));
        }

        private double TestFunc(double x) => x * x;
    }
}