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
        public double Area;
        public double Perimetr;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
            FindArea();
            FindPerimetr();
        }
        public void FindArea()
        {
            Area = width * height;
        }
        public void FindPerimetr()
        {
            Perimetr = 2 * (width + height);
        }
        public override string ToString()
        {
            return Area + " " + Perimetr;
        
        }
    }
}
