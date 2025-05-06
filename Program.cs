using System;

namespace StrategyPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var app = new App();

            app.Start();

            Console.ReadKey();
        }
    }
}
