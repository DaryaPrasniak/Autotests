using NUnit.Framework;

namespace NunutTest
{
    public class Divide
    {
        [SetUp]
        public void Setup()
        {
        }

        [Description("Calculator: divide test")]
        [TestCase(33, 3, 11)]
        [TestCase(32, 8, 4)]
        [TestCase(21, -3, -7)]
        public void DivideTest(int operand1, int operand2, int divideResult)
        {
            var divideActualResult = Calculator.Divide(operand1, operand2);

            Assert.AreEqual(divideActualResult, divideResult, $"Divide: {operand1} / {operand2} = {divideActualResult} ");
        }

        [TearDown]
        public void TearDown()
        {

        }

    }
}