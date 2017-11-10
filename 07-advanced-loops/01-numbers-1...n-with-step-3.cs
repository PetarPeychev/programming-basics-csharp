using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersNStep3
{
    class NumbersNStep3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i+=3)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
