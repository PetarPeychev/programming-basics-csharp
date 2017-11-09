using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Conditionals_Exercises
{
    class Comissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());

            if (money >= 0 && money <= 500)
            {
                if (town == "Sofia")
                    Console.WriteLine(Math.Round(5.0 / 100 * money, 2));
                else if (town == "Varna")
                    Console.WriteLine(Math.Round(4.5 / 100 * money, 2));
                else if (town == "Plovdiv")
                    Console.WriteLine(Math.Round(5.5 / 100 * money, 2));
                else Console.WriteLine("error");
            }
            else if (money > 500 && money <= 1000)
            {
                if (town == "Sofia")
                    Console.WriteLine(Math.Round(7.0 / 100 * money, 2));
                else if (town == "Varna")
                    Console.WriteLine(Math.Round(7.5 / 100 * money, 2));
                else if (town == "Plovdiv")
                    Console.WriteLine(Math.Round(8.0 / 100 * money, 2));
                else Console.WriteLine("error");
            }
            else if (money > 1000 && money <= 10000)
            {
                if (town == "Sofia")
                    Console.WriteLine(Math.Round(8.0 / 100 * money, 2));
                else if (town == "Varna")
                    Console.WriteLine(Math.Round(10.0 / 100 * money, 2));
                else if (town == "Plovdiv")
                    Console.WriteLine(Math.Round(12.0 / 100 * money, 2));
                else Console.WriteLine("error");
            }
            else if (money > 10000)
            {
                if (town == "Sofia")
                    Console.WriteLine(Math.Round(12.0 / 100 * money, 2));
                else if (town == "Varna")
                    Console.WriteLine(Math.Round(13.0 / 100 * money, 2));
                else if (town == "Plovdiv")
                    Console.WriteLine(Math.Round(14.5 / 100 * money, 2));
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
