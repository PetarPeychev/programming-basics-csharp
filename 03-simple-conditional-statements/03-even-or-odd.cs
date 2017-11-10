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
            double grade = double.Parse(Console.ReadLine());
            if (grade % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
        }
    }
}
