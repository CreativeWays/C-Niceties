using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niceties
{
    static class IsChanged
    {
        // This func is comparing for equality 2 different double arrays
        // return false on first dufferent element
        public static bool IsNumericArraysEqual(int[,] a, int[,] b)
        {
            if (a.Length != b.Length)
            {
                throw new ArgumentException("Represented arrays have a different sizes");
            }
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != b[i, j])
                        return false;
                }
            return true;
        }
    }
}
