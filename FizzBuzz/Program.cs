using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
         int buzzCount = 0;  
         int fizzCount = 0;
         int fbCount = 0;
         
         for (int i = 0; i < 1000; i++) {
             if (i % 3  == 0 && i % 5 != 0) {
                  
                 buzzCount++;
             }
             else if(i % 5 == 0 && i % 3 !=0) {
                fizzCount++;
                
             }
             else if (i % 5 == 0 && i % 3 == 0) {
                 fbCount ++;
             }
            }
         System.Console.WriteLine($"Buzz count {buzzCount}");
         System.Console.WriteLine($"Fizz count {fizzCount}");
         System.Console.WriteLine($"FizzBuzz count {fbCount}");   
        }
    }
}
