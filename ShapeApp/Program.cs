using System;
using System.Diagnostics;
using System.IO;

namespace ShapeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Circle circle = new Circle(1.0 + rnd.NextDouble() * 99.0);
            Console.WriteLine("\t\tCircle:");
            circle.calculateCircumference();
            circle.calculateArea();
            circle.Result();

            Elipse elipse = new Elipse(1.0 + rnd.NextDouble() * 150.0, 1.0 + rnd.NextDouble() * 150.0);
            Console.WriteLine("\t\tElipse");
            elipse.calculateCircumference();
            elipse.calculateArea();
            elipse.Result();

            Triangle triangle = new Triangle(1.0 + rnd.NextDouble() * 60.0);
            Console.WriteLine("\t\tTriangle(equilateral)");
            triangle.calculatePerimeter();
            triangle.calculateArea();
            triangle.Result();

            Square square = new Square(1.0 + rnd.NextDouble() * 99.0);
            Console.WriteLine("\t\tSquare");
            square.calculatePerimeter();
            square.calculateArea();
            square.Result();

            Rectangle rectangle = new Rectangle(1.0 + rnd.NextDouble() * 70.0, 1.0 + rnd.NextDouble() * 70.0);
            Console.WriteLine("\t\tSquare");
            rectangle.calculatePerimeter();
            rectangle.calculateArea();
            rectangle.Result();
            



            Console.ReadKey();
        }
    }
}
