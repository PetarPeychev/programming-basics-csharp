using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m;
            if (n % 2 == 0) m = 2;
            else m = 1;
            for (int i = 0; i < (n + 1) / 2; i++)
                Console.WriteLine("{0}{1}{0}", new string('-', (n + 1) / 2 - i - 1), new string('*', m + 2 * i));
            for (int i = 0; i < n / 2; i++)
                Console.WriteLine("|{0}|", new string('*', n - 2));
        }
    }
}
