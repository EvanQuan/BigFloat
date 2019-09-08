using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System.Numerics;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenComparingEquals : EqualsTestBase
    {
        protected override bool Equal(
            BigFloat left,
            BigFloat right)
        {
            return left.Equals(right);
        }
    }

}
