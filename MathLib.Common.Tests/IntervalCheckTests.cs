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
        public void IntervalCheck_InInterval(double x1, double x2, double xChecking) => Assert.IsTrue(IntervalCheck.IsInInterval(x1, x2, xChecking));

    }
}