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
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y1 - y2);
            double area = a * b;
            double perimeter = a * 2 + b * 2;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
