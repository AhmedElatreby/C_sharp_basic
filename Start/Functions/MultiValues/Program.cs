using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples are grouped values added in C# 7
            (int a, int b) tup1 = (5, 10);
            var tup2 = ("Some thing here", 10.5f);

            // TODO: Tuple values are mutable
            tup1.b = 20;
            tup2.Item1 = "some String";
            Console.WriteLine($"{tup1.a}, {tup1.b}");
            Console.WriteLine($"{tup2.Item1}, {tup2.Item2}");

            // TODO: Functions can work with tuples
            (int, int) result = PlusTimes(7, 5);
            Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");
        }

        // TODO: Functions can return multiple values using tuples
        static (int, int) PlusTimes(int a, int b)
        {
            return (a + b, a * b);
        }

    }
}
