using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Conditionals_Exercises
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string prod = Console.ReadLine();
            string town = Console.ReadLine();
            double quant = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (town == "Sofia")
            {
                if (prod == "coffee") price = 0.50;
                else if (prod == "water") price = 0.80;
                else if (prod == "beer") price = 1.20;
                else if (prod == "sweets") price = 1.45;
                else if (prod == "peanuts") price = 1.60;
            }    
            else if (town == "Plovdiv")
            {
                if (prod == "coffee") price = 0.40;
                else if (prod == "water") price = 0.70;
                else if (prod == "beer") price = 1.15;
                else if (prod == "sweets") price = 1.30;
                else if (prod == "peanuts") price = 1.50;
            }    
            else if (town == "Varna")
            {
                if (prod == "coffee") price = 0.45;
                else if (prod == "water") price = 0.70;
                else if (prod == "beer") price = 1.10;
                else if (prod == "sweets") price = 1.35;
                else if (prod == "peanuts") price = 1.55;
            }

            Console.WriteLine(price * quant);
        }
    }
}
