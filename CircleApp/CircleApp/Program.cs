using System;

namespace CircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Create the 3 radius values by user input
            Circle[] circles = new Circle[3];
            for (int i = 0; i < circles.Length; i++)
            {
               
                circles[i] = new Circle(DataInput());
                Console.WriteLine(circles[i]);

            }
            /* // Different solution 
            circles[0] = new Circle(10);
            circles[1] = new Circle(20);
            circles[2] = new Circle(33);
            
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine(circles[i]);
              
            }
            // 2nd loop just for sample
            /*
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }*/
          
            Console.ReadKey();
        }

        public static double DataInput()
        {
            try
            {
                Console.WriteLine("Please enter the radius value and you will get the Area and Perimeter of circle calculated");
                string numberInput = Console.ReadLine();
                double number = int.Parse(numberInput);
                return number;
            }
            catch
            {
                Console.WriteLine("Use only numbers for specifying radius otherwise you will have 0 instead by default");
                return 0;
            }
           
        }
    }
}
