using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1002;
            int y = 0;
            int result;

            // TODO: try-catch expressions make error checking easier
            try
            {
                if (x >= 1000)
                {
                    throw new ArgumentOutOfRangeException("x", "x has to be 100 or less");
                }
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"invalid number!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Sorry 100 is the limit!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"This line will always print");
            }
        }
    }
}
