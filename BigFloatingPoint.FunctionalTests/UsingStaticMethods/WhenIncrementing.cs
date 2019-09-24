using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;
using System;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenIncrementing : IncrementTest
    {
        protected override BigFloat PostIncrement(ref BigFloat value)
        {
            BigFloat preValue = value;
            value = BigFloat.Increment(value);
            return preValue;
        }

        protected override BigFloat PreIncrement(ref BigFloat value)
        {
            value = BigFloat.Increment(value);
            return value;
        }
    }
}
