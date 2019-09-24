using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenIncrementing : IncrementTest
    {
        protected override BigFloat PostIncrement(ref BigFloat value)
        {
            BigFloat preValue = value;
            value = value.Increment();
            return preValue;
        }

        protected override BigFloat PreIncrement(ref BigFloat value)
        {
            value = value.Increment();
            return value;
        }
    }
}
