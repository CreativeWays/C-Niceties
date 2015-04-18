using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niceties
{
    static class ArrayTest
    {
        #region
        
        #endregion
        // Instantiation
        #region
        // Descr.
        public static int[] FillIntArray(int[] arr)
        {
            ForInst(arr, ArrayHelpers.GetRandomInt);
            return arr;
        }  
        public static int[,] FillIntArray(int[,] arr)
        {
            ForInst(arr, ArrayHelpers.GetRandomInt);
            return arr;
        }        
        #endregion

        // Work with array dimention
        #region
        // Gets a 32-bit integer that represents the total number of elements in all the dimensions of the Array (https://msdn.microsoft.com/en-us/library/system.array.length(v=vs.110).aspx)
        public static string ArrayLengthFunc(int[,] arr)        {
            
            return string.Format("Total number of elements in all the dimensions of the Array: {0}", arr.Length);
        }
        // Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array (https://msdn.microsoft.com/ru-ru/library/system.array.getlength(v=vs.110).aspx)
        public static string ArrayGetLengthFunc(int[,] arr)
        {
            return string.Format("Number of elements in first dimention: {0}, in second dimention {1}", arr.GetLength(0), arr.GetLength(1));
        }
        #endregion

        // Loops
        #region
        // For Loop for 2d Array
        public static int[] For1DInst(int[] arr, Func<int, int> method = null)
        {
            if (method == null)
                return arr;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = method(10);
            return arr;
        }
        public static int[,] For2DInst(int[,] arr, Func<int, int> method = null)
        {
            if (method == null)
                return arr;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = method(10);
            return arr;            
        }
        // ForEach for 2d Array
        public static int[,] ForEachInst(int[,] arr, Func<int, int> method = null)
        {
            if (method == null)
                return arr;
            List<int> lst = ArrayHelpers.ArrayToList(arr);
            foreach (var item in lst.Select((value, i) => new { i, value }))
                lst[item.i] = method(10);
            return arr; 
        }
        // ForEach for Jagged Array
        public static int[][] ForEachJaggedInst(int[][] arr, Func<int, int> method = null)
        {
            if (method == null)
                return arr;
            foreach (int[] entry in arr)
                foreach (int element in entry)
                    method(10);
             return arr;
        }
        // While Loop for 2d Array
        public static int[,] WhileInst(int[,] arr, Func<string, int> method = null)
        {
            if (method == null)
                return arr;
            return arr; 
        }
        #endregion

        
    }
}
