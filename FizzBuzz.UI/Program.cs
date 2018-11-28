using System;

namespace FizzBuzz.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (var i = 0; i < 1000; i++)
            {
                ConsoleWriteLine(i);
            }
            while (false)
            {
                ConsoleWriteLine("FIZZ");
            }
            if (true)
            {
                ConsoleWriteLine("BUzz");
            }
        }
    }
}
