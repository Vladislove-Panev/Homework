using NUnit.Framework;
using FinaleArrays;

namespace FinaleArraysTests
{
    public class Tests
    {
        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 12, -19, 0, 20, 1 }, ExpectedResult = -19)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int FindMinElTest(int[] a)
        {
            int actual = MyArrays.FindMinEl(a);

            return actual;
        }

        [TestCase(1, ExpectedResult = -44)]
        [TestCase(2, ExpectedResult = 0)]
        [TestCase(3, ExpectedResult = -50)]
        public int FindMinElDemenTest(int a)
        {
            int[,] array = new int[0, 0];

            switch (a)
            {
                case 1:
                    array = new int[,]
                    {
                        { 1, 10, 9 },
                        { -1, 20, 2 },
                        { 4, -44, 53 }
                    };
                    break;
                case 2:
                    array = new int[,]
                    {

                    };
                    break;
                case 3:
                    array = new int[,]
                    {
                        { -1, -10, -9 },
                        { -1,-50, -2 },
                        { 4, -44, 0 }
                    };
                    break;
            }

            int actual = MyArrays.FindMinEl(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = 20)]
        [TestCase(new int[] { 1, 12, -19, 0, 22, 1 }, ExpectedResult = 22)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int FindMaxElTest(int[] array)
        {
            int actual = MyArrays.FindMaxEl(array);

            return actual;
        }

        [TestCase(1, ExpectedResult = 4)]
        [TestCase(2, ExpectedResult = 0)]
        [TestCase(3, ExpectedResult = 4)]
        public int FindMaxElDemenTest(int a)
        {
            int[,] array = new int[0, 0];

            switch (a)
            {
                case 1:
                    array = new int[,]
                    {
                        { 1},
                        { -1},
                        { 4}
                    };
                    break;
                case 2:
                    array = new int[,]
                    {

                    };
                    break;
                case 3:
                    array = new int[,]
                    {
                        { -1, -10, -9 },
                        { -1,-50, -2 },
                        { 4, -44, 0 }
                    };
                    break;
            }

            int actual = MyArrays.FindMaxEl(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 12, -19, 0, 11, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int FindMaxIndexTest(int[] array)
        {
            int actual = MyArrays.FindMaxIndex(array);

            return actual;
        }

        [TestCase(1, ExpectedResult = new int[] { 2, 0 })]
        [TestCase(2, ExpectedResult = new int[] { 0, 0 })]
        [TestCase(3, ExpectedResult = new int[] { 2, 1 })]
        public int[] FindMaxIndexDemenTest(int a)
        {
            int[,] array = new int[0, 0];

            switch (a)
            {
                case 1:
                    array = new int[,]
                    {
                        { 1},
                        { -1},
                        { 4}
                    };
                    break;
                case 2:
                    array = new int[,]
                    {

                    };
                    break;
                case 3:
                    array = new int[,]
                    {
                        { -1, -10, -9 },
                        { -1,-50, -2 },
                        { 4, 44, 0 }
                    };
                    break;
            }

            int[] actual = MyArrays.FindMaxIndex(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 12, -19, 0, 11, 1 }, ExpectedResult = 2)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int FindMinIndexTest(int[] array)
        {
            int actual = MyArrays.FindMinIndex(array);

            return actual;
        }

        [TestCase(1, ExpectedResult = new int[] { 1, 0 })]
        [TestCase(2, ExpectedResult = new int[] { 0, 0 })]
        [TestCase(3, ExpectedResult = new int[] { 1, 1 })]
        public int[] FindMinIndexDemenTest(int a)
        {
            int[,] array = new int[0, 0];

            switch (a)
            {
                case 1:
                    array = new int[,]
                    {
                        { 1},
                        { -1},
                        { 4}
                    };
                    break;
                case 2:
                    array = new int[,]
                    {

                    };
                    break;
                case 3:
                    array = new int[,]
                    {
                        { -1, -10, -9 },
                        { -1,-50, -2 },
                        { 4, 44, 0 }
                    };
                    break;
            }

            int[] actual = MyArrays.FindMinIndex(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = 18)]
        [TestCase(new int[] { 1, 12, -19, 0, 11, 1 }, ExpectedResult = 13)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int SumOddElTest(int[] array)
        {
            int actual = MyArrays.SumOddEl(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = new int[] { 1, 20, 4, 19, 13, 5 })]
        [TestCase(new int[] { 1, 12, -19, 0, 11 }, ExpectedResult = new int[] { 11, 0, -19, 12, 1 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { 0 })]
        public int[] ReverseArrTest(int[] array)
        {
            int[] actual = MyArrays.ReverseArr(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 12, -19, 0, 11, 1 }, ExpectedResult = 4)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int CountOddArrElTest(int[] array)
        {
            int actual = MyArrays.CountOddArrEl(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = new int[] { 4, 20, 1, 5, 13, 19 })]
        [TestCase(new int[] { 1, 12, -19, 0, 11 }, ExpectedResult = new int[] { 0, 11, -19, 1, 12 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { 0 })]
        public int[] ChangeArrHalfsTest(int[] array)
        {
            int[] actual = MyArrays.ChangeArrHalfs(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = new int[] { 1, 4, 5, 13, 19, 20 })]
        [TestCase(new int[] { 1, 12, -19, 0, 11 }, ExpectedResult = new int[] { -19, 0, 1, 11, 12 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { 0 })]
        public int[] SortArrIncTest(int[] array)
        {
            int[] actual = MyArrays.SortArrInc(array);

            return actual;
        }

        [TestCase(new int[] { 5, 13, 19, 4, 20, 1 }, ExpectedResult = new int[] { 20, 19, 13, 5, 4, 1 })]
        [TestCase(new int[] { 1, 12, -19, 0, 11 }, ExpectedResult = new int[] { 12, 11, 1, 0, -19 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { 0 })]
        public int[] SortArrDecTest(int[] array)
        {
            int[] actual = MyArrays.SortArrDec(array);

            return actual;
        }

        [TestCase(1, ExpectedResult = 2)]
        [TestCase(2, ExpectedResult = 0)]
        [TestCase(3, ExpectedResult = 1)]
        public int FindMaxElToNeighboorTest(int a)
        {
            int[,] array = new int[0, 0];

            switch (a)
            {
                case 1:
                    array = new int[,]
                    {
                        { 1},
                        { -1},
                        { 4}
                    };
                    break;
                case 2:
                    array = new int[,]
                    {

                    };
                    break;
                case 3:
                    array = new int[,]
                    {
                        { -1, -10, -9 },
                        { -1,-50, -2 },
                        { 4, 44, 0 }
                    };
                    break;
            }

            int actual = MyArrays.FindMaxElToNeighboor(array);

            return actual;
        }

        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(3, ExpectedResult = true)]
        public bool FlipElTest(int a)
        {
            int[,] arr1 = new int[,] { { 0, 0 } };
            int[,] expected = new int[,] { { 0, 0 } };

            switch (a)
            {
                case 1:
                    arr1 = new int[,]
                    {
                    { 1},
                    { -1},
                    { 4}
                    };
                    break;
                case 2:
                   arr1 = new int[,]
                   {

                   };
                   break;
                case 3:
                   arr1 = new int[,]
                   {
                   { -1, -10, -9 },
                   { -1,-50, -2 },
                   { 4, 44, 0 }
                   };
                   break;
            }

            switch (a)
            {
               case 1:
                    expected = new int[,]
                    {
                    { 1},
                    { -1},
                    { 4}
                    };
                    break;
               case 2:
                    expected = new int[,]
                   {
                   { 0 }
                   };
                   break;
               case 3:
                    expected = new int[,]
                   {
                   { -1, -1, 4 },
                   { -10,-50, 44 },
                   { -9, -2, 0 }
                   };
                   break;
            }

            int[,] actual = MyArrays.FlipEl(arr1);

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    if (actual[i, j] != expected[i, j])
                        return false;
                }
            }

            return true;
        }
    }
}