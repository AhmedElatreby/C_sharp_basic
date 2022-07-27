using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 51;

            // TODO: if-else 
            if (theVal == 50)
            {
                Console.WriteLine($"the value is 50");

            }
            else if (theVal >= 51 && theVal <= 60)
            {
                Console.WriteLine($"The value is between 51 and 60 ");


            }
            else
            {
                Console.WriteLine($"the value is something else");

            }


            // -----------------------
            // TODO: Using the ternary operator ?:

            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: can be replaced by a ternary operator ?:
            Console.WriteLine(theVal < 50 ? "the value is less than 50" : "the value is greater then 50");


        }
    }
}
