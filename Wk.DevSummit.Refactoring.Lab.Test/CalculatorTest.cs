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

            var result = calculator.Calculon(num1, ope, num2);
            
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestMethod]
        public void Substract()
        {
            const int num1 = 10;
            const int num2 = 5;
            const char ope = '-';
            const double expectedResult = 5;

            var calculator = new Program();

            var result = calculator.Calculon(num1, ope, num2);
            
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestMethod]
        public void Multiply()
        {
            const int num1 = 1;
            const int num2 = 5;
            const char ope = '*';
            const double expectedResult = 5;

            var calculator = new Program();

            var result = calculator.Calculon(num1, ope, num2);
            
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestMethod]
        public void WhenOperatorIsDivisionAndDenominatorIs0ThenThrowAnError()
        {
            const int num1 = 1;
            const int num2 = 0;
            const char ope = '/';
            var expectedMessage = "Second parameter cant be 0 when operator is /";
            var calculator = new Program();
            
            var exception = Assert.ThrowsException<Exception>(() => calculator.Calculon(num1, ope, num2));
            Assert.AreEqual(exception.Message, expectedMessage);
        }
        
        [TestMethod]
        public void Division()
        {
            const int num1 = 4;
            const int num2 = 2;
            const char ope = '/';
            
            const double expectedResult = 2;

            var calculator = new Program();

            var result = calculator.Calculon(num1, ope, num2);
            
            Assert.AreEqual(expectedResult, result);
        }
    }
}