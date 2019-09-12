using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenRaisingPowerTo : PowerToTest
    {
        protected override BigFloat PowerTo(BigFloat @base, int exponent)
        {
            return @base.PowerTo(exponent);
        }
    }
}
