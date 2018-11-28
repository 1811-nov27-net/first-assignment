using System;

namespace FizzBuzz.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int fizzbuzz = 0;
            int fizz = 0;
            int buzz = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if((i%3==0)&&(i%5==0))
                {
                    fizzbuzz++;
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0)
                {
                    fizz++;
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0)
                {
                    buzz++;
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
                
            }
            Console.WriteLine("Fizz: " + fizz);
            Console.WriteLine("Buzz: " + buzz);
            Console.WriteLine("FizzBuzz: " + fizzbuzz);
        }
    }
}
