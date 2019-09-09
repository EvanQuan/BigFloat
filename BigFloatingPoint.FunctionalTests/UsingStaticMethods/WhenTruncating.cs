using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenTruncating : TruncateTest
    {
        protected override BigFloat Truncate(BigFloat value)
        {
            return BigFloat.Truncate(value);
        }
    }
}
