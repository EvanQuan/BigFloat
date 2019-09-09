using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenMultiplying : MultiplyTestBase
    {
        protected override BigFloat Multiply(
            BigFloat multiplicand,
            BigFloat multiplier)
        {
            return multiplicand * multiplier;
        }
    }
}
