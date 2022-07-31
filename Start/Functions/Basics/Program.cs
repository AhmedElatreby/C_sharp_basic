using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float milesToKm(float miles)
{
    float result = miles * 1.6f;
    return result;
}

// TODO: A function with no return value has a 'void' type
void printWithPrefix(String str)
{
    Console.WriteLine($"::> {str} ");
}


// TODO: Call first function
Console.WriteLine($"The result is {milesToKm(8.0f):N2}");
Console.WriteLine($"The result is {milesToKm(52.0f):N2}");

// TODO: Call second function

printWithPrefix("Test string");
printWithPrefix("Test another string");