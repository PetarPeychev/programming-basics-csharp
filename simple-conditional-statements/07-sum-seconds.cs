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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            if (sum <= 9)
                Console.WriteLine("0:0" + sum);
            else if (sum <= 59)
                Console.WriteLine("0:" + sum);
            else if (sum <= 119)
            {
                if (sum >= 70)
                    Console.WriteLine("1:" + (sum - 60));
                else
                    Console.WriteLine("1:0" + (sum - 60));
            }
            else if (sum <= 179)
            {
                if (sum >= 130)
                    Console.WriteLine("2:" + (sum - 120));
                else
                    Console.WriteLine("2:0" + (sum - 120));
            }               
        }
    }
}
