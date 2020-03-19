using System;
using System.Collections.Generic;
using System.Text;

namespace FinaleVariables
{
    public static class MyVariables
    {
        public static int Calculatinon(int a, int b)
        {
            if (b - a == 0)
                return 0;
            return ((5 * a) + (int)Math.Pow(b, 2)) / (b - a);
        }

        public static int[] DivAB(int a, int b)
        {
            int[] res = new int[2];

            res[0] = a / b;
            res[1] = a % b;

            return res;
        }

        public static int LinearEquation(int a, int b, int c)
        {
            if (a == 0)
                return 0;
            return (c - b) / a;
        }

        public static double[] StraightLineEquation(int x1, int x2, int y1, int y2)
        {
            double[] y = new double[2];
            if (x1 == 0 && x2 == 0 || y1 == 0 && y2 == 0) {
                y[0] = 0;
                y[1] = 0;

                return y;
            }
            double a, b;
            a = (double) (y2 - y1) / (x2 - x1);
            b = y1 - a * x1;

            //y[0] = a * x1 + b;
            //y[1] = a * x2 + b;
            y[0] = a;
            y[1] = b;

            return y;
        }

    }
}
