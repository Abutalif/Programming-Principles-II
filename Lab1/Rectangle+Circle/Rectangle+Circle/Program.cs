using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Радиус");
            Circle r = new Circle(double.Parse(Console.ReadLine()));
            Console.WriteLine(r);
            Console.WriteLine("Введите Ширину и Высоту.");
            Rectangle c = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(c);
        }
    }
}
