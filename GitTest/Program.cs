using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 3;

            // print to console

            Console.WriteLine($"{x} + {y} = {Calculator.Add(x,y)}");
            Console.ReadKey();

        }
    }
}
