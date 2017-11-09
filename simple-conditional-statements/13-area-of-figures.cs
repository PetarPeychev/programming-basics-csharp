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
            string type = Console.ReadLine();
            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * a, 3));
            }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * b, 3));
            }
            else if (type == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * r * r, 3));
            }
            else if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * h) / 2, 3));
            }
        }
    }
}
