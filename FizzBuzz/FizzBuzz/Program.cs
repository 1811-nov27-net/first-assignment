using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzCount = 0, buzzCount = 0, fizzBuzzCount = 0;
            for(int i=1;i<1001;i++)
            {
                bool three=false,five=false;
                
                if(i%3==0)
                {
                    three=true;
                }
                if(i%5==0)
                {
                    five=true;

                }

                if(three && five)
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzBuzzCount++;
                } else if(three)
                {
                    Console.WriteLine("Fizz");
                    fizzCount++;
                } else if(five)
                {
                    Console.WriteLine("Buzz");
                    buzzCount++;
                } else
                {
                    Console.WriteLine(i);
                }

                
            }
            Console.WriteLine($"Fizz count was {fizzCount}, Buzz Count was {buzzCount} and FizzBuzz Count was {fizzBuzzCount}.");
        }
    }
}
