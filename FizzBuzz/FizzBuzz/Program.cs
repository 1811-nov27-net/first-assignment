using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fizz = 0;
            int Buzz = 0;
            int FizzBuzz = 0;
            for(int i = 1; i <= 1000; i++){
                if(!(i % 3) && i % 5)
                {
                    System.Console.WriteLine("Fizz");
                    Fizz++;
                }
                else if(!(i % 5) && i % 3){
                    System.Console.WriteLine("Buzz");
                    Buzz++;
                }
                else if (!(i % 3) && !(i % 5)){
                    System.Console.WriteLine("Fizzbuzz");
                    FizzBuzz++;
                }
                else
                {
                    System.Console.WriteLine(i);
                }
                System.Console.WriteLine("Fizz: "+ Fizz);
                System.Console.WriteLine("Buzz: "+ Buzz);
                System.Console.WriteLine("FizzBuzz: "+ FizzBuzz);
            }
        }
    }
}
