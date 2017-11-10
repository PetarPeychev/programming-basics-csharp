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
            double usd = double.Parse(Console.ReadLine());
            double bgn = Math.Round(usd * 1.79549, 2);
            Console.WriteLine(bgn + " BGN");
        }
    }
}
