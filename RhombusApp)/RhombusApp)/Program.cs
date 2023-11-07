using System;

namespace RhombusApp_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            Random random = new Random();
            Rhombus rhombus = new Rhombus((float)random.NextDouble() + random.Next(5, 20),
                  (float)random.NextDouble() + random.Next(5, 20), (float)random.NextDouble() 
                  + random.Next(5, 20));

            Console.WriteLine(rhombus);
           


            Console.ReadKey();
        }
    }
}
