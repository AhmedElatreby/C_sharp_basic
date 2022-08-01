using System;

namespace ProgChallenge
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string FName, string LName)
        {
            FirstName = FName;
            LastName = LName;
        }

    }

}