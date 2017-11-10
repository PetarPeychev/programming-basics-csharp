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
            double rad = double.Parse(Console.ReadLine());
            double deg = Math.Round(rad / Math.PI * 180);
            Console.WriteLine(deg);
        }
    }
}
