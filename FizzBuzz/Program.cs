using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 1000; i++)
            {
                if ((i % 3) == 0) & ((i % 5 == 0));
                {
                    Console.WriteLine("{i} FizzBuzz");
                }
                else if ((i % 3) == 0) & ((i % 5 != 0));
                {
                    Console.WriteLine("{i} Fizz");
                }
                else if ((i % 3) != 0) & ((i % 5 == 0));
                {
                    Console.WriteLine("{i} Buzz");
                }
                else
                {
                    Console.WriteLine("{i}");
                }
            }
            Console.WriteLine()
        }
    }
}
