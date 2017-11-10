using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Loops_Exercises
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    double currNum = double.Parse(Console.ReadLine());
                    evenSum += currNum;

                    if (currNum > evenMax)
                        evenMax = currNum;

                    if (currNum < evenMin)
                        evenMin = currNum;
                }
                else
                {
                    double currNum = double.Parse(Console.ReadLine());
                    oddSum += currNum;

                    if (currNum > oddMax)
                        oddMax = currNum;

                    if (currNum < oddMin)
                        oddMin = currNum;
                }
            }

            Console.WriteLine("OddSum=" + oddSum + ",");
            if (oddMin == int.MaxValue) Console.WriteLine("OddMin=No,");
            else Console.WriteLine("OddMin=" + oddMin + ",");
            if (oddMax == int.MinValue) Console.WriteLine("OddMax=No,");
            else Console.WriteLine("OddMax=" + oddMax + ",");

            Console.WriteLine("EvenSum=" + evenSum + ",");
            if (evenMin == int.MaxValue) Console.WriteLine("EvenMin=No,");
            else Console.WriteLine("EvenMin=" + evenMin + ",");
            if (evenMax == int.MinValue) Console.WriteLine("EvenMax=No,");
            else Console.WriteLine("EvenMax=" + evenMax);
        }
    }
}
