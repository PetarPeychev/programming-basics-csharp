using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03.Sept_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTables = int.Parse(Console.ReadLine());
            double lengthTableMeters = double.Parse(Console.ReadLine());
            double widthTableMeters = double.Parse(Console.ReadLine());

            double areaTableCloths =
                numberTables * (lengthTableMeters + 2 * 0.30) * (widthTableMeters + 2 * 0.30);
            double areaTableSquares = numberTables * (lengthTableMeters / 2) * (lengthTableMeters / 2);

            double priceUSD = areaTableCloths * 7 + areaTableSquares * 9;
            double priceBGN = priceUSD * 1.85;

            priceUSD = Math.Round(priceUSD, 2);
            priceBGN = Math.Round(priceBGN, 2);

            Console.WriteLine("{0:f2} USD", priceUSD);
            Console.WriteLine("{0:f2} BGN", priceBGN);
        }
    }
}
