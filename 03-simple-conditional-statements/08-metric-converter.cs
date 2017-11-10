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
            double input = double.Parse(Console.ReadLine());
            string uni = Console.ReadLine();
            string uno = Console.ReadLine();

            if (uni == "mm")
                input = input / 1000;
            else if (uni == "cm")
                input = input / 100;
            else if (uni == "mi")
                input = input / 0.000621371192;
            else if (uni == "in")
                input = input / 39.3700787;
            else if (uni == "km")
                input = input / 0.001;
            else if (uni == "ft")
                input = input / 3.2808399;
            else if (uni == "yd")
                input = input / 1.0936133;

            if (uno == "mm")
                input = input * 1000;
            else if (uno == "cm")
                input = input * 100;
            else if (uno == "mi")
                input = input * 0.000621371192;
            else if (uno == "in")
                input = input * 39.3700787;
            else if (uno == "km")
                input = input * 0.001;
            else if (uno == "ft")
                input = input * 3.2808399;
            else if (uno == "yd")
                input = input * 1.0936133;

            Console.WriteLine(input);

        }
    }
}
