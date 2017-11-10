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
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m >= 45)
            {
                if (h == 23)
                {
                    h = 0;
                    m = m - 45;
                }
                else
                {
                    h++;
                    m = m - 45;
                }
            }
            else
                m = m + 15;

            if (m < 10)
                Console.WriteLine("{0}:0{1}",h ,m);
            else
                Console.WriteLine("{0}:{1}",h ,m);
        }
    }
}
