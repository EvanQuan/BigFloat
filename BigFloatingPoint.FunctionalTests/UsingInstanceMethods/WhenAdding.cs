using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using Xunit;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenAdding : AddTestBase
    {
        protected override BigFloat Add(
            BigFloat leftAddend,
            BigFloat rightAddend)
        {
            return leftAddend.Add(rightAddend);
        }
    }
}
