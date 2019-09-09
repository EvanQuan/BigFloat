using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenComparingEquals : EqualsTest
    {
        protected override bool Equal(
            BigFloat left,
            BigFloat right)
        {
            return left == right;
        }
    }
}
