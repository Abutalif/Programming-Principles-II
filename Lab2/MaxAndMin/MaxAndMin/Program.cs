using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"C:\test\Textv.txt");
            string[] massiv = s.Split(' ');
            int min = int.Parse(massiv[0]); 
            int max = int.Parse(massiv[0]);
            for (int i=1; i<massiv.Length; i++)
            {
                if (int.Parse(massiv[i]) > max) max = int.Parse(massiv[i]);
                if (int.Parse(massiv[i]) < min) min = int.Parse(massiv[i]);
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
