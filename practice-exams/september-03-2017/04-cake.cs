using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03.Sept_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int pieces = width * length;

            for (int i = 0; i == 0 && pieces >= 0 ;)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    i = 1;
                }
                else
                {
                    pieces -= int.Parse(input);
                }
            }

            if (pieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }
            else Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}
