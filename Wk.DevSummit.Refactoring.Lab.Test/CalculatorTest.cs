using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wk.DevSummit.Refactoring.Lab.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void SumTest()
        {
            const int num1 = 5;
            const int num2 = 10;
            const char ope = '+';
            const double expectedResult = 15;

            var calculator = new Program();

            var result = calculator.Sum(num1, ope, num2);
            
            Assert.AreEqual(expectedResult, result);
        }
    }
}