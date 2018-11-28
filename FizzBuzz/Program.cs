using System;
// dotnet new console
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1001; i++)
            {
                if (i%3 == 0 && i%5 != 0)
                    Console.WriteLine(i+". Fizz");
                else if (i%3 != 0 && i%5 == 0)
                    Console.WriteLine(i+". Buzz");
                else if (i%3 == 0 && i%5 == 0)
                    Console.WriteLine(i+". FizzBuzz");
            }
        }
    }
}
