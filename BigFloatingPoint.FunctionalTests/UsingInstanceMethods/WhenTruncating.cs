using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenTruncating : TruncateTest
    {
        protected override BigFloat Truncate(BigFloat value)
        {
            return value.Truncate();
        }
    }
}
