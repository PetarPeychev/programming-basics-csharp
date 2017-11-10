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
            string w1 = Console.ReadLine().ToUpper();
            string w2 = Console.ReadLine().ToUpper();
            if (w1 == w2)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
