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
            double amountTomatoes = double.Parse(Console.ReadLine());
            int amountBoxes = int.Parse(Console.ReadLine());
            int amountJars = int.Parse(Console.ReadLine());

            double totalLut = amountTomatoes / 5.0;
            double jars = totalLut / 0.535;
            double boxes = jars / amountJars;
            Console.WriteLine($"Total lutenica: {Math.Floor(totalLut)} kilograms.");

            double blah = Math.Floor((amountBoxes* amountJars) -jars);

            if (boxes > amountBoxes)
            {
                Console.WriteLine($"{Math.Floor(boxes - amountBoxes)} boxes left.");
                Console.WriteLine($"{Math.Floor(jars - (amountBoxes * amountJars))} jars left.");
            }
            else if (boxes < amountBoxes)
            {
                Console.WriteLine($"{Math.Floor(amountBoxes - boxes)} more boxes needed.");
                Console.WriteLine($"{blah} more jars needed.");

            }
        }
    }
}
