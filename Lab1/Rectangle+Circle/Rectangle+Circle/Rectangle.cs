using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Circle
{
    class Rectangle
    {
        public double width;
        public double height;
        public double findArea;
        public double findPerimetr;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
            findArea = w * h;
            findPerimetr = (w + h) * 2;
        }

        public override string ToString()
        {
            return findArea + " " + findPerimetr;
        
        }
    }
}
