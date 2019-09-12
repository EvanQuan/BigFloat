using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenRaisePowerTo : PowerToTest
    {
        protected override BigFloat PowerTo(BigFloat @base, int exponent)
        {
            return BigFloat.PowerTo(@base, exponent);
        }
    }
}
