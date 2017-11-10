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
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double pricePerKM = 0;
            if (weight >= 1.0 && weight <= 10) pricePerKM = 0.05;
            if (weight >= 11 && weight <= 40) pricePerKM = 0.10;
            if (weight >= 41 && weight <= 90) pricePerKM = 0.15;
            if (weight >= 91 && weight <= 150) pricePerKM = 0.20;
            if (weight < 1.0) pricePerKM = 0.03;

            double expressMarkup = 0;
            if (type == "express")
            {
                    if (pricePerKM == 0.03) expressMarkup = 0.8 * pricePerKM * weight * distance;
                if (pricePerKM == 0.05) expressMarkup = 0.4 * pricePerKM * distance * weight;
                if (pricePerKM == 0.10) expressMarkup = 0.05 * pricePerKM * distance * weight;
                if (pricePerKM == 0.15) expressMarkup = 0.02 * pricePerKM * distance * weight;
                if (pricePerKM == 0.20) expressMarkup = 0.01 * pricePerKM * distance * weight;
            }

            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weight, distance * pricePerKM + expressMarkup);
        }
    }
}
