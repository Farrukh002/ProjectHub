using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Rectangle : Shape
    {
        private double l;
        private double w;
        private double perimeter;
        private double area;

        public Rectangle(double l, double w)
        {
            this.l = l;
            this.w = w;
        }
        public override double calculatePerimeter()
        {
            perimeter = 2 * (l+w);
            return perimeter;
        }

        public override double calculateArea()
        {
            area = l * w;
            return area;
        }
        public override void Result()
        {
            Console.WriteLine("length={0}\nwidth={1}\nArea={2}\nPerimeter={3}\n", l, w, calculateArea(), calculatePerimeter());
        }
    

    }
}
