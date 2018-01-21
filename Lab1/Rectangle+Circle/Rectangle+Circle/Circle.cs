using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Circle
{
    class Circle
    {
        public double radius;
        public double Area;
        public double Diameter;
        public double Circumference;

        public Circle(double r)
        {
            radius = r;
            FindArea();
            FindCircumference();
            FindDiameter();
        }

        public void FindArea ()
        {
            Area = 3.14 * radius * radius;
        }
        public void FindDiameter ()
        {
            Diameter = 2 * radius;
        }
        public void FindCircumference()
        {
            Circumference = 2 * 3.14 * radius;
        }

        public override string ToString()
        {
            return Area + " " + Diameter + " " + Circumference;
        }
    }
}
