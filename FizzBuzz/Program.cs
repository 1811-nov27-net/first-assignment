using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if(i % 3 == 0 && i % 5 != 0)
                {
                    System.Console.WriteLine("Fizz");
                    ++fizzCount;
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    System.Console.WriteLine("Buzz");
                    ++buzzCount;
                }
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                    ++fizzBuzzCount;
                }
                else
                    System.Console.WriteLine(i);

            }

            System.Console.WriteLine("Total Fizz: " + fizzCount);
            System.Console.WriteLine("Total Buzz: " + buzzCount);
            System.Console.WriteLine("Total FizzBuzz: " + fizzBuzzCount);
        }
    }
}
