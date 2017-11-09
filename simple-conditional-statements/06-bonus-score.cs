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
            double num = double.Parse(Console.ReadLine());
            double bon = 0;
            if (num <= 100)
                bon = 5;
            else if (num > 1000)
                bon = num / 10;
            else if (num > 100)
                bon = num / 5;
            if (num % 2 == 0)
                bon++;
            if (num % 5 == 0 && num % 10 != 0)
                bon = bon + 2;
            Console.WriteLine(bon);
            Console.WriteLine(bon + num);
        }
    }
}
