using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Triangle : Shape
    {
        private double s;
        private double h;
        private double perimeter;
        private double area;

        public Triangle(double s)
        {
            this.s = s;
        }
        public override double calculatePerimeter()
        {
            perimeter = 3 * s;
            return perimeter;
        }

        public override double calculateArea()
        {
            area = (Math.Sqrt(3) / 4) * Math.Pow(s,2);
            return area;
        }
        public override void Result()
        {
            Console.WriteLine("sides={0}\nArea={1}\nPerimeter={2}\n", s, calculateArea(), calculatePerimeter());
        }

    }
}
