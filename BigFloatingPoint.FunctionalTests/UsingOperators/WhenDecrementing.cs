using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenDecrementing : DecrementTest
    {
        protected override BigFloat PostDecrement(ref BigFloat value)
        {
            return value--;
        }

        protected override BigFloat PreDecrement(ref BigFloat value)
        {
            return --value;
        }
    }
}
