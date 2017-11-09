using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double Area = Math.PI * r * r;
            double Perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = " + Area);
            Console.WriteLine("Perimeter = " + Perimeter);
        }
    }
}
