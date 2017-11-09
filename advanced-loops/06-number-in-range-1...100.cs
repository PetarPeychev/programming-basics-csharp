using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Range100
{
    class Range100
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Еnter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100) break;
                else Console.WriteLine("Invalid number!");
            }
            Console.Write("The number is: ");
            Console.WriteLine(n);
        }
    }
}
