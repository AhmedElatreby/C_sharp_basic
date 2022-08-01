using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("All about C#", "someone", 567);
            Book b2 = new Book("The best about C#", "someone", 569);

            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

            // TODO: try to set one of the properties -- 
            // this will result in an error
            b1._name = "something new";

        }
    }
}
