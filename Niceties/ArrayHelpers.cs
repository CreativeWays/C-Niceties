using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niceties
{
    static class ArrayHelpers
    {
        // Return random INT number
        static Random rnd = new Random();
        public static int GetRandomInt(int max)
        {
            return rnd.Next(1, max);
        }
        // Print array.
        public static void PrintArray(int[,] arr)
        {
            Console.Write("Array:");
            foreach (int i in arr)
                Console.Write(" " + i);
            Console.WriteLine();
        }

        // Conver Array to another format
        // Conver Array To List and return It
        // Block copy: 8697 (The Most Efficient)
        public static List<int> ArrayToList(int[,] array)
        {
            int[] tmp = new int[array.GetLength(0) * array.GetLength(1)];
            Buffer.BlockCopy(array, 0, tmp, 0, tmp.Length * sizeof(int));
            List<int> list = new List<int>(tmp);
            return list;
        }
        // Conver List To 2D Array and return It
        public static int[,] ListTo2DArray(List<int> lst, int bound0 = 5, int bound1 = 1)
        {
            if (bound0*bound1 != lst.Capacity)
                throw new ArgumentException("During converting List to 2d Array appears error: New 2d array size isn't equals to entered list");
            int[,] arr = new int[bound0, bound1];
            for (int i = 0; i < bound0; i++)
                for (int j = 0; j < bound1; j++)
                    arr[i, j] = lst[i * bound1 + j];
            return arr;
        }

        // II.1 Array passing
        // II.1.A Without specific parameters
        public static void UpdateArraAsRegularPassing(int[,] arr)
        {
            ArrayTest.For2DInst(arr, ArrayHelpers.GetRandomInt);
        }
        // II.1.B With REF parameter
        public static void UpdateArrayAsRefPassing(ref int[,] arr)
        {
            ArrayTest.For2DInst(arr, ArrayHelpers.GetRandomInt);
        }
        // II.1.C With OUT parameter
        public static void UpdateArrayAsOutPassing(out int[,] arr)
        {
            // In this method we not be able to read ARR value. Thet's why we initialize it again
            arr = new int[5, 2];
            ArrayTest.FillIntArray(arr);
        }
    }
}
