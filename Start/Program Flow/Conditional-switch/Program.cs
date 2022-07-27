using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 54;

            // TODO: The switch statement
            switch (theVal)
            {
                case 50:
                    Console.WriteLine($"The value is 50");
                    break;
                case 51:
                    Console.WriteLine($"The value is 51");
                    break;
                case 52:
                    Console.WriteLine($"The value is 52");
                    break;
                case 53:
                    Console.WriteLine($"The value is 53");
                    break;
                case 54:
                case 55:
                case 56:
                    Console.WriteLine($"The value is between 54 and 56");
                    break;
                default:
                    Console.WriteLine($"The value is over 56");
                    break;
            }


        }
    }
}
