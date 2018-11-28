using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare counter variables
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzbuzzCount = 0;

            // For loop to count through the numbers
            for(var i = 1; i <= 1000; i++) 
            {
                // If the number is divisible by BOTH 3 and 5
                if (i%3 == 0 && i%5 == 0)
                {
                    System.Console.WriteLine("Fizzbuzz");
                    fizzbuzzCount++;
                }

                // If the number is divisible by 3 and NOT 5
                if (i%3 == 0 && i%5 != 0)
                {
                    System.Console.WriteLine("Fizz");
                    fizzCount++;
                }

                // If the number is divisible by 5 and NOT 3
                if (i%3 != 0 && i%5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    buzzCount++;
                }

                // If the number is divisible by NEITHER 3 or 5
                if (i%3 != 0 && i%5 != 0)
                {
                    System.Console.WriteLine(i);
                    
                }
            }
        }
    }
}
