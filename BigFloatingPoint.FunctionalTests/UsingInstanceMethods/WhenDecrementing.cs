using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenDecrementing : DecrementTest
    {
        protected override BigFloat PostDecrement(ref BigFloat value)
        {
            BigFloat preValue = value;
            value = value.Decrement();
            return preValue;
        }

        protected override BigFloat PreDecrement(ref BigFloat value)
        {
            value = value.Decrement();
            return value;
        }
    }
}
