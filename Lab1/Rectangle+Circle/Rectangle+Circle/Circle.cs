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
        public double findArea;
        public double findDiameter;
        public double findCircumference;

        public Circle(double r)
        {
            radius = r;
            findArea = 3.14 * r * r;
            findDiameter = 2 * r;
            findCircumference = 2 * r * 3.14;
        }

        public override string ToString()
        {
            return findArea + " " + findDiameter + " " + findCircumference;
        }
    }
}
