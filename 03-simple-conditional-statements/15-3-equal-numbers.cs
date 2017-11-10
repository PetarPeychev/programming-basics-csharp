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
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();

            if (a == b && b == c)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
