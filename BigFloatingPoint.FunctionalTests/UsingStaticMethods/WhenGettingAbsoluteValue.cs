using BigFloatingPoint.FunctionalTests.TestBases;
using BigFloatingPoint.Implementations;

namespace BigFloatingPoint.FunctionalTests.UsingStaticMethods
{
    public class WhenGettingAbsoluteValue : AbsoluteValueTest
    {
        public override BigFloat AbsoluteValue(BigFloat value)
        {
            return BigFloat.AbsoluteValue(value);
        }
    }
}
