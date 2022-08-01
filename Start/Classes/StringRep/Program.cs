using System;

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Every class in C# inherits from Object, which means
            // that every class inherits the ToString() method
            int x = 100;
            Console.WriteLine(x.ToString());

            // TODO: if you don't override the method, the default behavior just prints
            // the name of the class and the namespace
            object a = new object();
            Console.WriteLine($"{a}");



            // TODO: use the ToString method on the Book class
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            Console.WriteLine($"{b1.ToString()}");
            Console.WriteLine($"{b1}");     // this going to work the same as ToString

            Console.WriteLine($"{b1.ToString('B')}"); // overload ToString
            Console.WriteLine($"{b1.ToString('F')}"); // overload ToString
            Console.WriteLine($"{b1.ToString()}"); // override ToString





        }
    }
}
