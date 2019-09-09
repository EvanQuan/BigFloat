using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingInstanceMethods
{
    public class WhenGettingAbsoluteValue : AbsoluteValueTest
    {
        public override BigFloat AbsoluteValue(BigFloat value)
        {
            return value.AbsoluteValue();
        }
    }
}
