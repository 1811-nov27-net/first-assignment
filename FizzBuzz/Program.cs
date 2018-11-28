using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int _fizz = 0;
            int _buzz = 0;
            int _fizzBuzz = 0;
            
            for(var i=0; i<1000; i++)
            {
                if((i%3 == 0) && (i%5 != 0))
                {
                    Console.Write("Fizz");
                    _fizz++;
                }
                else if((i%5 == 0) && (i%3 != 0))
                {
                    Console.Write("Buzz");
                    _buzz++;
                }
                else if((i%5 == 0) && (i%3 == 0))
                {
                    Console.Write("FizzBuzz");
                    _fizzBuzz++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write($"fizz: {_fizz}, buzz: {_buzz}, fizzbuzz: {_fizzBuzz}");
        }
    }
}
