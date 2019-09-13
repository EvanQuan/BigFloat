using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenNegating : NegateTest
    {
        protected override BigFloat Negate(BigFloat value)
        {
            return value.Negate();
        }
    }
}
