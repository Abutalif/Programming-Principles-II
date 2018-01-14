using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Student
    {
        public string name;
        public string lastname;
        public double gpa;

        public Student(string name, string lastname, double gpa)
        {
            this.name = name;
            this.lastname = lastname;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return name + " " + lastname + " " + gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));
            Console.WriteLine(s);
        }
    }
}