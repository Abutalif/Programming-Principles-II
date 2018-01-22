using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int a, b;
        public Complex() { }
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex any = new Complex();
            any.a = c1.a + c2.a;
            any.b = c1.b + c2.b;
            return any;
        }
        public override string ToString()
        {
            return a + " " + b;
        }
    }
}
