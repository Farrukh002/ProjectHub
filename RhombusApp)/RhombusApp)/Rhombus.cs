using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusApp_
{
    internal class Rhombus
    {
        private float a, d1, d2;

        public Rhombus(float a, float d1, float d2)
        {
            this.a = a;
            this.d1 = d1;
            this.d2 = d2;
        }

        public void setA(float a)
        {
            this.a = a;
        }
    
        public float getA()
        {
            return a;
        }

        public void setD1(float d1)
        {
            this.d1 = d1;
        }
        public float getD1()
        {
            return d1;
        }

      public void setD2(float d2)
        {
            this.d2 = d2;
        }
        public float getD2()
        {
            return d2;
        }

        private double getArea()
        {
            return 1.0 / 2.0 * d1 * d2;
        }
        private double getPerimeter()
        {
            return 4 * a;
        }

        public override string ToString()
        {
            return string.Format("a={0}cm, d1={1}cm, d2={2}cm\nPerimeter={3}cm\nArea={4}cm\n", a, 
                d1, d2, getPerimeter(), getArea());
        }

    }
    
}
