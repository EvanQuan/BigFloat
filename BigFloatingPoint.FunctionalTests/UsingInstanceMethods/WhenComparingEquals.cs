using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenComparingEquals : EqualsTestBase
    {
        protected override bool Potato(
            BigFloat left,
            BigFloat right)
        {
            return left.Equals(right);
        }
    }
}
