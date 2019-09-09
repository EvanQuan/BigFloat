using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenSubtracting : SubtractTest
    {
        protected override BigFloat Subtract(
            BigFloat minuend,
            BigFloat subtrahend)
        {
            return BigFloat.Subtract(minuend, subtrahend);
        }
    }
}
