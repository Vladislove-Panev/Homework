using NUnit.Framework;
using FinaleVariables;

namespace FinaleVariablesTest
{
    public class Tests
    {
        [TestCase(10, 5, ExpectedResult = -15)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(-15, 25, ExpectedResult = 13)]
        public int CalculationTest(int a, int b)
        {
            int actual = MyVariables.Calculatinon(a, b);

            return actual;
        }

        [TestCase (0, 0, 0, ExpectedResult = 0)]
        [TestCase (-1, 0, 1, ExpectedResult = -1)]
        [TestCase (2, 20, 2, ExpectedResult = -9)]
        public int LinearEquationTest(int a, int b, int c)
        {
            int actual = MyVariables.LinearEquation(a, b, c);

            return actual;
        }
        [TestCase (10, 2, ExpectedResult = new int[] {5, 0})]
        public int[] DivABTest(int a, int b)
        {
            int[] actual = MyVariables.DivAB(a, b);

            return actual;
        }

        [TestCase (10, 5, 4, 8, ExpectedResult = new double[] { -0.8, 12 })]
        [TestCase (0, 0, 0, 0, ExpectedResult = new double[] { 0, 0 })]
        public double[] StraightLineEquationTest(int x1, int x2, int y1, int y2)
        {
            double[] actual = MyVariables.StraightLineEquation(x1, x2, y1, y2);

            return actual;
        }
    }
}