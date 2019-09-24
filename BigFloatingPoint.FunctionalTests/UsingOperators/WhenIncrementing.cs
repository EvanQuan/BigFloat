using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingOperators
{
    public class WhenIncrementing : IncrementTest
    {
        protected override BigFloat PostIncrement(ref BigFloat value)
        {
            return value++;
        }

        protected override BigFloat PreIncrement(ref BigFloat value)
        {
            return ++value;
        }
    }
}
