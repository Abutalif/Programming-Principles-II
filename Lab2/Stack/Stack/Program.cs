using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExample
{
    class Program
    {

        static void showStackTree(string path, int depth = 0)
        {
            string s = "";
            Stack<DirectoryInfo> myS = new Stack<DirectoryInfo>();
            DirectoryInfo dir = new DirectoryInfo(path);
            myS.Push(dir);
            while (myS.Count > 0)
            {
                DirectoryInfo cur = myS.Pop();
                foreach (DirectoryInfo d in cur.GetDirectories())
                {
                    for (int i = 0; i < depth; i++)
                        Console.Write(" ");
                    Console.WriteLine(d.Name);
                    myS.Push(d);
                    showStackTree(d.FullName, depth+5);
                }
                foreach (FileInfo f in cur.GetFiles())
                {
                    for (int i = 0; i < depth; i++)
                        Console.Write(" ");
                    Console.WriteLine(f.Name);

                }
                depth += 5;
            }

        }


        static void Main(string[] args)
        {
            showStackTree(@"C:\test");
            Console.ReadKey();
        }
    }
}