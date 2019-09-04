using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenAdding : AddingTestBase
    {
        protected override BigFloat Add(BigFloat leftAddend, BigFloat rightAddend)
        {
            return BigFloat.Add(leftAddend, rightAddend);
        }
    }
}
