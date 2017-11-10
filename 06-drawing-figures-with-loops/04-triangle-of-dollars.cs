using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_Dollars
{
    class TriangleDollars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
