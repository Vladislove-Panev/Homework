using System;
using System.Collections.Generic;
using System.Text;

namespace FinaleConditions
{
    public static class MyConditions
    {
        // Если a > b возвращает a + b, a == b --- a*b, иначе a - b
        public static int Calculation(int a, int b)
        {
            if (a > b)
                return a + b;
            else if (a == b)
                return a * b;
            else
                return a - b;
        }

        // Выводит четверть
        public static int PrintFourth(int x, int y)
        {
            int fourth = 0;
            if (x < 0 && y > 0)
                fourth = 2;
            else if (x > 0 && y > 0)
                fourth = 1;
            else if (x < 0 && y < 0)
                fourth = 3;
            else if (x > 0 && y < 0)
                fourth = 4;

            return fourth;
        }

        // выводит в порядке возрастания
        public static string PrintAscending(int a, int b, int c)
        {

            string s = "";

            if (a < b)
            {
                if (a < c)
                {
                    if (b < c)
                        s += a + " " + b + " " + c;
                    else
                        s += a + " " + c + " " + b;
                }
                else
                    s += c + " " + a + " " + b;
            }
            else
            {
                if (b > c)
                    s += c + " " + b + " " + a;
                else if (a < c)
                    s += b + " " + a + " " + c;
                else
                    s += b + " " + c + " " + a;
            }

            return s;
        }

        public static decimal[] CalculateQuadraticEquation(int a, int b, int c)
        {
            decimal[] x = new decimal[2];
            if (a == 0)
            {
                x[0] = 0;
                x[1] = 0;
                return x;
            }
            double D = Math.Pow(b, 2) - (4 * a * c);

            if (D > 0)
            {
                x[0] = (decimal) (-b - Math.Sqrt(D)) / (2 * a);
                x[1] = (decimal) (-b + Math.Sqrt(D)) / (2 * a);
            }
            else if (D == 0)
                x[1] = -b / (2 * a);
            else
            {
                x[0] = 0;
                x[1] = 0;
            }

            x[0] = decimal.Round(x[0], 2);
            x[1] = decimal.Round(x[1], 2);

            return x;
        }

        // Преврашает числа в слова
        public static string PrintNumber(int a)
        {
            string s = "";

            if (a >= 20)
            {
                switch (a / 10)
                {
                    case 2:
                        s += "Двадцать ";
                        break;
                    case 3:
                        s += "Тридцать ";
                        break;
                    case 4:
                        s += "Сорок ";
                        break;
                    case 5:
                        s += "Пятьдесят ";
                        break;
                    case 6:
                        s += "Шестьдесят ";
                        break;
                    case 7:
                        s += "Семьдесят ";
                        break;
                    case 8:
                        s += "Восемьдесят ";
                        break;
                    case 9:
                        s += "Девяносто ";
                        break;
                }
                switch (a % 10)
                {
                    case 1:
                        s += "один";
                        break;
                    case 2:
                        s += "два";
                        break;
                    case 3:
                        s += "три";
                        break;
                    case 4:
                        s += "четыре";
                        break;
                    case 5:
                        s += "пять";
                        break;
                    case 6:
                        s += "шесть";
                        break;
                    case 7:
                        s += "семь";
                        break;
                    case 8:
                        s += "восемь";
                        break;
                    case 9:
                        s += "девять";
                        break;
                }
            }
            else if (a < 10)
            {
                switch (a)
                {
                    case 1:
                        s += "один";
                        break;
                    case 2:
                        s += "два";
                        break;
                    case 3:
                        s += "три";
                        break;
                    case 4:
                        s += "четыре";
                        break;
                    case 5:
                        s += "пять";
                        break;
                    case 6:
                        s += "шесть";
                        break;
                    case 7:
                        s += "семь";
                        break;
                    case 8:
                        s += "восемь";
                        break;
                    case 9:
                        s += "девять";
                        break;
                }
            }
            else
            {
                switch (a)
                {
                    case 11:
                        s += "Одиннадцать";
                        break;
                    case 12:
                        s += "Двенадцать";
                        break;
                    case 13:
                        s += "Тринадцать";
                        break;
                    case 14:
                        s += "Четырнадцать";
                        break;
                    case 15:
                        s += "Пятнадцать";
                        break;
                    case 16:
                        s += "Шестнадцать";
                        break;
                    case 17:
                        s += "Семнадцать";
                        break;
                    case 18:
                        s += "Восемнадцать";
                        break;
                    case 19:
                        s += "Девятнадцать";
                        break;
                }

            }

            return s;
        }
    }
}
