using System;
using CounterLogic;

namespace CountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Count App!");
            Console.WriteLine("Press any key to start counting up to 10");
            Console.ReadKey(true);
            int count = 0;
            while (count < 10)
            {
                count++;
                Console.WriteLine(Counter.CountFormater(count));
                Console.ReadKey(true);
            }
            Console.WriteLine("Done!");
            Console.ReadKey(true);
        }
    }
}