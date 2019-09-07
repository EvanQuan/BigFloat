using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenAdding : AddTestBase
    {
        protected override BigFloat Add(BigFloat leftAddend, BigFloat rightAddend)
        {
            return BigFloat.Add(leftAddend, rightAddend);
        }
    }
}
