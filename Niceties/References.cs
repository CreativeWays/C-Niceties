using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niceties
{
    static class References
    {
        // Assign Varible
        public static string AssignToObj()
        {
            object inst = "555555";
            object instCpy = inst;
            throw new NotImplementedException("Still Implementing");        
        }
        public static string AssignToInt()
        {
            int inst = 555555;
            int instCpy = inst;
            throw new NotImplementedException("Still Implementing");   
        }
        public static string AssignToString()
        {
            string inst = "555555";
            string instCpy = inst;
            throw new NotImplementedException("Still Implementing");   
        }
        public static string AssignToObjArray()
        {
            int[] arr = new int[10];
            int[] instCpy = arr;
            throw new NotImplementedException("Still Implementing");   
        }
        public static string AssignToIntArray()
        {
            object[] arr = new object[10];
            throw new NotImplementedException("Still Implementing");   
        }   


        public static string ArrayAsRegularPassing(int[,] arr)
        {
            ArrayTest.FillIntArray(arr);
            ArrayHelpers.PrintArray(arr);
            int[,] arrCpy = arr;
            ArrayHelpers.UpdateArraAsRegularPassing(arr);

            bool result = IsChanged.IsNumericArraysEqual(arr, arrCpy);
            return String.Format("If array was passed into func without specific parameter and had been changed there" +
            "then it is NOT going to be changed everywhere. It is {0}", result);
        }
        // When you use REF the compliler will require you to assign your varible prior (перед тем как) to calling the method.
        public static string ArrayAsRefPassing(int[,] arr)
        {
            ArrayTest.FillIntArray(arr);
            ArrayHelpers.PrintArray(arr);
            int[,] arrCpy = arr;
            ArrayHelpers.UpdateArrayAsRefPassing(ref arr);

            bool result = IsChanged.IsNumericArraysEqual(arr, arrCpy);
            return String.Format("If array was passed into func with REF parameter and had been changed there" +
            "then it is NOT going to be changed everywhere. It is {0}", result);
        }
        // When using OUT it will not require this. 
        // This means that you will not be able to assume that the parameter has already been populated. 
        // You will not be able to read its value inside the method.
        public static string ArrayAsOutPassing(int[,] arr)
        {
            ArrayTest.FillIntArray(arr);
            ArrayHelpers.PrintArray(arr);
            int[,] arrCpy = arr;
            ArrayHelpers.UpdateArrayAsOutPassing(out arr);

            bool result = IsChanged.IsNumericArraysEqual(arr, arrCpy);
            return String.Format("If array was passed into func with OUT parameter and had been changed there" +
            "then it is NOT going to be changed everywhere. It is {0}", result);
        }
    }
}
