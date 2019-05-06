using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExceptionRules.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRule()
        {
            var rule = Rule.SetMessage("");





            //Rule.ForValues<int>()
            //    .SetThrowCondition(value => value == 2)
            //    .Check();

            //Rule
            //    .ForParameters<double>()
            //    .SetThrowCondition(double.IsNaN)
            //    .Check();

            //var rule = Rule
            //    .ForParameters<double>()
            //    .AndValues<bool>()
            //    .SetMessage((p1, a1, v1) => "")
            //    .SetThrowCondition((argument1, value1) => argument1 > 0 && value1);

            //rule.Check();
        }
    }
}
