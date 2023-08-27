using MathLib.Common.Implementations;
namespace MathLib.Common.Tests
{
    public class IntervalCheckTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1.0, 5.0, 4.0)]
        [TestCase(0, 1.32, 0.3)]
        [TestCase(-5.5, -3.4, -4.1)]
        [TestCase(0.999999998, 1.0, 1.0)]
        public void IntervalCheckInIntervalPositive(double x1, double x2, double xChecking) => Assert.IsTrue(IntervalCheck.IsInInterval(x1, x2, xChecking));

    }
}