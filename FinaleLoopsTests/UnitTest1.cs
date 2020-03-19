using NUnit.Framework;
using FinaleLoops;

namespace FinaleLoopsTests
{
    public class Tests
    {
        [TestCase (2, 2, ExpectedResult = 4)]
        [TestCase(2, -2, ExpectedResult = 0.25)]
        [TestCase(0, 0, ExpectedResult = 1)]
        [TestCase(2, 0, ExpectedResult = 1)]
        public double PowTest(int a, int b)
        {
            double actual = MyLoops.Pow(a, b);

            return actual;
        }

        [TestCase(52, ExpectedResult = "52 104 156 208 260 312 364 416 468 520 572 624 676 728 780 832 884 936 988 ")]
        [TestCase(0, ExpectedResult = "0")]
        public string NumsDivByTest(int a)
        {
            string actual = MyLoops.NumsDivBy(a);

            return actual;
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-24, ExpectedResult = 0)]
        [TestCase(49, ExpectedResult = 6)]
        public int CountNumbSqLessTest(int a)
        {
            int actual = MyLoops.CountNumbSqLess(a);

            return actual;
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(4, ExpectedResult = 2)]
        [TestCase(-4, ExpectedResult = -2)]
        public int LargerDivisionTest(int a)
        {
            int actual = MyLoops.LargerDivision(a);

            return actual;
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(-7, 7, ExpectedResult = 14)]
        [TestCase(7, -7, ExpectedResult = 14)]
        public int SumNumbsAtoBTest(int a, int b)
        {
            int actual = MyLoops.SumNumbsAtoB(a, b);

            return actual;
        }

        [TestCase(7, ExpectedResult = "1 1 2 3 5 8 13 ")]
        [TestCase(0, ExpectedResult = "")]
        [TestCase(-2, ExpectedResult = "")]
        public string PrintFibTest(int a)
        {
            string actual = MyLoops.PrintFib(a);

            return actual;
        }

        [TestCase(180, 150, ExpectedResult = 30)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(-180, 150, ExpectedResult = 0)]
        public int GratestCommonFactorTest(int a, int b)
        {
            int actual = MyLoops.GratestCommonFactor(a, b);

            return actual;
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(49, ExpectedResult = 7)]
        [TestCase(-49, ExpectedResult = 0)]
        public int MySqrtTest(int a)
        {
            int actual = MyLoops.MySqrt(a);

            return actual;
        }

        [TestCase(111, ExpectedResult = 3)]
        [TestCase(-121, ExpectedResult = 2)]
        [TestCase(0, ExpectedResult = 0)]
        public int CountOddNumsTest(int n)
        {
            int actual = MyLoops.CountOddNums(n);

            return actual;
        }

        [TestCase(111, ExpectedResult = 111)]
        [TestCase(-123, ExpectedResult = -321)]
        [TestCase(0, ExpectedResult = 0)]
        public int PrintReverseNumberTest(int n)
        {
            int actual = MyLoops.PrintReverseNumber(n);

            return actual;
        }

        [TestCase(111, -321, ExpectedResult = true)]
        [TestCase(-123, 456, ExpectedResult = false)]
        [TestCase(0, 1, ExpectedResult = false)]
        public bool FindSameNumsTest(int n1, int n2)
        {
            bool actual = MyLoops.FindSameNums(n1, n2);

            return actual;
        }

        [TestCase(8, ExpectedResult = 4)]
        [TestCase(-14, ExpectedResult = 0)]
        [TestCase(0, ExpectedResult = 0)]
        public int CountEvenGreaterOddTest(int n)
        {
            int actual = MyLoops.CountEvenGreaterOdd(n);

            return actual;
        }
    }
}