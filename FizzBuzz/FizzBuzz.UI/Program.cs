﻿using System;

namespace FizzBuzz.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fizzbuzz = 0;
            int Fizz = 0;
            int Buzz = 0;

            for(int i =1; i <= 1000; i++)
            {
                if ((i%3 ==0) && (i%5 ==0))
                {
                    System.Console.WriteLine("Fizzbuzz");
                    Fizzbuzz = Fizzbuzz + 1;
                    //Fizzbuss++;
                }
                else if (i%3==0)
                {
                    System.Console.WriteLine("Fizz");
                    Fizz++;
                }
                else if (i%5==0)
                {
                    System.Console.WriteLine("Buzz");
                    Buzz++;
                }
                else 
                {
                    System.Console.WriteLine(i);
                }
        
            }
            System.Console.WriteLine( "Fizzbuzz: " + Fizzbuzz);
            System.Console.WriteLine( "Fizz: " + Fizz);
            System.Console.WriteLine( "Buzz: " + Buzz);

        }
    }
}
