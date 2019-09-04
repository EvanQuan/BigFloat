using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenAdding : AddingTestBase
    {
        protected override BigFloat Add(
            BigFloat leftAddend,
            BigFloat rightAddend)
        {
            return leftAddend + rightAddend;
        }
    }
}
