using NUnit.Framework;
using FinaleConditions;

namespace FinaleConditionsTests
{
    public class Tests
    {
        [TestCase(5, 4, ExpectedResult = 9)]
        [TestCase(10, -4, ExpectedResult = 6)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int CalculationTest(int a, int b)
        {
            int actual = MyConditions.Calculation(a, b);

            return actual;
        }

        [TestCase(5, 4, ExpectedResult = 1)]
        [TestCase(10, -4, ExpectedResult = 4)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int PrintFourthTest(int x, int y)
        {
            int actual = MyConditions.PrintFourth(x, y);

            return actual;
        }

        [TestCase(5, 4, 3, ExpectedResult = "3 4 5")]
        [TestCase(10, -4, -2, ExpectedResult = "-4 -2 10")]
        [TestCase(0, 0, 0, ExpectedResult = "0 0 0")]
        public string PrintAscendingTest(int a, int b, int c)
        {
            string actual = MyConditions.PrintAscending(a, b, c);

            return actual;
        }

        [TestCase(5, 4, 3, ExpectedResult = new double[] { 0, 0 } )]
        [TestCase(10, -4, -2, ExpectedResult =new double[] { -0.29, 0.69 } )]
        [TestCase(0, 0, 0, ExpectedResult = new double[] { 0, 0 })]
        public decimal[] CalculateQuadraticEquation(int a, int b, int c)
        {
            decimal[] actual = MyConditions.CalculateQuadraticEquation(a, b, c);

            return actual;
        }

        [TestCase(5, ExpectedResult = "пять")]
        [TestCase(25, ExpectedResult = "Двадцать пять")]
        public string PrintNumberTest(int a)
        {
            string actual = MyConditions.PrintNumber(a);

            return actual;
        }
    }
}