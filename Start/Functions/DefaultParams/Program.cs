using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix = "") // ="" this will allow to not use the parameters 
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hello", "there!");
PrintWithPrefix("Hello There!");

// TODO: Call with named params
PrintWithPrefix(prefix: "---", thestr: "Hello there!");

