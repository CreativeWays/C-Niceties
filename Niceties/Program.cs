using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niceties
{
    class Program
    {
        // Agreements.

        // I. To allocate current testing part we can change console output color to make it more noticeable
        // Console.ForegroundColor = ConsoleColor.Green;
        // End at the of it
        // Console.ResetColor();

        // II. To split different chapters we can use this single line:
        // Console.WriteLine("*********************");

        // III. To split different parts of chapters we can use this single line:
        // --------------------------------------------------

        // IV. Every chapter has specific number as roman numeral
        //     Every section has specific number as arabic numeral
        //     Every subsection has specific number as latin alphabet

        static void Main(string[] args)
        {            
            Console.WriteLine("*********************");
            Console.WriteLine("I. Arrays");
            int[,] arr = new int[5, 2];
            // --------------------------------------------------
            Console.WriteLine("I.1 Work with array dimention");

            Console.WriteLine("I.1.A Length Function");
            Console.WriteLine(ArrayTest.ArrayLengthFunc(arr));

            Console.WriteLine("I.1.B GetLength Function");
            Console.WriteLine(ArrayTest.ArrayGetLengthFunc(arr));

            // --------------------------------------------------
            Console.WriteLine("I.2 Loops");

            Console.WriteLine("I.2.A ForEach");            
            Console.WriteLine(ArrayTest.ArrayLengthFunc(arr));            

            // --------------------------------------------------
            // --------------------------------------------------


            Console.WriteLine("*********************");
            Console.WriteLine("II. References");
            Console.WriteLine("II.1 Array passing");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("II.1.A Without specific parameters");         
            Console.WriteLine(References.ArrayAsRegularPassing(arr));
            Console.WriteLine("II.1.B With REF parameter");
            Console.WriteLine(References.ArrayAsRefPassing(arr));
            Console.WriteLine("II.1.C With OUT parameter");
            Console.WriteLine(References.ArrayAsOutPassing(arr));
            Console.ResetColor();
            // --------------------------------------------------
            // --------------------------------------------------
        }
    }
}
