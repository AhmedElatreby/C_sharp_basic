using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quarters = { 1, 2, 3, 4 };
            int[] sales = { 100000, 150000, 200000, 225000 };
            double[] intlMixPct = { .386, .413, .421, .457 };
            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic Formatting information
            Console.WriteLine("{0}", str1);

            // TODO: Specifying Numerical formatting
            // General format is {index[,alignment]:[format]}
            // Common types are N (Number), G (General), F (Fixed-point), 
            // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
            // C (Currency in local format)
            Console.WriteLine("{0:N}, {0:G}, {0:F}, {0:E}, {0:D}, {0:P}, {0:X}, {0:C}", val1);

            // TODO: Add a number after the format to specify precision
            Console.WriteLine("{0:N4}, {0:G3}, {0:F1}, {0:E5}, {0:D2}, {0:P5}, {0:X2}, {0:C6}", val1);

            // TODO: Formatting with alignment and spacing
            Console.WriteLine("{0,12} {1,12} {2,12} {3,12}",
             quarters[0], quarters[2], quarters[2], quarters[3]);

            Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}",
             sales[0], sales[2], sales[2], sales[3]);

            Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}",
             intlMixPct[0], intlMixPct[2], intlMixPct[2], intlMixPct[3]);



        }
    }
}
