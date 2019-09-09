using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenMultiplying : MultiplyTestBase
    {
        protected override BigFloat Multiply(
            BigFloat multiplicand,
            BigFloat multiplier)
        {
            return BigFloat.Multiply(multiplicand, multiplier);
        }
    }
}
