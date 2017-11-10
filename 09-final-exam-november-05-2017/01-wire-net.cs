using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double lengthTotal = 2 * length + 2 * width;
            Console.WriteLine(lengthTotal);
            Console.WriteLine("{0:f2}", lengthTotal * price);
            Console.WriteLine("{0:f3}", lengthTotal * height * weight);
        }
    }
}
