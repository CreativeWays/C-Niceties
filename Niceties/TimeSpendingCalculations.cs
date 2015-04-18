using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Niceties
{
    class TimeSpendingCalculations
    {
        #region Conver Array to List Methods
        public static void CalcTimeSpendedInst()
        {
            int iterations = 1000;
            double[,] source = new double[iterations, iterations];            

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                UsingBlockCopy(source);
            }
            sw.Stop();
            Console.WriteLine("Block copy: {0}", sw.ElapsedMilliseconds);
        }
        // LINQ: 253463
        static List<double> UsingCast(double[,] array)
        {
            return array.Cast<double>().ToList();
        }

        // For loop: 9563
        static List<double> UsingForLoop(double[,] array)
        {
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            List<double> ret = new List<double>(width * height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    ret.Add(array[i, j]);
                }
            }
            return ret;
        }

        // Block copy: 8697 (The Most Efficient)
        static List<double> UsingBlockCopy(double[,] array)
        {
            double[] tmp = new double[array.GetLength(0) * array.GetLength(1)];
            Buffer.BlockCopy(array, 0, tmp, 0, tmp.Length * sizeof(double));
            List<double> list = new List<double>(tmp);
            return list;
        }
        #endregion
    }
}
