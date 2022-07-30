using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // TODO: Output information using formatting
            Console.WriteLine("This car is a {0}, {1}, {2}, with {3} miles and cost ${4}",
             year, make, model, miles, price);

            // TODO: Using string interpolation

            Console.WriteLine($"This car is a {year}, {make}, {model}, with {miles} miles and cost £{price:N1}");


            // TODO: With inline expressions
            Console.WriteLine($"This car is a {year}, {make}, {model}, with {{{miles * 1.6:n2}}} km and cost £{price:N1}");


        }
    }
}
