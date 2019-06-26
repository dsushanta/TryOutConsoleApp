using System;

namespace TryOutConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tutorial t = new Tutorial(1, "C# Tutorial");
            Console.WriteLine(t);
        }
    }
}
