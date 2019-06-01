using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImplifying_Array_Initializations
{
    class Program
    {
        static void Main()
        {
            // There are two ways to shorten initialize array expressions
            // 1. To omit the new operator and type qualifications:
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[,] rectangularMatrix =
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            // 2. To use the var keyword, which tells the compiler to implicitly type a variable:
            var i = 3;          // i is implicitly of type int.
            var s = "sausage";  // s is implicitly of type string.
            Console.WriteLine(i);
            Console.WriteLine(s);
            // Therefore:

            var rectMatrix = new int[,] // rectMatrix is implicitly of type int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            var jaggedMat = new int[][] // jaggedMat is implicitly of type int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8},
            };
            // Implicit typing can be take one stage further with arrays.
            // You can omit the type qualifier after the new keyword and have the compiler infer the array type:
            var vowels2 = new[] { 'a', 'e', 'i', 'o', 'u' };    // Compiler infers char[]
            var x = new[] { 1, 10000000000 };   // all convertible to long
        }
    }
    }
}
