using System;
using System.Collections.Generic;
using System.Text;

namespace FinaleLoops
{
    public static class MyLoops
    {
        // Возведение А в степень B
        public static double Pow(int a, int b)
        {
            double res = 1;
            int c;
            if (b < 0)
                c = b * -1;
            else
                c = b;

            for (int i = 0; i < c; i++)
            {
                res *= a;
            }

            if (b < 0)
                res = (double)1 / res;

            return res;
        }
        //Выводит числа от 1 до 1000, которые делятся на А
        public static string NumsDivBy(int a)
        {
            string s = "";
            if (a == 0)
                return s += 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                    s += i + " ";
            }

            return s;
        }
        //Возвращает кол-во положительных целых чисел, квадрат которых меньше А
        public static int CountNumbSqLess(int a)
        {
            int count = 0;
            if (a < 0)
                return count;
            for (int i = 1; i * i < a; i++)
            {
                count++;
            }

            return count;
        }
        //Возвращает наибольший делитель
        public static int LargerDivision(int a)
        {
            int maxD = 0, counter;
            if (a < 0)
                counter = -a;
            else
                counter = a;
            for (int i = 1; i < counter; i++)
            {
                if (a % i == 0)
                {
                    maxD = i;
                }
            }

            if (a > 0)
                return maxD;
            else
                return -1 * maxD;
        }
        // Возвращает сумму всех чисел от A до B, которые делятся на 7
        public static int SumNumbsAtoB(int a, int b)
        {
            int sum = 0;
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    if (i > 0)
                        sum += i;
                    else
                        sum += -i;
                }
            }

            return sum;
        }

        //Выводит ряд чисел фибоначчи
        public static string PrintFib(int a)
        {
            int pr1 = 0, pr2 = 1;
            string s = "";
            for (int i = 0; i < a; i++)
            {
                if (i <= 0)
                    s += "1 ";
                else
                {
                    int f = pr1 + pr2;
                    pr1 = pr2;
                    pr2 = f;
                    s += f + " ";
                }
            }

            return s;
        }

        //Возвращает наибольший общий делитель
        public static int GratestCommonFactor(int a, int b)
        {
            int temp, ans = 0;

            if (a < 0 || b < 0)
                return ans;
            do
            {
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }

                if (b != 0)
                {
                    ans = a % b;
                    a = b;
                    b = ans;
                }
                else
                    return ans;
            }
            while (a % b != 0);

            return ans;
        }

        //Возвращает квадрат числа
        public static int MySqrt(int n)
        {
            if (n <= 0)
                return 0;

            int midN = n / 2, l = 0, r = n;

            while (midN * midN != n)
            {
                if (midN * midN > n)
                {
                    r = midN;
                }
                else
                {
                    l = midN;
                }
                midN = (l + r) / 2;
            }

            return midN;
        }

        // Возвращает кол-во нечетных цифр этого числа
        public static int CountOddNums(int n)
        {
            int count = 0;
            while (n != 0)
            {
                int t = n % 10;
                if (t % 2 != 0)
                    count++;
                n /= 10;
            }

            return count;
        }

        // Зеркалит число и выводит
        public static int PrintReverseNumber(int n)
        {
            int newNum = 0;
            while (n != 0)
            {
                newNum *= 10;
                int a = n % 10;
                newNum += a;         
                n /= 10;
            }

            return newNum;
        }

        //Ищет одинаковые цифры
        public static bool FindSameNums(int n1, int n2)
        {
            bool answer = false;

            if (n1 < 0)
                n1 *= -1;
            if (n2 < 0)
                n2 *= -1;

            while (n1 != 0)
            {
                int lastN1 = n1 % 10;
                int temp = n2;
                while (temp != 0)
                {
                    int lastN2 = temp % 10;
                    if (lastN1 == lastN2)
                    {
                        answer = true;
                        break;
                    }
                    temp /= 10;
                }
                n1 /= 10;
            }

            return answer;
        }

        // Выводит кол-во чисел от 1 до N. Сумма четных которых больше
        public static int CountEvenGreaterOdd(int n)
        {
            int count = 0, even = 0, odd = 0;
            if (n <= 0)
                return 0;

            while (n != 0)
            {
                if (n > 10)
                {
                    int temp = n;
                    while (temp != 0)
                    {
                        int f = temp % 10;


                        if (f % 2 == 0)
                        {
                            even += f;
                        }
                        else
                        {
                            odd += f;
                        }
                        temp /= 10;
                    }
                }
                else
                {
                    if (n % 2 == 0)
                    {
                        even += n;
                    }
                    else
                    {
                        odd += n;
                    }
                }

                if (even > odd)
                {
                    count++;
                }

                even = 0;
                odd = 0;
                n--;

            }

            return count;
        }
    }
}
