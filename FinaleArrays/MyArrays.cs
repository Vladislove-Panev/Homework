using System;
using System.Collections.Generic;
using System.Text;

namespace FinaleArrays
{
    public static class MyArrays
    {
        // Заполняет одномерный массив
        public static int[] InitArray(int a)
        {
            int[] array = new int[a];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            return array;
        }
        // Заполняет двумерный массив
        public static int[,] InitArray(int a, int b)
        {
            int[,] array = new int[a, b];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }

            return array;
        }
        // Выводит одномерный массив
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
        }
        // Выводит двумерный массив
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
        }
        // Находит минимальный элемент массива
        public static int FindMinEl(int[] array)
        {
            int min;
            if (array.Length != 0)
            {
                min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
            }
            else
                min = 0;

            return min;
        }
        // Находит минимальный элемент массива
        public static int FindMinEl(int[,] array)
        {
            int min;

            if (array.Length != 0)
            {
                min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < min)
                        {
                            min = array[i, j];
                        }
                    }
                }
            }
            else
                min = 0;

            return min;
        }
        // Находит максимальный элемент массива
        public static int FindMaxEl(int[] array)
        {
            int max;

            if (array.Length != 0)
            {
                max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
            }
            else
                max = 0;

            return max;
        }
        // Находит максимальный элемент массива
        public static int FindMaxEl(int[,] array)
        {
            int max;

            if (array.Length != 0)
            {
                max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > max)
                        {
                            max = array[i, j];
                        }
                    }
                }
            }
            else
                max = 0;

            return max;
        }
        // Находит максимальный индекс элемента массива
        public static int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;

            if (array.Length != 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
            }

            return maxIndex;
        }
        // Находит максимальный индекс элемента массива
        public static int[] FindMaxIndex(int[,] array)
        {
            int[] maxIndex = new int[2] { 0, 0};

            if (array.Length != 0)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > array[maxIndex[0], maxIndex[1]])
                        {
                            maxIndex[0] = i;
                            maxIndex[1] = j;
                        }
                    }
                }
            }

            return maxIndex;
        }
        // Находит минимальный индекс элемента массива
        public static int FindMinIndex(int[] array)
        {
            int minIndex = 0;

            if (array.Length != 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[minIndex])
                    {
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }
        // Находит минимальный индекс элемента массива
        public static int[] FindMinIndex(int[,] array)
        {
            int[] minIndex = new int[2] { 0, 0};

            if (array.Length != 0)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < array[minIndex[0], minIndex[1]])
                        {
                            minIndex[0] = i;
                            minIndex[1] = j;
                        }
                    }
                }
            }

            return minIndex;
        }
        // Сумма нечетных элементов массива
        public static int SumOddEl(int[] array)
        {
            int sum = 0;

            if (array.Length != 0)
            {
                for (int i = 1; i <= array.Length - 1; i += 2)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
        // Разворачивает массив
        public static int[] ReverseArr(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = temp;
                }

                return array;
            }else 
                return _ = new int[1] { 0 }; 
        }
        // Считает нечетные элементы массива
        public static int CountOddArrEl(int[] array)
        {
            int count = 0;

            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        // Меняет местами первую и вторую половину массива
        public static int[] ChangeArrHalfs(int[] array)
        {

            if (array.Length != 0)
            {
                int iter = 0;
                for (int i = array.Length / 2 - 1; i >= 0; i--)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - 1 - iter];
                    array[array.Length - 1 - iter] = temp;
                    iter++;
                }

                return array;
            }

            return _ = new int[] { 0 };
        }
        // Сортирует массив по возрастанию
        public static int[] SortArrInc(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }

                return array;
            }
            else
                return _ = new int[] { 0 };
        }
        // Сортирует массив по убыванию
        public static int[] SortArrDec(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                return array;
            }

            return _ = new int[] { 0 };
        }
        // Считает кол-во элементов, которые больше своих левых, правых, вверхних и нижних соседей
        public static int FindMaxElToNeighboor(int[,] array)
        {
            int r, l, up, down, count = 0;

            if (array.Length != 0)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i == 0)
                            up = 0;
                        else
                            up = array[i - 1, j];

                        if (i == array.GetLength(0) - 1)
                            down = 0;
                        else
                            down = array[i + 1, j];

                        if (j == 0)
                            l = 0;
                        else
                            l = array[i, j - 1];

                        if (j == array.GetLength(1) - 1)
                            r = 0;
                        else
                            r = array[i, j + 1];

                        if (array[i, j] > l && array[i, j] > r && array[i, j] > down && array[i, j] > up)
                            count++;
                    }
                }
            }

            return count;
        }
        // Отражает массив относительно главной диагонали
        public static int[,] FlipEl(int[,] array)
        {
            if (array.Length != 0)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;
                    }
                }

                return array;
            }

            return _ = new int[,] { { 0 } };
        }
    }
}
