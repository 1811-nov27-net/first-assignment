using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzCounter = 0;
            int buzzCounter = 0;
            int fizzbuzzCounter = 0;

            for (double i = 1; i <= 1000; i++) {
                if ((i/3) % 1 == 0 && (i/5) % 1 == 0) {
                    Console.WriteLine("Fizzbuzz");
                    fizzbuzzCounter++;
                }
                else if ((i/3) % 1 == 0 && (i/5) % 1 != 0) {
                    Console.WriteLine("Fizz");
                    fizzCounter++;
                }
                else if ((i/3) % 1 != 0 && (i/5) % 1 == 0) {
                    Console.WriteLine("Buzz");
                    buzzCounter++;
                }
                else{
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Fizz: " + fizzCounter);
            Console.WriteLine("Buzz: " + buzzCounter);
            Console.WriteLine("Fizzbuzz: " + fizzbuzzCounter);
        }
    }
}
