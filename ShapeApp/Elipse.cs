using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Elipse : Shape
    {
        private double a;
        private double b;
        private double circumference;
        private double area;

        public Elipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double calculateCircumference()
        {
            circumference = Math.PI * (3 / 2) * (a+b); 
            return circumference;
        }

        public override double calculateArea()
        {
            area = Math.PI * a * b;  
            return area;
        }
        public override void Result()
        {
            Console.WriteLine("a (semi-major axis)={0}\nb (semi-minor axis)={1}\nArea={2}\nCircumference={3}\n",
                a, b, calculateArea(), calculateCircumference());
        }
    }
}
