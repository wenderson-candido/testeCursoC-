using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nplease What is your name?__");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}! ");
            Console.Write("\n==Press any Key to exit...==");
            Console.ReadKey(true);

        }
    }
}
