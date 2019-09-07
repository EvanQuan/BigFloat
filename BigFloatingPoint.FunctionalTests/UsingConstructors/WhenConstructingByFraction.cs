using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingConstructors
{
    public class WhenConstructingByFraction : ConstructorFractionTestBase
    {
        protected override BigFloat ConstructByFraction(
            int numerator,
            int denominator)
        {
            return new BigFloat(numerator, denominator);
        }
    }
}
