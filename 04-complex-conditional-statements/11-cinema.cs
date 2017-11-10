using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Conditionals_Exercises
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (str == "Premiere")
                Console.WriteLine(Math.Round(12.00 * a * b,2));
            else if (str == "Normal")
                Console.WriteLine(Math.Round(7.50 * a * b, 2));
            else if (str == "Discount")
                Console.WriteLine(Math.Round(5.00 * a * b, 2));
        }
    }
}
