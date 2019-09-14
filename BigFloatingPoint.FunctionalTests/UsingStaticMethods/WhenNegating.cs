using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenNegating : NegateTest
    {
        protected override BigFloat Negate(BigFloat value)
        {
            return BigFloat.Negate(value);
        }
    }
}
