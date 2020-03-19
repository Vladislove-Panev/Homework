using System;

namespace FinaleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arr1 = new int[,]
                    {
                    { 1},
                    { -1},
                    { 4}
                    };

            arr1 = MyArrays.FlipEl(arr1);
            MyArrays.PrintArray(arr1);
        }
    }
}
